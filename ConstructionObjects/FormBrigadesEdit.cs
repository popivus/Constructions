using ConstructionsObjects.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConstructionObjects
{
    public partial class FormBrigadesEdit : Form
    {
        Brigade current;
        List<Employee> allEmployees;
        List<Composition_brigade> compositions;
        List<Composition_brigade> newCompositions = new List<Composition_brigade>();
        public FormBrigadesEdit()
        {
            InitializeComponent();
        }

        private void FormBrigadesEdit_Load(object sender, EventArgs e)
        {
            FormBrigades form = Owner as FormBrigades;
            var objects = APIHelper.GET<List<Models.Object>>("Objects").Where(c => !c.Deleted).ToList();
            allEmployees = APIHelper.GET<List<Employee>>("Employees");
            compositions = APIHelper.GET<List<Composition_brigade>>("Composition_brigade");
            RefreshEmployeesAll();
            objectsBox.DataSource = objects;
            objectsBox.DisplayMember = "ID_Object";
            objectsBox.ValueMember = "ID_Object";
            
            if (form.edit)
            {
                current = APIHelper.GET<Brigade>($"Brigades/{form.brigadesGrid.SelectedRows[0].Cells[0].Value}");
                Text = $"Редактирование бригады \"{current.Name}\"";
                nameBox.Text = current.Name;
                objectsBox.SelectedValue = current.ID_Object;
                RefreshEmployeesBrigade(compositions, false);
            }
            else
            {
                Text = "Новая бригада";
                DataTable table = new DataTable();
                table.Columns.Add("ID", typeof(int));
                table.Columns.Add("ФИО", typeof(string));
                brigadeEmployeesGrid.DataSource = table;
                brigadeEmployeesGrid.Columns[0].Visible = false;
            }
        }

        private void RefreshEmployeesAll()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("ФИО", typeof(string));
            foreach(Employee emp in allEmployees)
            {
                if (!emp.Deleted && compositions.Where(c => c.ID_Employee == emp.ID_Employee).Count() == 0) table.Rows.Add(emp.ID_Employee, $"{emp.Surname} {emp.Name} {emp.Middlename}");
            }
            allEmployeesGrid.DataSource = table;
            allEmployeesGrid.Columns[0].Visible = false;
        }

        private void RefreshEmployeesBrigade(List<Composition_brigade> compositions, bool isNew)
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("ФИО", typeof(string));
            foreach (Employee emp in allEmployees)
            {
                if (!emp.Deleted && compositions.Where(c => c.ID_Employee == emp.ID_Employee && c.ID_Brigade == (isNew ? -1 : current.ID_Brigade)).Count() != 0) table.Rows.Add(emp.ID_Employee, $"{emp.Surname} {emp.Name} {emp.Middlename}");
            }
            brigadeEmployeesGrid.DataSource = table;
            brigadeEmployeesGrid.Columns[0].Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameBox.Text) && objectsBox.SelectedValue != null)
            {
                FormBrigades form = Owner as FormBrigades;
                Brigade newBrigade = new Brigade(nameBox.Text, Convert.ToInt32(objectsBox.SelectedValue));
                if (form.edit)
                {
                    newBrigade.ID_Brigade = Convert.ToInt32(form.brigadesGrid.SelectedRows[0].Cells[0].Value);
                    APIHelper.PUT("Brigades", newBrigade, newBrigade.ID_Brigade);
                    form.RefreshGrid();
                    Close();
                }
                else
                {
                    var addedBrigade = APIHelper.POST("Brigades", newBrigade);
                    foreach(Composition_brigade comp in newCompositions)
                    {
                        comp.ID_Brigade = addedBrigade.ID_Brigade;
                        APIHelper.POST("Composition_brigade", comp);
                    }
                    form.RefreshGrid();
                    Close();
                }
            }
            else MessageBox.Show("Заполните все поля");
        }

        private void addEmployeeButton_Click(object sender, EventArgs e)
        {
            if (allEmployeesGrid.SelectedRows.Count != 0)
            {
                FormBrigades form = Owner as FormBrigades;
                if (form.edit)
                {
                    var newComposition = new Composition_brigade(Convert.ToInt32(allEmployeesGrid.SelectedRows[0].Cells[0].Value.ToString()), current.ID_Brigade);
                    APIHelper.POST("Composition_brigade", newComposition);
                    compositions = APIHelper.GET<List<Composition_brigade>>("Composition_brigade");
                    RefreshEmployeesAll();
                    RefreshEmployeesBrigade(compositions, false);
                }
                else 
                {
                    var newComposition = new Composition_brigade(Convert.ToInt32(allEmployeesGrid.SelectedRows[0].Cells[0].Value.ToString()), -1);
                    compositions.Add(newComposition);
                    newCompositions.Add(newComposition);
                    RefreshEmployeesAll();
                    RefreshEmployeesBrigade(newCompositions, true);
                }
            }
        }

        private void removeEmployeeButton_Click(object sender, EventArgs e)
        {
            if (brigadeEmployeesGrid.SelectedRows.Count != 0)
            {
                FormBrigades form = Owner as FormBrigades;
                if (form.edit)
                {
                    var compositionToDelete = compositions.Where(c => c.ID_Brigade == current.ID_Brigade && c.ID_Employee == Convert.ToInt32(brigadeEmployeesGrid.SelectedRows[0].Cells[0].Value.ToString())).FirstOrDefault();
                    APIHelper.DELETE("Composition_brigade", compositionToDelete, compositionToDelete.ID_Composition_brigade);
                    compositions.Remove(compositionToDelete);
                    RefreshEmployeesAll();
                    RefreshEmployeesBrigade(compositions, false);
                }
                else
                {
                    var compositionToDelete = new Composition_brigade(Convert.ToInt32(brigadeEmployeesGrid.SelectedRows[0].Cells[0].Value.ToString()), -1);
                    compositions.Remove(compositionToDelete);
                    newCompositions.Remove(compositionToDelete);
                    RefreshEmployeesAll();
                    RefreshEmployeesBrigade(newCompositions, true);
                }
            }
        }
    }
}

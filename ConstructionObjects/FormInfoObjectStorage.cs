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
    public partial class FormInfoObjectStorage : Form
    {
        Models.Object current;
        List<Materials_Objects> compositionsMaterials;
        List<Technics_Objects> compositionsTechnics;
        List<Technics> technics;
        List<Materials> materials;
        

        public FormInfoObjectStorage()
        {
            InitializeComponent();
        }

        private void FormInfoObjectBrigadir_Load(object sender, EventArgs e)
        {
            FormObjectsStorage form = Owner as FormObjectsStorage;
            current = APIHelper.GET<Models.Object>($"Objects/{form.objectsGrid.SelectedRows[0].Cells[0].Value}");
            Text = $"Снабжение объекта №{current.ID_Object}";
            numberLabel.Text = $"Объект №{current.ID_Object}";
            floorsLabel.Text = "Этажность:" + current.Flats.ToString();
            areaLabel.Text = "Площадь:" + current.Area.ToString();
            startDateLabel.Text = "Начало строительства: " + current.Start_date.ToString("dd.MM.yyyy");
            endDateLabel.Text = "Окончание строительства: " + current.End_date.ToString("dd.MM.yyyy");
            permissionLabel.Text = "Разрешение на строительство: " + current.Building_permit;
            sectorLabel.Text = "Участок: " + APIHelper.GET<Sector>("Sectors/" + current.ID_Sector.ToString()).Address;
            typeLabel.Text = "Тип объекта: " + APIHelper.GET<Type_object>("Type_object/" + current.ID_Type_object.ToString()).Name;
            var face = APIHelper.GET<Employee>("Employees/" + current.ID_Employee.ToString());
            faceLabel.Text = "Ответственное лицо: " + $"{face.Surname} {face.Name} {face.Middlename}";
            numberBuildingLabel.Text = "Номер владения: " + current.Number_building.ToString();

            technics = APIHelper.GET<List<Technics>>("Technics");
            compositionsTechnics = APIHelper.GET<List<Technics_Objects>>("Technics_Objects");
            RefreshTechnicsAll();
            RefreshTechnicsObject();

            materials = APIHelper.GET<List<Materials>>("Materials");
            compositionsMaterials = APIHelper.GET<List<Materials_Objects>>("Materials_Objects");
            RefreshMaterialsAll();
            RefreshMaterialsObject();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void RefreshMaterialsAll()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Имя", typeof(string));
            table.Columns.Add("Количество", typeof(int));
            foreach (Materials mat in materials)
            {
                if (!mat.Deleted && mat.Amount != 0) table.Rows.Add(mat.ID_Materials, mat.Name, mat.Amount);
            }
            resAllGrid.DataSource = table;
            resAllGrid.Columns[0].Visible = false;
        }

        private void RefreshMaterialsObject()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Имя", typeof(string));
            table.Columns.Add("Количество", typeof(int));
            foreach (Materials mat in materials)
            {
                if (compositionsMaterials.Where(c => c.ID_Materials == mat.ID_Materials && c.ID_Object == current.ID_Object).Count() != 0) table.Rows.Add(mat.ID_Materials, mat.Name, compositionsMaterials.Where(c => c.ID_Materials == mat.ID_Materials && c.ID_Object == current.ID_Object).FirstOrDefault().Amount);
            }
            resObjectGrid.DataSource = table;
            resObjectGrid.Columns[0].Visible = false;
        }

        private void RefreshTechnicsAll()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Имя", typeof(string));
            foreach (Technics tech in technics)
            {
                if (!tech.Deleted && compositionsTechnics.Where(c => c.ID_Technics == tech.ID_Technics).Count() == 0) table.Rows.Add(tech.ID_Technics, tech.Name);
            }
            technicsAllGrid.DataSource = table;
            technicsAllGrid.Columns[0].Visible = false;
        }

        private void RefreshTechnicsObject()
        {
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Имя", typeof(string));
            foreach (Technics tech in technics)
            {
                if (!tech.Deleted && compositionsTechnics.Where(c => c.ID_Technics == tech.ID_Technics && c.ID_Object == current.ID_Object).Count() != 0) table.Rows.Add(tech.ID_Technics, tech.Name);
            }
            technicsObjectGrid.DataSource = table;
            technicsObjectGrid.Columns[0].Visible = false;
        }

        private void addTechnicsButton_Click(object sender, EventArgs e)
        {
            if (technicsAllGrid.SelectedRows.Count != 0)
            {
                var newComposition = new Technics_Objects(current.ID_Object, Convert.ToInt32(technicsAllGrid.SelectedRows[0].Cells[0].Value.ToString()));
                APIHelper.POST("Technics_Objects", newComposition);
                compositionsTechnics = APIHelper.GET<List<Technics_Objects>>("Technics_Objects");
                RefreshTechnicsAll();
                RefreshTechnicsObject();
            }
        }

        private void removeTechnicsButton_Click(object sender, EventArgs e)
        {
            if (technicsObjectGrid.SelectedRows.Count != 0)
            {
                var compositionToDelete = compositionsTechnics.Where(c => c.ID_Object == current.ID_Object && c.ID_Technics == Convert.ToInt32(technicsObjectGrid.SelectedRows[0].Cells[0].Value.ToString())).FirstOrDefault();
                APIHelper.DELETE("Technics_Objects", compositionToDelete, compositionToDelete.ID_Technics_Objects);
                compositionsTechnics.Remove(compositionToDelete);
                RefreshTechnicsAll();
                RefreshTechnicsObject();
            }
        }

        private void addResButton_Click(object sender, EventArgs e)
        {
            if (resAllGrid.SelectedRows.Count != 0)
            {
                var material = new Materials(resAllGrid.SelectedRows[0].Cells[1].Value.ToString(), Convert.ToInt32(resAllGrid.SelectedRows[0].Cells[2].Value.ToString()));
                material.ID_Materials = Convert.ToInt32(resAllGrid.SelectedRows[0].Cells[0].Value.ToString());
                int amount = material.Amount >= Convert.ToInt32(countResBox.Value.ToString()) ? Convert.ToInt32(countResBox.Value.ToString()) : material.Amount;
                if (compositionsMaterials.Where(c => c.ID_Materials == material.ID_Materials && c.ID_Object == current.ID_Object).Count() != 0)
                {
                    var compositionExist = compositionsMaterials.Where(c => c.ID_Materials == material.ID_Materials && c.ID_Object == current.ID_Object).First();
                    compositionExist.Amount += amount;
                    APIHelper.PUT("Materials_Objects", compositionExist, compositionExist.ID_Materials_Objects);
                }
                else
                {
                    var newComposition = new Materials_Objects(amount, current.ID_Object, material.ID_Materials);
                    APIHelper.POST("Materials_Objects", newComposition);
                }
                material.Amount -= amount;
                APIHelper.PUT("Materials", material, material.ID_Materials);
                compositionsMaterials = APIHelper.GET<List<Materials_Objects>>("Materials_Objects");
                materials = APIHelper.GET<List<Materials>>("Materials");
                RefreshMaterialsAll();
                RefreshMaterialsObject();
            }
        }

        private void removeResButton_Click(object sender, EventArgs e)
        {
            if (resAllGrid.SelectedRows.Count != 0)
            {
                var compositionToDelete = compositionsMaterials.Where(c => c.ID_Object == current.ID_Object && c.ID_Materials == Convert.ToInt32(resObjectGrid.SelectedRows[0].Cells[0].Value.ToString())).FirstOrDefault();
                int amount = 0;
                if (Convert.ToInt32(countResBox.Value.ToString()) < compositionToDelete.Amount)
                {
                    amount = Convert.ToInt32(countResBox.Value.ToString());
                    compositionToDelete.Amount -= amount;
                    APIHelper.PUT("Materials_Objects", compositionToDelete, compositionToDelete.ID_Materials_Objects);
                }
                else
                {
                    amount = compositionToDelete.Amount;
                    APIHelper.DELETE("Materials_Objects", compositionToDelete, compositionToDelete.ID_Materials_Objects);
                }
                var changedMaterial = APIHelper.GET<Materials>($"Materials/{resObjectGrid.SelectedRows[0].Cells[0].Value}");
                changedMaterial.Amount += amount;
                APIHelper.PUT("Materials", changedMaterial, changedMaterial.ID_Materials);
                compositionsMaterials = APIHelper.GET<List<Materials_Objects>>("Materials_Objects");
                materials = APIHelper.GET<List<Materials>>("Materials");
                RefreshMaterialsAll();
                RefreshMaterialsObject();
            }
        }
    }
}

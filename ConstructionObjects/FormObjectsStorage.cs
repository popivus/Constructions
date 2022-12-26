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
    public partial class FormObjectsStorage : Form
    {
        public FormObjectsStorage()
        {
            InitializeComponent();
        }

        private void FormObjectsStorage_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            objectsGrid.ContextMenuStrip = contextMenuStrip1;
        }

        public void RefreshGrid()
        {
            SearchGrid("");
        }

        private void SearchGrid(string search)
        {
            var objects = APIHelper.GET<List<Models.Object>>(search == "" ? "Objects" : $"Objects/search/{search}");
            var employees = APIHelper.GET<List<Employee>>("Employees");
            var sectors = APIHelper.GET<List<Sector>>("Sectors");
            var typesObject = APIHelper.GET<List<Type_object>>("Type_object");
            DataTable table = new DataTable();
            table.Columns.Add("Номер объекта", typeof(int));
            table.Columns.Add("Тип объекта", typeof(string));
            table.Columns.Add("Площадь", typeof(double));
            table.Columns.Add("Этажность", typeof(int));
            table.Columns.Add("Дата начала строительства", typeof(DateTime));
            table.Columns.Add("Дата окончания строительства", typeof(DateTime));
            table.Columns.Add("Разрешение на строительство", typeof(string));
            table.Columns.Add("Номер владения", typeof(int));
            table.Columns.Add("Участок", typeof(string));
            table.Columns.Add("Ответственное лицо", typeof(string));
            foreach (Models.Object obj in objects)
            {
                if (!obj.Deleted) table.Rows.Add(obj.ID_Object, typesObject.Where(c => c.ID_Type_object == obj.ID_Type_object).FirstOrDefault().Name, obj.Area, obj.Flats, obj.Start_date, obj.End_date, obj.Building_permit, obj.Number_building, sectors.Where(s => s.ID_Sector == obj.ID_Sector).FirstOrDefault().Address, employees.Where(c => c.ID_Employee == obj.ID_Employee).FirstOrDefault().Surname);
            }
            objectsGrid.DataSource = table;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(searchBox.Text)) RefreshGrid();
                else SearchGrid(searchBox.Text);
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text)) RefreshGrid();
            else SearchGrid(searchBox.Text);
        }

        private void objectsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FormInfoObjectStorage form = new FormInfoObjectStorage();
            form.Owner = this;
            form.ShowDialog();
        }

        private void openMenuItem_Click(object sender, EventArgs e)
        {
            if (objectsGrid.SelectedRows.Count != 0)
            {
                FormInfoObjectStorage form = new FormInfoObjectStorage();
                form.Owner = this;
                form.ShowDialog();
            }
        }
    }
}

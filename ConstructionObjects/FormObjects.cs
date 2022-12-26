using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ConstructionsObjects.Models;
using ConstructionObjects.Models;

namespace ConstructionObjects
{
    public partial class FormObjects : Form
    {
        public bool edit;
        public FormObjects()
        {
            InitializeComponent();
        }

        private void FormObjects_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            ToolStripMenuItem addMenuItem = new ToolStripMenuItem("Создать");
            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Редактировать");
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");
            contextMenuStrip1.Items.AddRange(new[] { addMenuItem, editMenuItem, deleteMenuItem });
            objectsGrid.ContextMenuStrip = contextMenuStrip1;
            addMenuItem.Click += addButton_Click;
            editMenuItem.Click += editMenuItem_Click;
            deleteMenuItem.Click += deleteButton_Click;
        }

        private void editMenuItem_Click(object sender, EventArgs e)
        {
            AddOrEdit(false);
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
            table.Columns.Add("Удалён", typeof(bool));
            foreach (Models.Object obj in objects)
            {
                table.Rows.Add(obj.ID_Object, typesObject.Where(c => c.ID_Type_object == obj.ID_Type_object).FirstOrDefault().Name, obj.Area, obj.Flats, obj.Start_date, obj.End_date, obj.Building_permit, obj.Number_building, sectors.Where(s => s.ID_Sector == obj.ID_Sector).FirstOrDefault().Address, employees.Where(c => c.ID_Employee == obj.ID_Employee).FirstOrDefault().Surname, obj.Deleted);
            }
            objectsGrid.DataSource = table;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text)) RefreshGrid();
            else SearchGrid(searchBox.Text);
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(searchBox.Text)) RefreshGrid();
                else SearchGrid(searchBox.Text);
            }
        }

        private void objectsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddOrEdit(false);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (objectsGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Models.Object>($"Objects/{objectsGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = true;
                APIHelper.DELETE("Objects", current, current.ID_Object);
                RefreshGrid();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddOrEdit(true);
        }

        private void AddOrEdit(bool isAdd)
        {
            edit = !isAdd;
            FormInfoObject form = new FormInfoObject();
            form.Owner = this;
            form.ShowDialog();
        }

        private void logDeleteButton_Click(object sender, EventArgs e)
        {
            if (objectsGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Models.Object>($"Objects/{objectsGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = true;
                APIHelper.PUT("Objects", current, current.ID_Object);
                RefreshGrid();
            }
        }

        private void recoverButton_Click(object sender, EventArgs e)
        {
            if (objectsGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Models.Object>($"Objects/{objectsGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = false;
                APIHelper.PUT("Objects", current, current.ID_Object);
                RefreshGrid();
            }
        }
    }
}

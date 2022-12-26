using ConstructionsObjects.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ConstructionObjects
{
    public partial class FormEmployees : Form
    {
        public bool edit;
        public FormEmployees()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormEmployees_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            ToolStripMenuItem addMenuItem = new ToolStripMenuItem("Создать");
            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Редактировать");
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");
            contextMenuStrip1.Items.AddRange(new[] { addMenuItem, editMenuItem, deleteMenuItem });
            employeeGrid.ContextMenuStrip = contextMenuStrip1;
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
            var employees = APIHelper.GET<List<Employee>>(search == "" ? "Employees" : $"Employees/search/{search}");
            var positions = APIHelper.GET<List<Position>>("Positions");
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("ФИО", typeof(string));
            table.Columns.Add("Должность", typeof(string));
            table.Columns.Add("Паспорт", typeof(string));
            table.Columns.Add("СНИЛС", typeof(string));
            table.Columns.Add("ИНН", typeof(string));
            table.Columns.Add("Дата рождения", typeof(DateTime));
            table.Columns.Add("Уволен", typeof(bool));
            table.Columns.Add("Удалён", typeof(bool));
            foreach (Employee employee in employees)
            {
                if (!employee.Deleted) table.Rows.Add(employee.ID_Employee, $"{employee.Surname} {employee.Name} {employee.Middlename}", positions.Where(p => p.ID_Position == employee.ID_Position).FirstOrDefault().Name, $"{employee.Seria_passport} {employee.Number_passport}", employee.SNILS, employee.INN, employee.Birthday, employee.Fired, employee.Deleted);
            }
            employeeGrid.DataSource = table;
            employeeGrid.Columns[0].Visible = false;
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

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (employeeGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Employee>($"Employees/{employeeGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = true;
                APIHelper.DELETE("Employees", current, current.ID_Employee);
                RefreshGrid();
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddOrEdit(true);
        }

        private void employeeGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddOrEdit(false);
        }

        private void AddOrEdit(bool isAdd)
        {
            edit = !isAdd;
            FormEmployeesEdit form = new FormEmployeesEdit();
            form.Owner = this;
            form.ShowDialog();
        }

        private void logDeleteButton_Click(object sender, EventArgs e)
        {
            if (employeeGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Employee>($"Employees/{employeeGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = true;
                APIHelper.PUT("Employees", current, current.ID_Employee);
                RefreshGrid();
            }
        }

        private void recoverButton_Click(object sender, EventArgs e)
        {
            if (employeeGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Employee>($"Employees/{employeeGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = false;
                APIHelper.PUT("Employees", current, current.ID_Employee);
                RefreshGrid();
            }
        }
    }
}

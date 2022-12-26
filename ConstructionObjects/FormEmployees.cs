using ConstructionsObjects.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;

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
            foreach (Employee employee in employees)
            {
                if (!employee.Deleted) table.Rows.Add(employee.ID_Employee, $"{employee.Surname} {employee.Name} {employee.Middlename}", positions.Where(p => p.ID_Position == employee.ID_Position).FirstOrDefault().Name, $"{employee.Seria_passport} {employee.Number_passport}", employee.SNILS, employee.INN, employee.Birthday, employee.Fired);
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
                APIHelper.PUT("Employees", current, current.ID_Employee);
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

        private void excelExportButton_Click(object sender, EventArgs e)
        {
            Excel.Application oXL;
            Excel._Workbook oWB;
            Excel._Worksheet oSheet;
            Excel.Range oRng;
            var employeesList = APIHelper.GET<List<Employee>>("Employees");
            var positionsList = APIHelper.GET<List<Position>>("Positions");
            try
            {
                oXL = new Excel.Application();
                oXL.Visible = true;

                oWB = (Excel._Workbook)(oXL.Workbooks.Add(Missing.Value));
                oSheet = (Excel._Worksheet)oWB.ActiveSheet;

                oSheet.Cells[1, 1] = "Фамилия";
                oSheet.Cells[1, 2] = "Имя";
                oSheet.Cells[1, 3] = "Отчество";
                oSheet.Cells[1, 4] = "Должность";
                oSheet.Cells[1, 5] = "Серия паспорта";
                oSheet.Cells[1, 6] = "Номер паспорта";
                oSheet.Cells[1, 7] = "СНИЛС";
                oSheet.Cells[1, 8] = "ИНН";
                oSheet.Cells[1, 9] = "Дата рождения";

                oSheet.get_Range("A1", "I1").Font.Bold = true;
                oSheet.get_Range("A1", "I1").VerticalAlignment = Excel.XlVAlign.xlVAlignCenter;

                string[,] surnames = new string[employeesList.Count, 2];
                string[,] names = new string[employeesList.Count, 2];
                string[,] middlenames = new string[employeesList.Count, 2];
                string[,] positions = new string[employeesList.Count, 2];
                string[,] serias = new string[employeesList.Count, 2];
                string[,] numbers = new string[employeesList.Count, 2];
                string[,] SNILSs = new string[employeesList.Count, 2];
                string[,] INNs = new string[employeesList.Count, 2];
                string[,] birthdates = new string[employeesList.Count, 2];

                for(int i = 0; i < employeesList.Count; i++)
                {
                    if (!employeesList[i].Deleted && !employeesList[i].Fired)
                    {
                        surnames[i, 0] = employeesList[i].Surname;
                        names[i, 0] = employeesList[i].Name;
                        middlenames[i, 0] = employeesList[i].Middlename;
                        positions[i, 0] = positionsList.Where(p => p.ID_Position == employeesList[i].ID_Position).FirstOrDefault().Name;
                        serias[i, 0] = employeesList[i].Seria_passport;
                        numbers[i, 0] = employeesList[i].Number_passport;
                        SNILSs[i, 0] = employeesList[i].SNILS;
                        INNs[i, 0] = employeesList[i].INN;
                        birthdates[i, 0] = employeesList[i].Birthday.ToString("dd.MM.yyyy");
                    }
                }

                oSheet.get_Range("A2", $"A{employeesList.Count + 1}").Value2 = surnames;
                oSheet.get_Range("B2", $"B{employeesList.Count + 1}").Value2 = names;
                oSheet.get_Range("C2", $"C{employeesList.Count + 1}").Value2 = middlenames;
                oSheet.get_Range("D2", $"D{employeesList.Count + 1}").Value2 = positions;
                oSheet.get_Range("E2", $"E{employeesList.Count + 1}").Value2 = serias;
                oSheet.get_Range("F2", $"F{employeesList.Count + 1}").Value2 = numbers;
                oSheet.get_Range("G2", $"G{employeesList.Count + 1}").Value2 = SNILSs;
                oSheet.get_Range("H2", $"H{employeesList.Count + 1}").Value2 = INNs;
                oSheet.get_Range("I2", $"I{employeesList.Count + 1}").Value2 = birthdates;

                oSheet.get_Range("A1", $"I{employeesList.Count + 1}").Borders.Weight = Excel.XlBorderWeight.xlThin;
                oSheet.get_Range("A1", "I1").Borders.Weight = Excel.XlBorderWeight.xlThick;
                oRng = oSheet.get_Range("A1", "I1");
                oRng.EntireColumn.AutoFit();
                oXL.Visible = true;
                oXL.UserControl = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка");
            }
        }

        private void analysisButton_Click(object sender, EventArgs e)
        {
            FormAnalysis form = new FormAnalysis();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}

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
    public partial class FormSales : Form
    {
        public bool edit = false;

        public FormSales()
        {
            InitializeComponent();
        }

        private void FormSales_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            ToolStripMenuItem addMenuItem = new ToolStripMenuItem("Создать");
            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Редактировать");
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");
            contextMenuStrip1.Items.AddRange(new[] { addMenuItem, editMenuItem, deleteMenuItem });
            salesGrid.ContextMenuStrip = contextMenuStrip1;
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
            var salesContracts = APIHelper.GET<List<Sales_contract>>(search == "" ? "Sales_contract" : $"Sales_contract/search/{search}");
            var counterparties = APIHelper.GET<List<Counterparty>>("Counterparties").Where(c => !c.Deleted).ToList();
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Номер", typeof(string));
            table.Columns.Add("Сумма (руб.)", typeof(double));
            table.Columns.Add("Дата заключения", typeof(DateTime));
            table.Columns.Add("Заказчик", typeof(string));
            table.Columns.Add("Удалён", typeof(bool));
            foreach (Sales_contract contract in salesContracts)
            {
                table.Rows.Add(contract.ID_Sales_contract, contract.Number, contract.Sum, contract.Contract_date, counterparties.Where(c => c.ID_Counterparty == contract.ID_Counterparty).FirstOrDefault().Name, contract.Deleted);
            }
            salesGrid.DataSource = table;
            salesGrid.Columns[0].Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (salesGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Sales_contract>($"Sales_contract/{salesGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = true;
                APIHelper.DELETE("Sales_contract", current, current.ID_Sales_contract);
                RefreshGrid();
            }
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

        private void addButton_Click(object sender, EventArgs e)
        {
            AddOrEdit(true);
        }

        private void salesGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddOrEdit(false);
        }

        private void AddOrEdit(bool isAdd)
        {
            edit = !isAdd;
            FormSalesEdit form = new FormSalesEdit();
            form.Owner = this;
            form.ShowDialog();
        }

        private void logDeleteButton_Click(object sender, EventArgs e)
        {
            if (salesGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Sales_contract>($"Sales_contract/{salesGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = true;
                APIHelper.PUT("Sales_contract", current, current.ID_Sales_contract);
                RefreshGrid();
            }
        }

        private void recoverButton_Click(object sender, EventArgs e)
        {
            if (salesGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Sales_contract>($"Sales_contract/{salesGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = false;
                APIHelper.PUT("Sales_contract", current, current.ID_Sales_contract);
                RefreshGrid();
            }
        }
    }
}

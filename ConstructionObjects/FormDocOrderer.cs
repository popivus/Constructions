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
    public partial class FormDocOrderer : Form
    {
        public bool edit = false;
        public FormDocOrderer()
        {
            InitializeComponent();
        }

        private void FormDocOrderer_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            ToolStripMenuItem addMenuItem = new ToolStripMenuItem("Создать");
            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Редактировать");
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");
            contextMenuStrip1.Items.AddRange(new[] { addMenuItem, editMenuItem, deleteMenuItem });
            docTechGrid.ContextMenuStrip = contextMenuStrip1;
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
            var equipmentOrderAgreements = APIHelper.GET<List<Equipment_order_agreement>>(search == "" ? "Equipment_order_agreement" : $"Equipment_order_agreement/search/{search}");
            var technics = APIHelper.GET<List<Technics>>("Technics");
            var counterparties = APIHelper.GET<List<Counterparty>>("Counterparties");
            DataTable table = new DataTable();
            table.Columns.Add("Номер", typeof(int));
            table.Columns.Add("Сумма (руб.)", typeof(double));
            table.Columns.Add("Техника", typeof(string));
            table.Columns.Add("Поставщик", typeof(string));
            table.Columns.Add("Удалён", typeof(bool));
            foreach (Equipment_order_agreement order in equipmentOrderAgreements)
            {
                table.Rows.Add(order.ID_Equipment_order_agreement, order.Sum, technics.Where(t => t.ID_Technics == order.ID_Technics).FirstOrDefault().Name, counterparties.Where(t => t.ID_Counterparty == order.ID_Counterparty).FirstOrDefault().Name, order.Deleted);
            }
            docTechGrid.DataSource = table;
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

        private void addButton_Click(object sender, EventArgs e)
        {
            AddOrEdit(true);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (docTechGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Equipment_order_agreement>($"Equipment_order_agreement/{docTechGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = true;
                APIHelper.DELETE("Equipment_order_agreement", current, current.ID_Equipment_order_agreement);
                RefreshGrid();
            }
        }

        private void docTechGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddOrEdit(false);
        }

        private void AddOrEdit(bool isAdd)
        {
            edit = !isAdd;
            FormDocTechnics form = new FormDocTechnics();
            form.Owner = this;
            form.ShowDialog();
        }

        private void logDeleteButton_Click(object sender, EventArgs e)
        {
            if (docTechGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Equipment_order_agreement>($"Equipment_order_agreement/{docTechGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = true;
                APIHelper.PUT("Equipment_order_agreement", current, current.ID_Equipment_order_agreement);
                RefreshGrid();
            }
        }

        private void recoverButton_Click(object sender, EventArgs e)
        {
            if (docTechGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Equipment_order_agreement>($"Equipment_order_agreement/{docTechGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = false;
                APIHelper.PUT("Equipment_order_agreement", current, current.ID_Equipment_order_agreement);
                RefreshGrid();
            }
        }
    }
}

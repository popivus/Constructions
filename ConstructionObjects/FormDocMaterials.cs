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
    public partial class FormDocMaterials : Form
    {
        public bool edit = false;
        public FormDocMaterials()
        {
            InitializeComponent();
        }

        private void FormDocEmployee_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            ToolStripMenuItem addMenuItem = new ToolStripMenuItem("Создать");
            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Редактировать");
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");
            contextMenuStrip1.Items.AddRange(new[] { addMenuItem, editMenuItem, deleteMenuItem });
            docMaterialsGrid.ContextMenuStrip = contextMenuStrip1;
            addMenuItem.Click += addButton_Click;
            editMenuItem.Click += editMenuItem_Click;
            deleteMenuItem.Click += deleteButton_Click;
        }

        private void editMenuItem_Click(object sender, EventArgs e)
        {
            AddOrEdit(false);
        }


        private void button6_Click(object sender, EventArgs e)
        {
            Close();
        }

        public void RefreshGrid()
        {
            SearchGrid("");
        }

        private void SearchGrid(string search)
        {
            var materialsOrderAgreements = APIHelper.GET<List<Materials_ordering_agreement>>(search == "" ? "Materials_ordering_agreement" : $"Materials_ordering_agreement/search/{search}");
            var materials = APIHelper.GET<List<Materials>>("Materials");
            var counterparties = APIHelper.GET<List<Counterparty>>("Counterparties");
            DataTable table = new DataTable();
            table.Columns.Add("Номер", typeof(int));
            table.Columns.Add("Сумма (руб.)", typeof(float));
            table.Columns.Add("Количество", typeof(int));
            table.Columns.Add("Материал", typeof(string));
            table.Columns.Add("Поставщик", typeof(string));
            foreach (Materials_ordering_agreement order in materialsOrderAgreements)
            {
                if (!order.Deleted) table.Rows.Add(order.ID_Materials_ordering_agreement, order.Sum, order.Amount, materials.Where(t => t.ID_Materials == order.ID_Materials).FirstOrDefault().Name, counterparties.Where(t => t.ID_Counterparty == order.ID_Counterparty).FirstOrDefault().Name);
            }
            docMaterialsGrid.DataSource = table;
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

        private void docMaterialsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddOrEdit(false);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddOrEdit(true);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (docMaterialsGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Materials_ordering_agreement>($"Materials_ordering_agreement/{docMaterialsGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = true;
                APIHelper.PUT("Materials_ordering_agreement", current, current.ID_Materials_ordering_agreement);
                RefreshGrid();
            }
        }

        private void AddOrEdit(bool isAdd)
        {
            edit = !isAdd;
            FormDocMaterialsEdit form = new FormDocMaterialsEdit();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}

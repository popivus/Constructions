using ConstructionsObjects.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConstructionObjects
{
    public partial class FormMaterials : Form
    {
        public bool edit;
        public FormMaterials()
        {
            InitializeComponent();
        }

        private void FormMaterials_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            ToolStripMenuItem addMenuItem = new ToolStripMenuItem("Создать");
            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Редактировать");
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");
            contextMenuStrip1.Items.AddRange(new[] { addMenuItem, editMenuItem, deleteMenuItem });
            materialsGrid.ContextMenuStrip = contextMenuStrip1;
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
            var materials = APIHelper.GET<List<Materials>>(search == "" ? "Materials" : $"Materials/search/{search}");
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Наименование", typeof(string));
            table.Columns.Add("Количество", typeof(int));
            foreach (Materials material in materials)
            {
                if (!material.Deleted) table.Rows.Add(material.ID_Materials, material.Name, material.Amount);
            }
            materialsGrid.DataSource = table;
            materialsGrid.Columns[0].Visible = false;
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
            if (materialsGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Materials>($"Materials/{materialsGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = true;
                APIHelper.PUT("Materials", current, current.ID_Materials);
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
            FormMaterialsEdit form = new FormMaterialsEdit();
            form.Owner = this;
            form.ShowDialog();
        }

        private void materialsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddOrEdit(false);
        }
    }
}

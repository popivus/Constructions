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
    public partial class FormBrigades : Form
    {
        public bool edit;
        public FormBrigades()
        {
            InitializeComponent();
        }

        private void FormBrigades_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            ToolStripMenuItem addMenuItem = new ToolStripMenuItem("Создать");
            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Редактировать");
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");
            contextMenuStrip1.Items.AddRange(new[] { addMenuItem, editMenuItem, deleteMenuItem });
            brigadesGrid.ContextMenuStrip = contextMenuStrip1;
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
            var brigades = APIHelper.GET<List<Brigade>>(search == "" ? "Brigades" : $"Brigades/search/{search}");
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Наименование", typeof(string));
            table.Columns.Add("Объект", typeof(string));
            table.Columns.Add("Удалён", typeof(bool));
            foreach (Brigade brigade in brigades)
            {
                table.Rows.Add(brigade.ID_Brigade, brigade.Name, $"Объект №{brigade.ID_Object}", brigade.Deleted);
            }
            brigadesGrid.DataSource = table;
            brigadesGrid.Columns[0].Visible = false;
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddOrEdit(true);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (brigadesGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Brigade>($"Brigades/{brigadesGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = true;
                APIHelper.PUT("Brigades", current, current.ID_Brigade);
                var compositions = APIHelper.GET<List<Composition_brigade>>("Composition_brigade");
                foreach (Composition_brigade comp in compositions)
                {
                    if (comp.ID_Brigade == current.ID_Brigade) APIHelper.DELETE("Composition_brigade", comp, comp.ID_Composition_brigade);
                }
                APIHelper.DELETE("Brigades", current, current.ID_Brigade);
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

        private void brigadesGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddOrEdit(false);
        }

        private void AddOrEdit(bool isAdd)
        {
            edit = !isAdd;
            FormBrigadesEdit form = new FormBrigadesEdit();
            form.Owner = this;
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (brigadesGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Brigade>($"Brigades/{brigadesGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = true;
                APIHelper.PUT("Brigades", current, current.ID_Brigade);
                var compositions = APIHelper.GET<List<Composition_brigade>>("Composition_brigade");
                foreach (Composition_brigade comp in compositions)
                {
                    if (comp.ID_Brigade == current.ID_Brigade) APIHelper.DELETE("Composition_brigade", comp, comp.ID_Composition_brigade);
                }
                RefreshGrid();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (brigadesGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Brigade>($"Brigades/{brigadesGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = false;
                APIHelper.PUT("Brigades", current, current.ID_Brigade);
                var compositions = APIHelper.GET<List<Composition_brigade>>("Composition_brigade");
                foreach (Composition_brigade comp in compositions)
                {
                    if (comp.ID_Brigade == current.ID_Brigade) APIHelper.DELETE("Composition_brigade", comp, comp.ID_Composition_brigade);
                }
                RefreshGrid();
            }
        }
    }
}

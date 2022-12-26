using ConstructionsObjects.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConstructionObjects
{
    public partial class FormTechnics : Form
    {
        public bool edit = false;
        public FormTechnics()
        {
            InitializeComponent();
        }

        private void FormMyBrigade_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            ToolStripMenuItem addMenuItem = new ToolStripMenuItem("Создать");
            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Редактировать");
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");
            contextMenuStrip1.Items.AddRange(new[] { addMenuItem, editMenuItem, deleteMenuItem });
            technicsGrid.ContextMenuStrip = contextMenuStrip1;
            addMenuItem.Click += addButton_Click;
            editMenuItem.Click += editMenuItem_Click;
            deleteMenuItem.Click += deleteButton_Click;
        }

        private void editMenuItem_Click(object sender, EventArgs e)
        {
            AddOrEdit(false);
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text)) RefreshGrid();
            else SearchGrid(searchBox.Text);
        }

        public void RefreshGrid()
        {
            SearchGrid("");
        }

        private void SearchGrid(string search)
        {
            var technics = APIHelper.GET<List<Technics>>(search == "" ? "Technics" : $"Technics/search/{search}");
            var types = APIHelper.GET<List<Type_technics>>("Type_technics");
            var countries = APIHelper.GET<List<Country>>("Countries");
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Наименование", typeof(string));
            table.Columns.Add("Тип", typeof(string));
            table.Columns.Add("Страна производитель", typeof(string));
            table.Columns.Add("Удалён", typeof(bool));
            foreach (Technics tech in technics)
            {
                table.Rows.Add(tech.ID_Technics, tech.Name, types.Where(t => t.ID_Type_technics == tech.ID_Type_technics).FirstOrDefault().Name, countries.Where(t => t.ID_Country == tech.ID_Country).FirstOrDefault().Name, tech.Deleted);
            }
            technicsGrid.DataSource = table;
            technicsGrid.Columns[0].Visible = false;
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(searchBox.Text)) RefreshGrid();
                else SearchGrid(searchBox.Text);
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddOrEdit(true);
        }

        private void technicsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddOrEdit(false);
        }

        private void AddOrEdit(bool isAdd)
        {
            edit = !isAdd;
            FormTechnicsEdit form = new FormTechnicsEdit();
            form.Owner = this;
            form.ShowDialog();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (technicsGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Technics>($"Technics/{technicsGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = true;
                APIHelper.DELETE("Technics", current, current.ID_Technics);
                RefreshGrid();
            }
        }

        private void logDeleteButton_Click(object sender, EventArgs e)
        {
            if (technicsGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Technics>($"Technics/{technicsGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = true;
                APIHelper.PUT("Technics", current, current.ID_Technics);
                RefreshGrid();
            }
        }

        private void recoverButton_Click(object sender, EventArgs e)
        {
            if (technicsGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Technics>($"Technics/{technicsGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = false;
                APIHelper.PUT("Technics", current, current.ID_Technics);
                RefreshGrid();
            }
        }
    }
}

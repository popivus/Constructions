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
    public partial class FormSector : Form
    {
        public bool edit;
        public FormSector()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormSector_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            ToolStripMenuItem addMenuItem = new ToolStripMenuItem("Создать");
            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Редактировать");
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");
            contextMenuStrip1.Items.AddRange(new[] { addMenuItem, editMenuItem, deleteMenuItem });
            sectorsGrid.ContextMenuStrip = contextMenuStrip1;
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
            var sectors = APIHelper.GET<List<Sector>>(search == "" ? "Sectors" : $"Sectors/search/{search}");
            var counterparties = APIHelper.GET<List<Counterparty>>("Counterparties").Where(c => !c.Deleted).ToList();
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Площадь (м)", typeof(double));
            table.Columns.Add("Адрес", typeof(string));
            table.Columns.Add("Заказчик", typeof(string));
            foreach (Sector sector in sectors)
            {
                if (!sector.Deleted) table.Rows.Add(sector.ID_Sector, sector.Area, sector.Address, counterparties.Where(c => c.ID_Counterparty == sector.ID_Counterparty).FirstOrDefault().Name);
            }
            sectorsGrid.DataSource = table;
            sectorsGrid.Columns[0].Visible = false;
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

        private void salesGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddOrEdit(false);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (sectorsGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Sector>($"Sectors/{sectorsGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = true;
                APIHelper.PUT("Sectors", current, current.ID_Sector);
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
            FormSectorEdit form = new FormSectorEdit();
            form.Owner = this;
            form.ShowDialog();
        }
    }
}

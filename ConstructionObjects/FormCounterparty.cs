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
    public partial class FormCounterparty : Form
    {
        public bool edit;
        public FormCounterparty()
        {
            InitializeComponent();
        }

        private void FormCounterparty_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            ToolStripMenuItem addMenuItem = new ToolStripMenuItem("Создать");
            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Редактировать");
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");
            contextMenuStrip1.Items.AddRange(new[] { addMenuItem, editMenuItem, deleteMenuItem });
            counterpartiesGrid.ContextMenuStrip = contextMenuStrip1;
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
            var counterparties = APIHelper.GET<List<Counterparty>>(search == "" ? "Counterparties" : $"Counterparties/search/{search}");
            DataTable table = new DataTable();
            table.Columns.Add("ID", typeof(int));
            table.Columns.Add("Наименование", typeof(string));
            table.Columns.Add("ИНН", typeof(string));
            table.Columns.Add("Специализация", typeof(string));
            table.Columns.Add("Лицевой счёт", typeof(string));
            table.Columns.Add("Расчётный счёт", typeof(string));
            table.Columns.Add("Дата регистрации", typeof(DateTime));
            table.Columns.Add("Адрес", typeof(string));
            table.Columns.Add("Контактный номер", typeof(string));
            table.Columns.Add("ФИО представителя", typeof(string));
            foreach (Counterparty counterparty in counterparties)
            {
                if (!counterparty.Deleted) table.Rows.Add(counterparty.ID_Counterparty, counterparty.Name, counterparty.INN, counterparty.Specialization, counterparty.Personal_account, counterparty.Checking_account, counterparty.Registration_date, counterparty.Address, counterparty.Phone_number, counterparty.FIO_Responsible_person);
            }
            counterpartiesGrid.DataSource = table;
            counterpartiesGrid.Columns[0].Visible = false;
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            AddOrEdit(true);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (counterpartiesGrid.SelectedRows.Count != 0)
            {
                var current = APIHelper.GET<Counterparty>($"Counterparties/{counterpartiesGrid.SelectedRows[0].Cells[0].Value}");
                current.Deleted = true;
                APIHelper.PUT("Counterparties", current, current.ID_Counterparty);
                RefreshGrid();
            }
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

        private void AddOrEdit(bool isAdd)
        {
            edit = !isAdd;
            FormCounterpartyEdit form = new FormCounterpartyEdit();
            form.Owner = this;
            form.ShowDialog();
        }

        private void materialsGrid_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            AddOrEdit(false);
        }
    }
}

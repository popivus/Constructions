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
    public partial class FormTypesTechnics : Form
    {
        bool isType;
        public FormTypesTechnics()
        {
            InitializeComponent();
        }

        private void FormTypesTechnics_Load(object sender, EventArgs e)
        {
            FormTechnicsEdit form = Owner as FormTechnicsEdit;
            isType = form.isType;
            RefreshGrid();
            ToolStripMenuItem addMenuItem = new ToolStripMenuItem("Добавить");
            ToolStripMenuItem editMenuItem = new ToolStripMenuItem("Изменить");
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");
            contextMenuStrip1.Items.AddRange(new[] { addMenuItem, editMenuItem, deleteMenuItem });
            dataGrid.ContextMenuStrip = contextMenuStrip1;
            addMenuItem.Click += addButton_Click;
            editMenuItem.Click += button1_Click;
            deleteMenuItem.Click += deleteButton_Click;
        }

        private void RefreshGrid()
        {
            if (isType)
            {
                Text = "Типы техники";
                dataGrid.DataSource = APIHelper.GET<List<Type_technics>>("Type_technics");
            }
            else
            {
                Text = "Страны производители";
                dataGrid.DataSource = APIHelper.GET<List<Country>>("Countries");
            }
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[2].Visible = false;
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGrid.Rows[i].Cells[2].Value)) dataGrid.Rows[i].Visible = false;
            }
            FormTechnicsEdit form = Owner as FormTechnicsEdit;
            form.RefreshCombo();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameBox.Text))
            {
                if (isType) APIHelper.POST("Type_technics", new Type_technics(nameBox.Text));
                else APIHelper.POST("Countries", new Country(nameBox.Text));
                RefreshGrid();
            }
            else MessageBox.Show("Заполните поле");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count != 0)
            {
                if (!string.IsNullOrWhiteSpace(nameBox.Text))
                {
                    if (isType)
                    {
                        Type_technics editType = new Type_technics(nameBox.Text);
                        editType.ID_Type_technics = Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value);
                        APIHelper.PUT("Type_technics", editType, editType.ID_Type_technics);
                    }
                    else
                    {
                        Country editCountry = new Country(nameBox.Text);
                        editCountry.ID_Country = Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value);
                        APIHelper.PUT("Countries", editCountry, editCountry.ID_Country);
                    }
                    RefreshGrid();
                }
                else MessageBox.Show("Заполните поле");
            }
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nameBox.Text = dataGrid.SelectedRows[0].Cells[1].Value.ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count != 0)
            {
                if (!string.IsNullOrWhiteSpace(nameBox.Text))
                {
                    if (isType)
                    {
                        Type_technics editType = new Type_technics(dataGrid.SelectedRows[0].Cells[1].Value.ToString());
                        editType.ID_Type_technics = Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value);
                        editType.Deleted = true;
                        APIHelper.PUT("Type_technics", editType, editType.ID_Type_technics);
                    }
                    else
                    {
                        Country editCountry = new Country(dataGrid.SelectedRows[0].Cells[1].Value.ToString());
                        editCountry.ID_Country = Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value);
                        editCountry.Deleted = true;
                        APIHelper.PUT("Countries", editCountry, editCountry.ID_Country);
                    }
                    RefreshGrid();
                }
                else MessageBox.Show("Заполните поле");
            }
        }
    }
}

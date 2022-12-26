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
    public partial class FormTypesObject : Form
    {
        public FormTypesObject()
        {
            InitializeComponent();
        }

        private void FormTypesObject_Load(object sender, EventArgs e)
        {
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
            dataGrid.DataSource = APIHelper.GET<List<Type_object>>("Type_object");
            dataGrid.Columns[0].Visible = false;
            dataGrid.Columns[2].Visible = false;
            for (int i = 0; i < dataGrid.Rows.Count; i++)
            {
                if (Convert.ToBoolean(dataGrid.Rows[i].Cells[2].Value)) dataGrid.Rows[i].Visible = false;
            }
            FormInfoObject form = Owner as FormInfoObject;
            form.RefreshCombo();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameBox.Text))
            {
                APIHelper.POST("Type_object", new Type_object(nameBox.Text));
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
                    Type_object editType = new Type_object(nameBox.Text);
                    editType.ID_Type_object = Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value);
                    APIHelper.PUT("Type_object", editType, editType.ID_Type_object);
                    RefreshGrid();
                }
                else MessageBox.Show("Заполните поле");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count != 0)
            {
                if (!string.IsNullOrWhiteSpace(nameBox.Text))
                {
                    
                    Type_object editType = new Type_object(dataGrid.SelectedRows[0].Cells[1].Value.ToString());
                    editType.ID_Type_object = Convert.ToInt32(dataGrid.SelectedRows[0].Cells[0].Value);
                    editType.Deleted = true;
                    APIHelper.PUT("Type_object", editType, editType.ID_Type_object);
                    RefreshGrid();
                }
                else MessageBox.Show("Заполните поле");
            }
        }

        private void dataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            nameBox.Text = dataGrid.SelectedRows[0].Cells[1].Value.ToString();
        }
    }
}

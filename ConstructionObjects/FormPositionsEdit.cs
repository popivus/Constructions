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
    public partial class FormPositionsEdit : Form
    {
        public FormPositionsEdit()
        {
            InitializeComponent();
        }

        private void FormPositionsEdit_Load(object sender, EventArgs e)
        {
            FormPositions form = Owner as FormPositions;
            if (form.edit)
            {
                var current = form.positionsGrid.SelectedRows[0].Cells;
                Text = $"Редактирование \"{current[1].Value}\"";
                nameBox.Text = current[1].Value.ToString();
                salaryBox.Value = Convert.ToDecimal(current[2].Value.ToString());
            }
            else Text = "Новая должность";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameBox.Text))
            {
                FormPositions form = Owner as FormPositions;
                Position newPos = new Position(nameBox.Text, Convert.ToDouble(salaryBox.Value));
                if (form.edit)
                {
                    newPos.ID_Position = Convert.ToInt32(form.positionsGrid.SelectedRows[0].Cells[0].Value);
                    APIHelper.PUT("Positions", newPos, newPos.ID_Position);
                    form.RefreshGrid();
                    Close();
                }
                else
                {
                    APIHelper.POST("Positions", newPos);
                    form.RefreshGrid();
                    Close();
                }
            }
            else MessageBox.Show("Заполните все поля");
        }
    }
}

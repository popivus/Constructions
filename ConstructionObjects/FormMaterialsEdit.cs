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
    public partial class FormMaterialsEdit : Form
    {
        public FormMaterialsEdit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormMaterialsEdit_Load(object sender, EventArgs e)
        {
            FormMaterials form = Owner as FormMaterials;
            if (form.edit)
            {
                var current = form.materialsGrid.SelectedRows[0].Cells;
                Text = $"Редактирование \"{current[1].Value}\"";
                nameBox.Text = current[1].Value.ToString();
                amountBox.Value = Convert.ToDecimal(current[2].Value.ToString());
            }
            else Text = "Новый материал";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameBox.Text))
            {
                FormMaterials form = Owner as FormMaterials;
                Materials newMaterial = new Materials(nameBox.Text, Convert.ToInt32(amountBox.Value));
                if (form.edit)
                {
                    newMaterial.ID_Materials = Convert.ToInt32(form.materialsGrid.SelectedRows[0].Cells[0].Value);
                    APIHelper.PUT("Materials", newMaterial, newMaterial.ID_Materials);
                    form.RefreshGrid();
                    Close();
                }
                else
                {
                    APIHelper.POST("Materials", newMaterial);
                    form.RefreshGrid();
                    Close();
                }
            }
            else MessageBox.Show("Заполните все поля");
        }
    }
}

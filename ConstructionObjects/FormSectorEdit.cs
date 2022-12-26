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
    public partial class FormSectorEdit : Form
    {
        public FormSectorEdit()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(addressBox.Text) && counterpartyBox.SelectedValue != null)
            {
                FormSector form = Owner as FormSector;
                Sector newSector = new Sector(Convert.ToDouble(areaBox.Value), addressBox.Text, Convert.ToInt32(counterpartyBox.SelectedValue));
                if (form.edit)
                {
                    newSector.ID_Sector = Convert.ToInt32(form.sectorsGrid.SelectedRows[0].Cells[0].Value);
                    APIHelper.PUT("Sectors", newSector, newSector.ID_Sector);
                    form.RefreshGrid();
                    Close();
                }
                else
                {
                    APIHelper.POST("Sectors", newSector);
                    form.RefreshGrid();
                    Close();
                }
            }
            else MessageBox.Show("Заполните все поля");
        }

        private void FormSectorEdit_Load(object sender, EventArgs e)
        {
            FormSector form = Owner as FormSector;
            var counterparties = APIHelper.GET<List<Counterparty>>("Counterparties").Where(c => !c.Deleted).ToList();
            counterpartyBox.DataSource = counterparties;
            counterpartyBox.DisplayMember = "Name";
            counterpartyBox.ValueMember = "ID_Counterparty";
            if (form.edit)
            {
                var current = APIHelper.GET<Sector>($"Sectors/{form.sectorsGrid.SelectedRows[0].Cells[0].Value}");
                Text = $"Редактирование участка по адресу {current.Address}";
                addressBox.Text = current.Address;
                areaBox.Value = Convert.ToDecimal(current.Area);
                counterpartyBox.SelectedValue = current.ID_Counterparty;
            }
            else Text = "Новый участок";
        }
    }
}

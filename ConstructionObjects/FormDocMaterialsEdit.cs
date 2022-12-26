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
    public partial class FormDocMaterialsEdit : Form
    {
        public FormDocMaterialsEdit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDocMaterialsEdit_Load(object sender, EventArgs e)
        {
            FormDocMaterials form = Owner as FormDocMaterials;
            var materials = APIHelper.GET<List<Materials>>("Materials");
            var counterparties = APIHelper.GET<List<Counterparty>>("Counterparties");
            materialsBox.DataSource = materials.Where(m => !m.Deleted).ToList();
            materialsBox.DisplayMember = "Name";
            materialsBox.ValueMember = "ID_Materials";
            counterpartyBox.DataSource = counterparties.Where(c => !c.Deleted).ToList();
            counterpartyBox.DisplayMember = "Name";
            counterpartyBox.ValueMember = "ID_Counterparty";
            if (form.edit)
            {
                var current = APIHelper.GET<Materials_ordering_agreement>($"Materials_ordering_agreement/{form.docMaterialsGrid.SelectedRows[0].Cells[0].Value}");
                Text = $"Редактирование договора №{current.ID_Materials_ordering_agreement}";
                numberLabel.Text = current.ID_Materials_ordering_agreement.ToString();
                sumBox.Value = Convert.ToDecimal(current.Sum);
                amountBox.Value = Convert.ToDecimal(current.Amount);
                materialsBox.SelectedValue = current.ID_Materials;
                counterpartyBox.SelectedValue = current.ID_Counterparty;
            }
            else
            {
                var materialsOrderAgreements = APIHelper.GET<List<Materials_ordering_agreement>>("Materials_ordering_agreement");
                if (materialsOrderAgreements.Count != 0) numberLabel.Text = (materialsOrderAgreements[materialsOrderAgreements.Count - 1].ID_Materials_ordering_agreement + 1).ToString();
                else numberLabel.Text = "1";
                Text = "Новый договор";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (materialsBox.SelectedValue != null && counterpartyBox.SelectedValue != null)
            {
                FormDocMaterials form = Owner as FormDocMaterials;
                Materials_ordering_agreement newOrder = new Materials_ordering_agreement(Convert.ToDouble(sumBox.Value), Convert.ToInt32(amountBox.Value), Convert.ToInt32(materialsBox.SelectedValue), Convert.ToInt32(counterpartyBox.SelectedValue));
                if (form.edit)
                {
                    newOrder.ID_Materials_ordering_agreement = Convert.ToInt32(form.docMaterialsGrid.SelectedRows[0].Cells[0].Value);
                    APIHelper.PUT("Materials_ordering_agreement", newOrder, newOrder.ID_Materials_ordering_agreement);
                    form.RefreshGrid();
                    Close();
                }
                else
                {
                    APIHelper.POST("Materials_ordering_agreement", newOrder);
                    var material = APIHelper.GET<Materials>($"Materials/{newOrder.ID_Materials}");
                    material.Amount += newOrder.Amount;
                    APIHelper.PUT("Materials", material, material.ID_Materials);
                    form.RefreshGrid();
                    Close();
                }
            }
            else MessageBox.Show("Заполните все поля");
        }
    }
}

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
    public partial class FormDocTechnics : Form
    {
        public FormDocTechnics()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormDocTechnics_Load(object sender, EventArgs e)
        {
            FormDocOrderer form = Owner as FormDocOrderer;
            var technics = APIHelper.GET<List<Technics>>("Technics");
            var counterparties = APIHelper.GET<List<Counterparty>>("Counterparties");
            technicsBox.DataSource = technics.Where(p => !p.Deleted).ToList();
            technicsBox.DisplayMember = "Name";
            technicsBox.ValueMember = "ID_Technics";
            counterpartyBox.DataSource = counterparties.Where(p => !p.Deleted).ToList();
            counterpartyBox.DisplayMember = "Name";
            counterpartyBox.ValueMember = "ID_Counterparty";
            if (form.edit)
            {
                var current = APIHelper.GET<Equipment_order_agreement>($"Equipment_order_agreement/{form.docTechGrid.SelectedRows[0].Cells[0].Value}");
                Text = $"Редактирование договора №{current.ID_Equipment_order_agreement}";
                numberLabel.Text = current.ID_Equipment_order_agreement.ToString();
                sumBox.Value = Convert.ToDecimal(current.Sum);
                technicsBox.SelectedValue = current.ID_Technics;
                counterpartyBox.SelectedValue = current.ID_Counterparty;
            }
            else
            {
                var equipmentOrderAgreements = APIHelper.GET<List<Equipment_order_agreement>>("Equipment_order_agreement");
                if (equipmentOrderAgreements.Count != 0) numberLabel.Text = (equipmentOrderAgreements[equipmentOrderAgreements.Count - 1].ID_Equipment_order_agreement + 1).ToString();
                else numberLabel.Text = "1";
                Text = "Новый договор";
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (technicsBox.SelectedValue != null && counterpartyBox.SelectedValue != null)
            {
                FormDocOrderer form = Owner as FormDocOrderer;
                Equipment_order_agreement newOrder = new Equipment_order_agreement(Convert.ToDouble(sumBox.Value), Convert.ToInt32(counterpartyBox.SelectedValue), Convert.ToInt32(technicsBox.SelectedValue));
                if (form.edit)
                {
                    newOrder.ID_Equipment_order_agreement = Convert.ToInt32(form.docTechGrid.SelectedRows[0].Cells[0].Value);
                    APIHelper.PUT("Equipment_order_agreement", newOrder, newOrder.ID_Equipment_order_agreement);
                    form.RefreshGrid();
                    Close();
                }
                else
                {
                    APIHelper.POST("Equipment_order_agreement", newOrder);
                    form.RefreshGrid();
                    Close();
                }
            }
            else MessageBox.Show("Заполните все поля");
        }
    }
}

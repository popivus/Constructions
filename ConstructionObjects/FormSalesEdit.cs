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
    public partial class FormSalesEdit : Form
    {
        public FormSalesEdit()
        {
            InitializeComponent();
        }

        private void FormSalesEdit_Load(object sender, EventArgs e)
        {
            FormSales form = Owner as FormSales;
            var counterparties = APIHelper.GET<List<Counterparty>>("Counterparties");
            counterpartyBox.DataSource = counterparties.Where(p => !p.Deleted).ToList();
            counterpartyBox.DisplayMember = "Name";
            counterpartyBox.ValueMember = "ID_Counterparty";
            if (form.edit)
            {
                var current = APIHelper.GET<Sales_contract>($"Sales_contract/{form.salesGrid.SelectedRows[0].Cells[0].Value}");
                Text = $"Редактирование договора №{current.Number}";
                numberBox.Text = current.Number;
                sumBox.Value = Convert.ToDecimal(current.Sum);
                dateBox.Value = current.Contract_date;
                counterpartyBox.SelectedValue = current.ID_Counterparty;
            }
            else Text = "Новый договор";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(numberBox.Text) && counterpartyBox.SelectedValue != null)
            {
                FormSales form = Owner as FormSales;
                if ((form.edit ? APIHelper.GET<List<Sales_contract>>("Sales_contract").Where(c => c.Number == numberBox.Text && c.ID_Sales_contract != Convert.ToInt32(form.salesGrid.SelectedRows[0].Cells[0].Value)).Count() : APIHelper.GET<List<Sales_contract>>("Sales_contract").Where(c => c.Number == numberBox.Text).Count()) == 0)
                {
                    
                    Sales_contract newContract = new Sales_contract(numberBox.Text, dateBox.Value, Convert.ToDouble(sumBox.Value), Convert.ToInt32(counterpartyBox.SelectedValue));
                    if (form.edit)
                    {
                        newContract.ID_Sales_contract = Convert.ToInt32(form.salesGrid.SelectedRows[0].Cells[0].Value);
                        APIHelper.PUT("Sales_contract", newContract, newContract.ID_Sales_contract);
                        form.RefreshGrid();
                        Close();
                    }
                    else
                    {
                        APIHelper.POST("Sales_contract", newContract);
                        form.RefreshGrid();
                        Close();
                    }
                }
                else MessageBox.Show("Договор с таким номером уже существует или существовал");
            }
            else MessageBox.Show("Заполните все поля");
        }
    }
}

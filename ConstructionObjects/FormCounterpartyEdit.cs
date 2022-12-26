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
    public partial class FormCounterpartyEdit : Form
    {
        public FormCounterpartyEdit()
        {
            InitializeComponent();
        }

        private void FormCounterpartyEdit_Load(object sender, EventArgs e)
        {
            FormCounterparty form = Owner as FormCounterparty;
            if (form.edit)
            {
                var current = APIHelper.GET<Counterparty>($"Counterparties/{form.counterpartiesGrid.SelectedRows[0].Cells[0].Value}");
                Text = $"Редактирование \"{current.Name}\"";
                nameBox.Text = current.Name;
                INNBox.Text = current.INN;
                specBox.Text = current.Specialization;
                personalBox.Text = current.Personal_account;
                checkingBox.Text = current.Checking_account;
                dateRegistrationBox.Value = current.Registration_date;
                addressBox.Text = current.Address;
                numberBox.Text = current.Phone_number;
                FIOBox.Text = current.FIO_Responsible_person;
            }
            else Text = "Новый контрагент";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var p = numberBox.Text;
            if (!string.IsNullOrWhiteSpace(nameBox.Text) && !string.IsNullOrWhiteSpace(INNBox.Text) && !string.IsNullOrWhiteSpace(specBox.Text) && !string.IsNullOrWhiteSpace(personalBox.Text) && !string.IsNullOrWhiteSpace(checkingBox.Text) && !string.IsNullOrWhiteSpace(addressBox.Text) && !string.IsNullOrWhiteSpace(FIOBox.Text) && numberBox.Text.Length == 18 && INNBox.Text.Length == 12)
            {
                if (char.IsDigit(p[4]) && char.IsDigit(p[5]) && char.IsDigit(p[6]) && char.IsDigit(p[9]) && char.IsDigit(p[10]) && char.IsDigit(p[11]) && char.IsDigit(p[13]) && char.IsDigit(p[14]) && char.IsDigit(p[16]) && char.IsDigit(p[17]))
                {
                    if (dateRegistrationBox.Value <= DateTime.Now)
                    {
                        FormCounterparty form = Owner as FormCounterparty;
                        Counterparty newCounterparty = new Counterparty(nameBox.Text, INNBox.Text, specBox.Text, personalBox.Text, checkingBox.Text, dateRegistrationBox.Value, addressBox.Text, numberBox.Text, FIOBox.Text);
                        if (form.edit)
                        {
                            newCounterparty.ID_Counterparty = Convert.ToInt32(form.counterpartiesGrid.SelectedRows[0].Cells[0].Value);
                            APIHelper.PUT("Counterparties", newCounterparty, newCounterparty.ID_Counterparty);
                            form.RefreshGrid();
                            Close();
                        }
                        else
                        {
                            APIHelper.POST("Counterparties", newCounterparty);
                            form.RefreshGrid();
                            Close();
                        }
                    }
                    else MessageBox.Show("Неверный формат даты регистрации");
                }
                else MessageBox.Show("Заполните все поля");
            }
            else MessageBox.Show("Заполните все поля");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

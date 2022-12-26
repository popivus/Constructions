using ConstructionsObjects.Models;
using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConstructionObjects
{
    public partial class FormTechnicsEdit : Form
    {
        public bool isType = false;
        public FormTechnicsEdit()
        {
            InitializeComponent();
        }

        private void FormTechnicsEdit_Load(object sender, EventArgs e)
        {
            FormTechnics form = Owner as FormTechnics;
            var types = APIHelper.GET<List<Type_technics>>("Type_technics");
            var countries = APIHelper.GET<List<Country>>("Countries");
            RefreshCombo();
            if (form.edit)
            {
                var current = form.technicsGrid.SelectedRows[0].Cells;
                Text = $"Редактирование \"{current[1].Value}\"";
                nameBox.Text = current[1].Value.ToString();
                typeBox.SelectedValue = types.Where(t => t.Name == current[2].Value.ToString()).FirstOrDefault().ID_Type_technics;
                countryBox.SelectedValue = countries.Where(c => c.Name == current[3].Value.ToString()).FirstOrDefault().ID_Country;
            }
            else Text = "Новая техника";
        }

        public void RefreshCombo()
        {
            var types = APIHelper.GET<List<Type_technics>>("Type_technics").Where(t => t.Deleted == false).ToList();
            typeBox.DataSource = types;
            typeBox.DisplayMember = "Name";
            typeBox.ValueMember = "ID_Type_technics";
            var countries = APIHelper.GET<List<Country>>("Countries").Where(c => c.Deleted == false).ToList();
            countryBox.DataSource = countries;
            countryBox.DisplayMember = "Name";
            countryBox.ValueMember = "ID_Country";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameBox.Text) && typeBox.SelectedValue != null && countryBox.SelectedValue != null)
            {
                FormTechnics form = Owner as FormTechnics;
                Technics newTech = new Technics(nameBox.Text, Convert.ToInt32(typeBox.SelectedValue), Convert.ToInt32(countryBox.SelectedValue));
                if (form.edit)
                {
                    newTech.ID_Technics = Convert.ToInt32(form.technicsGrid.SelectedRows[0].Cells[0].Value);
                    APIHelper.PUT("Technics", newTech, newTech.ID_Technics);
                    form.RefreshGrid();
                    Close();
                }
                else
                {
                    APIHelper.POST("Technics", newTech);
                    form.RefreshGrid();
                    Close();
                }
            }
            else MessageBox.Show("Заполните все поля");
        }

        private void typeAdd_Click(object sender, EventArgs e)
        {
            TypeOrCountry(true);
        }

        private void TypeOrCountry(bool isType)
        {
            this.isType = isType;
            FormTypesTechnics form = new FormTypesTechnics();
            form.Owner = this;
            form.ShowDialog();
        }

        private void countryAdd_Click(object sender, EventArgs e)
        {
            TypeOrCountry(false);
        }
    }
}

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
    public partial class FormInfoObject : Form
    {
        public FormInfoObject()
        {
            InitializeComponent();
        }

        private void FormInfoObject_Load(object sender, EventArgs e)
        {
            FormObjects form = Owner as FormObjects;
            var types = APIHelper.GET<List<Type_object>>("Type_object").Where(t => !t.Deleted).ToList();
            var employees = APIHelper.GET<List<Employee>>("Employees").Where(t => !t.Deleted).ToList();
            var sectors = APIHelper.GET<List<Sector>>("Sectors").Where(t => !t.Deleted).ToList();
            RefreshCombo();
            faceBox.DataSource = employees;
            faceBox.DisplayMember = "Surname";
            faceBox.ValueMember = "ID_Employee";
            sectorBox.DataSource = sectors;
            sectorBox.DisplayMember = "Address";
            sectorBox.ValueMember = "ID_Sector";
            if (form.edit)
            {
                var current = APIHelper.GET<Models.Object>($"Objects/{form.objectsGrid.SelectedRows[0].Cells[0].Value}");
                Text = $"Редактирование объекта №{current.ID_Object}";
                numberLabel.Text = $"Объект №{current.ID_Object}";
                floorsBox.Value = current.Flats;
                areaBox.Value = Convert.ToDecimal(current.Area);
                startDateBox.Value = current.Start_date;
                endDateBox.Value = current.End_date;
                permissionBox.Text = current.Building_permit;
                sectorBox.SelectedValue = current.ID_Sector;
                typeBox.SelectedValue = current.ID_Type_object;
                faceBox.SelectedValue = current.ID_Employee;
                numberBuildingBox.Value = current.Number_building;
            }
            else
            {
                Text = "Новый объект";
                var objects = APIHelper.GET<List<Models.Object>>("Objects");
                if (objects.Count != 0) numberLabel.Text = "Объект №" + (objects[objects.Count - 1].ID_Object + 1).ToString();
                else numberLabel.Text = "Объект №1";
            }
        }

        public void RefreshCombo()
        {
            var types = APIHelper.GET<List<Type_object>>("Type_object").Where(t => !t.Deleted).ToList();
            typeBox.DataSource = types;
            typeBox.ValueMember = "ID_Type_object";
            typeBox.DisplayMember = "Name";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormTypesObject form = new FormTypesObject();
            form.Owner = this;
            form.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (faceBox.SelectedValue != null && typeBox.SelectedValue != null && sectorBox.SelectedValue != null && !string.IsNullOrWhiteSpace(permissionBox.Text))
            {
                if (startDateBox.Value <= endDateBox.Value)
                {
                    FormObjects form = Owner as FormObjects;
                    Models.Object newObject = new Models.Object(Convert.ToDouble(areaBox.Value), Convert.ToInt32(floorsBox.Value), startDateBox.Value, endDateBox.Value, permissionBox.Text, Convert.ToInt32(numberBuildingBox.Value), Convert.ToInt32(sectorBox.SelectedValue), Convert.ToInt32(typeBox.SelectedValue), Convert.ToInt32(faceBox.SelectedValue));
                    if (form.edit)
                    {
                        newObject.ID_Object = Convert.ToInt32(form.objectsGrid.SelectedRows[0].Cells[0].Value);
                        APIHelper.PUT("Objects", newObject, newObject.ID_Object);
                        form.RefreshGrid();
                        Close();
                    }
                    else
                    {
                        APIHelper.POST("Objects", newObject);
                        form.RefreshGrid();
                        Close();
                    }
                }
                else MessageBox.Show("Неверный формат дат");
            }
            else MessageBox.Show("Заполните все поля");
        }
    }
}

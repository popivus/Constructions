using ConstructionsObjects.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConstructionObjects
{
    public partial class FormEmployeesEdit : Form
    {
        bool photoAttached = false;
        string filename, format;
        byte[] imageData;

        public FormEmployeesEdit()
        {
            InitializeComponent();
        }

        private void FormEmployeesEdit_Load(object sender, EventArgs e)
        {
            FormEmployees form = Owner as FormEmployees;
            var positions = APIHelper.GET<List<Position>>("Positions");
            positionBox.DataSource = positions.Where(p => !p.Deleted).ToList();
            positionBox.DisplayMember = "Name";
            positionBox.ValueMember = "ID_Position";
            if (form.edit)
            {
                var current = APIHelper.GET<Employee>($"Employees/{form.employeeGrid.SelectedRows[0].Cells[0].Value}");
                Text = $"Редактирование \"{current.Surname} {current.Name} {current.Middlename}\"";
                surnameBox.Text = current.Surname;
                nameBox.Text = current.Name;
                middlenameBox.Text = current.Middlename;
                INNBox.Text = current.INN;
                seriaBox.Text = current.Seria_passport;
                numberPassportBox.Text = current.Number_passport;
                SNILSBox.Text = current.SNILS;
                firedCheckBox.Checked = current.Fired;
                birthdayDateBox.Value = current.Birthday;
                positionBox.SelectedValue = current.ID_Position;
                if (current.Passport_scan != null)
                {
                    scanPictureBox.Image = ByteToImage(current.Passport_scan);
                    photoAttached = true;
                }
            }
            else Text = "Новый сотрудник";
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(nameBox.Text) && !string.IsNullOrWhiteSpace(surnameBox.Text) && seriaBox.Text.Trim().Length == 4 && numberPassportBox.Text.Trim().Length == 6 && SNILSBox.Text.Trim().Length == 11 && INNBox.Text.Trim().Length == 12 && photoAttached && positionBox.SelectedItem != null)
            {
                if (birthdayDateBox.Value <= DateTime.Now.AddYears(18))
                {
                    FormEmployees form = Owner as FormEmployees;
                    Employee newEmployee = new Employee(surnameBox.Text, nameBox.Text, middlenameBox.Text, seriaBox.Text, numberPassportBox.Text, SNILSBox.Text, INNBox.Text, firedCheckBox.Checked, imageData, birthdayDateBox.Value, Convert.ToInt32(positionBox.SelectedValue.ToString()));
                    if (form.edit)
                    {
                        newEmployee.ID_Employee = Convert.ToInt32(form.employeeGrid.SelectedRows[0].Cells[0].Value);
                        APIHelper.PUT("Employees", newEmployee, newEmployee.ID_Employee);
                        form.RefreshGrid();
                        Close();
                    }
                    else
                    {
                        APIHelper.POST("Employees", newEmployee);
                        form.RefreshGrid();
                        Close();
                    }
                }
                else MessageBox.Show("Неверный формат даты рождения");
            }
            else MessageBox.Show("Заполните все поля");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Изображение (*.png;*.jpg)|*.png;*.jpg";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filename = openFileDialog.FileName;
                    format = filename.Split('.').Last();
                    using (FileStream fs = new FileStream(filename, FileMode.Open))
                    {
                        imageData = new byte[fs.Length];
                        fs.Read(imageData, 0, imageData.Length);
                    }
                    scanPictureBox.Image = ByteToImage(imageData);
                    photoAttached = true;
                }
            }
        }

        public static Bitmap ByteToImage(byte[] blob)
        {
            MemoryStream mStream = new MemoryStream();
            byte[] pData = blob;
            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
            Bitmap bm = new Bitmap(mStream, false);
            mStream.Dispose();
            return bm;
        }
    }
}

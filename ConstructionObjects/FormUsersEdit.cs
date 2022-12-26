using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ConstructionObjects
{
    public partial class FormUsersEdit : Form
    {
        public FormUsersEdit()
        {
            InitializeComponent();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormUsersEdit_Load(object sender, EventArgs e)
        {
            rolesBox.DataSource = DBHelper.FillDataSet("SELECT * FROM [dbo].[Roles_ComboBox]").Tables[0];
            rolesBox.DisplayMember = "Имя";
            rolesBox.ValueMember = "ID";
            employeeBox.DataSource = DBHelper.FillDataSet("SELECT * FROM [dbo].[Employees_ComboBox]").Tables[0];
            employeeBox.DisplayMember = "ФИО";
            employeeBox.ValueMember = "ID";
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(loginBox.Text) && !string.IsNullOrWhiteSpace(passwordBox.Text) && !string.IsNullOrWhiteSpace(repasswordBox.Text) && rolesBox.SelectedItem != null && employeeBox.SelectedItem != null)
            {
                if (passwordBox.Text == repasswordBox.Text)
                {
                    DBHelper.CmdScalar($"EXEC [dbo].[User_Insert] '{loginBox.Text}', '{GetMd5Hash(passwordBox.Text)}', {employeeBox.SelectedValue}, {rolesBox.SelectedValue}");
                    FormUsers form = Owner as FormUsers;
                    form.RefreshGrid();
                    Close();
                }
                else MessageBox.Show("Пароли не совпадают");
            }
            else MessageBox.Show("Заполните все поля");
        }

        private string GetMd5Hash(string input)
        {
            MD5 md5Hash = MD5.Create();
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }
    }
}

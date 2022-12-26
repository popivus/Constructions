using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace ConstructionObjects
{
    public partial class FormAuth : Form
    {
        public FormAuth()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(loginBox.Text) && !string.IsNullOrWhiteSpace(passwordBox.Text)) Login();
            else MessageBox.Show("Заполните все поля");
        }

        private void Login()
        {
            Models.User user = APIHelper.GET<Models.User>($"Users/{loginBox.Text}&{GetMd5Hash(passwordBox.Text)}");
            if (user != null)
            {
                if (user.Name == loginBox.Text && user.Password == GetMd5Hash(passwordBox.Text))
                {
                    switch (user.ID_Role)
                    {
                        case 1:
                            MessageBox.Show("Вам необходимо использовать приложение для администратора информационной системы");
                            break;
                        case 2:
                            FormMenuSales formSales = new FormMenuSales();
                            formSales.Owner = this;
                            formSales.Show();
                            HideAuth();
                            break;
                        case 3:
                            FormMenuHRD formHRD = new FormMenuHRD();
                            formHRD.Owner = this;
                            formHRD.Show();
                            HideAuth();
                            break;
                        case 4:
                            FormMenuObjects formObjects = new FormMenuObjects();
                            formObjects.Owner = this;
                            formObjects.Show();
                            HideAuth();
                            break;
                        case 5:
                            FormMenuStorage formStorage = new FormMenuStorage();
                            formStorage.Owner = this;
                            formStorage.Show();
                            HideAuth();
                            break;
                        case 6:
                            FormMenuDocuments formDoc = new FormMenuDocuments();
                            formDoc.Owner = this;
                            formDoc.Show();
                            HideAuth();
                            break;
                    }
                }
                else MessageBox.Show("Такого пользователя не существует");
            }
            else MessageBox.Show("Ошибка подключения к серверам", "Ошибка");
        }

        private void HideAuth()
        {
            Hide();
            loginBox.Text = "";
            passwordBox.Text = "";
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

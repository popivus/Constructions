using ConstructionObjects.Models;
using CsvHelper;
using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConstructionObjects
{
    public partial class FormUsers : Form
    {
        public FormUsers()
        {
            InitializeComponent();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FormUsersEdit form = new FormUsersEdit();
            form.Owner = this;
            form.ShowDialog();
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FormUsers_Load(object sender, EventArgs e)
        {
            RefreshGrid();
            ToolStripMenuItem addMenuItem = new ToolStripMenuItem("Создать");
            ToolStripMenuItem logDeleteMenuItem = new ToolStripMenuItem("В корзину");
            ToolStripMenuItem redeleteMenuItem = new ToolStripMenuItem("Восстановить");
            ToolStripMenuItem deleteMenuItem = new ToolStripMenuItem("Удалить");
            contextMenuStrip1.Items.AddRange(new[] { addMenuItem, logDeleteMenuItem, redeleteMenuItem, deleteMenuItem });
            usersGrid.ContextMenuStrip = contextMenuStrip1;
            addMenuItem.Click += addButton_Click;
            deleteMenuItem.Click += deleteButton_Click;
            redeleteMenuItem.Click += restoreButton_Click;
            logDeleteMenuItem.Click += button1_Click;
        }

        public void RefreshGrid()
        {
            SearchGrid("");
        }

        private void SearchGrid(string search)
        {
            usersGrid.DataSource = DBHelper.FillDataSet("SELECT * FROM [dbo].[Users_Show]" + (search == "" ? "" : $" WHERE Логин = '{search}'")).Tables[0];
            usersGrid.Columns[0].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LogicalDeleteOrRestore(true);
        }

        private void LogicalDeleteOrRestore(bool isDelete)
        {
            if (usersGrid.SelectedRows.Count != 0)
            {
                DBHelper.CmdScalar($"EXEC [dbo].[User_Update_Deleted] {usersGrid.SelectedRows[0].Cells[0].Value}, {(isDelete ? "1" : "0")}");
                RefreshGrid();
            }
        }

        private void restoreButton_Click(object sender, EventArgs e)
        {
            LogicalDeleteOrRestore(false);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (usersGrid.SelectedRows.Count != 0)
            {
                DBHelper.CmdScalar($"EXEC [dbo].[User_Delete] {usersGrid.SelectedRows[0].Cells[0].Value}");
                RefreshGrid();
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(searchBox.Text)) RefreshGrid();
            else SearchGrid(searchBox.Text);
        }

        private void searchBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (string.IsNullOrWhiteSpace(searchBox.Text)) RefreshGrid();
                else SearchGrid(searchBox.Text);
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Список (*.csv)|*.csv";
            openFileDialog1.Multiselect = false;
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (TextFieldParser parser = new TextFieldParser(openFileDialog1.FileName))
                {
                    parser.TextFieldType = FieldType.Delimited;
                    parser.SetDelimiters(";");
                    while (!parser.EndOfData)
                    {
                        string[] fields = parser.ReadFields();
                        APIHelper.POST("Users", new User(fields[0], fields[1], Convert.ToInt32(fields[2].ToString()), Convert.ToInt32(fields[3].ToString()), Convert.ToBoolean(fields[4])));
                    }
                    MessageBox.Show("Импорт завершён");
                }
                RefreshGrid();
            }
        }

        private void exportButton_Click(object sender, EventArgs e)
        {
            var data = DBHelper.FillDataSet("SELECT * FROM [dbo].[User]").Tables[0];
            List<User> users = new List<User>();
            foreach (DataRow row in data.Rows) users.Add(new User(row.ItemArray[0].ToString(), row.ItemArray[1].ToString(), Convert.ToInt32(row.ItemArray[2].ToString()), Convert.ToInt32(row.ItemArray[3].ToString()), Convert.ToBoolean(row.ItemArray[4])));
            saveFileDialog1.Filter = "Список (*.csv)|*.csv";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter streamWriter = new StreamWriter(saveFileDialog1.FileName, false))
                {
                    foreach (User user in users)
                    {
                        streamWriter.Write(user.Name);
                        streamWriter.Write(";");
                        streamWriter.Write(user.Password);
                        streamWriter.Write(";");
                        streamWriter.Write(user.ID_Employee);
                        streamWriter.Write(";");
                        streamWriter.Write(user.ID_Role);
                        streamWriter.Write(";");
                        streamWriter.Write(user.Deleted);
                        streamWriter.Write(streamWriter.NewLine);
                    }
                }
            }
        }
    }
}

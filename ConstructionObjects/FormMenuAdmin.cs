using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ConstructionObjects
{
    public partial class FormMenuAdmin : Form
    {
        bool logout = false;
        FormTechnics formTechnics;
        FormMaterials formMaterials;
        FormCounterparty formCounterparty;
        FormDocOrderer formDocOrderer;
        FormDocMaterials formDocMaterials;
        FormBrigades formBrigades;
        FormEmployees formEmployee;
        FormObjects formObjects;
        FormPositions formPositions;
        FormSales formSales;
        FormSector formSector;
        FormUsers formUsers;

        public FormMenuAdmin()
        {
            InitializeComponent();
        }

        private void техникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formTechnics == null || formTechnics.IsDisposed)
            {
                formTechnics = new FormTechnics();
                formTechnics.Show();
            }
            else formTechnics.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormAuth auth = Owner as FormAuth;
            auth.Show();
            logout = true;
            Close();
        }

        private void FormMenuDocuments_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logout) Application.Exit();
        }

        private void материалыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formMaterials == null || formMaterials.IsDisposed)
            {
                formMaterials = new FormMaterials();
                formMaterials.Show();
            }
            else formMaterials.Focus();
        }

        private void контрагентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formCounterparty == null || formCounterparty.IsDisposed)
            {
                formCounterparty = new FormCounterparty();
                formCounterparty.Show();
            }
            else formCounterparty.Focus();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (formUsers == null || formUsers.IsDisposed)
            {
                formUsers = new FormUsers();
                formUsers.Show();
            }
            else formUsers.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "Файлы резервного копирования(*.bak)|*.bak";
            if (saveFileDialog1.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saveFileDialog1.FileName;
            DBHelper.CmdScalar($"BACKUP DATABASE [ConstructionObjects] TO DISK = '{filename}'");
            MessageBox.Show("Резервное копирование завершено");
        }

        private void бригадыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formBrigades == null || formBrigades.IsDisposed)
            {
                formBrigades = new FormBrigades();
                formBrigades.Show();
            }
            else formBrigades.Focus();
        }

        private void договорыОЗаказеМатериаловToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formDocMaterials == null || formDocMaterials.IsDisposed)
            {
                formDocMaterials = new FormDocMaterials();
                formDocMaterials.Show();
            }
            else formDocMaterials.Focus();
        }

        private void договорыОЗаказеТехникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formDocOrderer == null || formDocOrderer.IsDisposed)
            {
                formDocOrderer = new FormDocOrderer();
                formDocOrderer.Show();
            }
            else formDocOrderer.Focus();
        }

        private void договорыПродажToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formSales == null || formSales.IsDisposed)
            {
                formSales = new FormSales();
                formSales.Show();
            }
            else formSales.Focus();
        }

        private void должностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formPositions == null || formPositions.IsDisposed)
            {
                formPositions = new FormPositions();
                formPositions.Show();
            }
            else formPositions.Focus();
        }

        private void объектыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formObjects == null || formObjects.IsDisposed)
            {
                formObjects = new FormObjects();
                formObjects.Show();
            }
            else formObjects.Focus();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formEmployee == null || formEmployee.IsDisposed)
            {
                formEmployee = new FormEmployees();
                formEmployee.Show();
            }
            else formEmployee.Focus();
        }

        private void участкиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formSector == null || formSector.IsDisposed)
            {
                formSector = new FormSector();
                formSector.Show();
            }
            else formSector.Focus();
        }

        public static Action Completed;
        private void recoverButton_Click(object sender, EventArgs e)
        {
            Thread thread = new Thread(() =>
            {
                openFileDialog1.Filter = "Файлы резервного копирования(*.bak)|*.bak";
                openFileDialog1.Multiselect = false;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    DBHelper.CmdScalar($"USE [master]; ALTER DATABASE [ConstructionObjects] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;RESTORE DATABASE [ConstructionObjects] FROM DISK='{openFileDialog1.FileName}' " +
                    $"WITH REPLACE, file=1, nounload,stats=5;ALTER DATABASE [ConstructionObjects] SET MULTI_USER;");
                }
                MessageBox.Show("Восстановление завершено");
                Completed?.Invoke();
            });
            thread.SetApartmentState(ApartmentState.STA);
            thread.Start();
        } 
    }
}


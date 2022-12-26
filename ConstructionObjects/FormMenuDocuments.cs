using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConstructionObjects
{
    public partial class FormMenuDocuments : Form
    {
        bool logout = false;
        FormTechnics formTechnics;
        FormMaterials formMaterials;
        FormCounterparty formCounterparty;
        FormDocOrderer formDocOrderer;
        FormDocMaterials formDocMaterials;

        public FormMenuDocuments()
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
            if (formDocOrderer == null || formDocOrderer.IsDisposed)
            {
                formDocOrderer = new FormDocOrderer();
                formDocOrderer.Show();
            }
            else formDocOrderer.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (formDocMaterials == null || formDocMaterials.IsDisposed)
            {
                formDocMaterials = new FormDocMaterials();
                formDocMaterials.Show();
            }
            else formDocMaterials.Focus();
        }
    }
}

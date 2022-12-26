using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConstructionObjects
{
    public partial class FormMenuStorage : Form
    {
        bool logout = false;
        FormTechnics formTechnics;
        FormMaterials formMaterials;
        FormObjectsStorage formObjects;
        public FormMenuStorage()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FormAuth auth = Owner as FormAuth;
            auth.Show();
            logout = true;
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (formObjects == null || formObjects.IsDisposed)
            {
                formObjects = new FormObjectsStorage();
                formObjects.Show();
            }
            else formObjects.Focus();
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

        private void техникаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (formTechnics == null || formTechnics.IsDisposed)
            {
                formTechnics = new FormTechnics();
                formTechnics.Show();
            }
            else formTechnics.Focus();
        }

        private void FormMenuStorage_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logout) Application.Exit();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConstructionObjects
{
    public partial class FormMenuObjects : Form
    {
        bool logout = false;

        FormCounterparty formCounterparty;
        FormSector formSector;
        FormObjects formObjects;
        FormBrigades formBrigades;

        public FormMenuObjects()
        {
            InitializeComponent();
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
                formObjects = new FormObjects();
                formObjects.Show();
            }
            else formObjects.Focus();
        }

        private void FormMenuObjects_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logout) Application.Exit();
        }

        private void brigadesButton_Click(object sender, EventArgs e)
        {
            if (formBrigades == null || formBrigades.IsDisposed)
            {
                formBrigades = new FormBrigades();
                formBrigades.Show();
            }
            else formBrigades.Focus();
        }

        private void sectorsButton_Click(object sender, EventArgs e)
        {
            if (formSector == null || formSector.IsDisposed)
            {
                formSector = new FormSector();
                formSector.Show();
            }
            else formSector.Focus();
        }

    }
}

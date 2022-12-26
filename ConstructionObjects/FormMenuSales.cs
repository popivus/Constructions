using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConstructionObjects
{
    public partial class FormMenuSales : Form
    {
        bool logout = false;

        FormCounterparty formCounterparty;
        FormSales formSales;
        public FormMenuSales()
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

        private void FormMenuSales_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logout) Application.Exit();
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
            if (formSales == null || formSales.IsDisposed)
            {
                formSales = new FormSales();
                formSales.Show();
            }
            else formSales.Focus();
        }
    }
}

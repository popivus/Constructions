using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ConstructionObjects
{
    public partial class FormMenuHRD : Form
    {
        bool logout = false;

        FormEmployees formEmployees;
        FormPositions formPositions;
        public FormMenuHRD()
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

        private void FormMenuHRD_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (!logout) Application.Exit();
        }

        private void employeeButton_Click(object sender, EventArgs e)
        {
            if (formEmployees == null || formEmployees.IsDisposed)
            {
                formEmployees = new FormEmployees();
                formEmployees.Show();
            }
            else formEmployees.Focus();
        }

        private void positionButton_Click(object sender, EventArgs e)
        {
            if (formPositions == null || formPositions.IsDisposed)
            {
                formPositions = new FormPositions();
                formPositions.Show();
            }
            else formPositions.Focus();
        }
    }
}

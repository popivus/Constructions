using ConstructionsObjects.Models;
using Syncfusion.Windows.Forms.Chart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ConstructionObjects
{
    public partial class FormAnalysis : Form
    {
        public FormAnalysis()
        {
            InitializeComponent();
        }

        private void FormAnalysis_Load(object sender, EventArgs e)
        {
            chartControl1.Series.Clear();
            chartControl1.Axes[0].IsVisible = false;
            var positions = APIHelper.GET<List<Position>>("Positions").Where(p => !p.Deleted).ToList();
            var employees = APIHelper.GET<List<Employee>>("Employees").Where(e => !e.Deleted && !e.Fired).ToList();
            foreach (Position pos in positions)
            {
                ChartSeries newSeries = new ChartSeries(pos.Name);
                newSeries.Points.Add(0, pos.Salary * employees.Where(e => e.ID_Position == pos.ID_Position).Count());
                chartControl1.Series.Add(newSeries);
            }
        }

        private void backButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}

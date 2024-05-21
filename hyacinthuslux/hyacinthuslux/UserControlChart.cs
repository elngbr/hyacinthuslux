using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using CourierDistributionChartLibrary;

namespace hyacinthuslux
{
    public partial class UserControlChart : Form
    {
        private CourierDistributionChart courierDistributionChart;

        public UserControlChart()
        {
            InitializeComponent();
        }

        private void UserControlChart_Load(object sender, EventArgs e)
        {
            courierDistributionChart = new CourierDistributionChart();
            courierDistributionChart.Location = new Point(19, 10);
            courierDistributionChart.Size = new Size(400, 300);
            Controls.Add(courierDistributionChart);
        }

        // Updated SetChart method to pass arrays of strings and integers to the CourierDistributionChart control
        public void SetChart(string[] labels, int[] data)
        {
            // Pass the data to the CourierDistributionChart control
            courierDistributionChart.SetData(labels, data);
        }
    }
}

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

        
        public void SetChart(string[] labels, int[] data)
        {
            
            courierDistributionChart.SetData(labels, data);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace hyacinthuslux
{
    public partial class CouriersDistribution : Form
    {
        private Dictionary<EnumCourier.CourierEnum, int> courierDistribution;

        public CouriersDistribution(Dictionary<EnumCourier.CourierEnum, int> courierDistribution)
        {
            InitializeComponent();
            this.courierDistribution = courierDistribution;
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawPieChart(e.Graphics, courierDistribution);
        }

        private void DrawPieChart(Graphics graphics, Dictionary<EnumCourier.CourierEnum, int> distribution)
        {
            if (distribution == null || distribution.Count == 0)
                return;

            int totalDeliveries = distribution.Values.Sum();
            Color[] colors = { Color.Red, Color.Green, Color.Blue, Color.Yellow, Color.Purple, Color.Orange, Color.Brown, Color.Cyan };
            Rectangle rect = new Rectangle(50, 50, 400, 400);
            float startAngle = 0f;
            int colorIndex = 0;
            foreach (var entry in distribution)
            {
                float sweepAngle = (entry.Value / (float)totalDeliveries) * 360f;
                graphics.FillPie(new SolidBrush(colors[colorIndex % colors.Length]), rect, startAngle, sweepAngle);
                startAngle += sweepAngle;
                colorIndex++;
            }
        }
    }
}

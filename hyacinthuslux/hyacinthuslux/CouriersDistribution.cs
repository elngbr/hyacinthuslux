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

            Font legendFont = new Font(FontFamily.GenericSansSerif, 10, FontStyle.Bold);

            foreach (var entry in distribution)
            {
                float sweepAngle = (entry.Value / (float)totalDeliveries) * 360f;
                graphics.FillPie(new SolidBrush(colors[colorIndex % colors.Length]), rect, startAngle, sweepAngle);
                startAngle += sweepAngle;

                // Draw legend
                graphics.FillRectangle(new SolidBrush(colors[colorIndex % colors.Length]), 500, 50 + colorIndex * 20, 20, 20);
                graphics.DrawString(entry.Key.ToString(), legendFont, Brushes.Black, 525, 50 + colorIndex * 20);

                // Calculate label angle
                float labelAngle = startAngle - sweepAngle / 2;

                // Draw label
                float labelX = rect.Left + rect.Width / 2;
                float labelY = rect.Top + rect.Height / 2;
                float labelRadius = rect.Width / 2 + 10;
                float labelPosX = (float)(labelX + labelRadius * Math.Cos(labelAngle * Math.PI / 180));
                float labelPosY = (float)(labelY + labelRadius * Math.Sin(labelAngle * Math.PI / 180));
                graphics.DrawString(entry.Key.ToString(), legendFont, Brushes.Black, labelPosX, labelPosY);

                colorIndex++;
            }
        }

        private void CouriersDistribution_Load(object sender, EventArgs e)
        {

        }
    }
}

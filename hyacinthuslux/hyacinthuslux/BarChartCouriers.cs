using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace hyacinthuslux
{
    public partial class BarChartCouriers : Form
    {
        private Dictionary<EnumCourier.CourierEnum, int> courierDistribution;

        public BarChartCouriers(Dictionary<EnumCourier.CourierEnum, int> courierDistribution)
        {
            InitializeComponent();
            this.courierDistribution = courierDistribution;
        }

        private void CouriersBarChart_Paint(object sender, PaintEventArgs e)
        {
            if (courierDistribution == null || courierDistribution.Count == 0)
                return;

            Graphics graphics = e.Graphics;
            int barWidth = 50;
            int barSpacing = 20;
            int startX = 50;
            int startY = 50;
            int maxHeight = 300;
            int legendX = 500;
            int legendY = 50;
            int legendWidth = 200;
            int legendHeight = 20;

            // Determine the maximum value to scale the bars
            int maxValue = courierDistribution.Max(kv => kv.Value);

            Random rand = new Random();

            foreach (var kvp in courierDistribution)
            {
                int barHeight = (int)((double)kvp.Value / maxValue * maxHeight);
                Rectangle barRect = new Rectangle(startX, startY + maxHeight - barHeight, barWidth, barHeight);

                // Generate a random color for each bar
                Color barColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                graphics.FillRectangle(new SolidBrush(barColor), barRect);

                // Draw text for each bar
                string text = $"{kvp.Key.ToString()}\n{kvp.Value}";
                SizeF textSize = graphics.MeasureString(text, this.Font);
                PointF textLocation = new PointF(startX + (barWidth - textSize.Width) / 2, startY + maxHeight - barHeight - textSize.Height - 5);
                graphics.DrawString(text, this.Font, Brushes.Black, textLocation);

                // Draw legend
                Rectangle legendRect = new Rectangle(legendX, legendY, legendWidth, legendHeight);
                graphics.FillRectangle(new SolidBrush(barColor), legendRect);
                graphics.DrawString($"{kvp.Key.ToString()} - {kvp.Value}", this.Font, Brushes.Black, legendX + legendWidth + 5, legendY);

                startX += barWidth + barSpacing;
                legendY += legendHeight + 5;
            }
        }



    }
}

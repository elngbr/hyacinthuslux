using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace hyacinthuslux
{
    public partial class BarChartCouriers : Form
    {
        private Dictionary<EnumCourier.CourierEnum, int> courierDistribution;//a disctinary with values of enum and their appearances in the DELIVERIES form

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
           

            int maxValue = courierDistribution.Max(kv => kv.Value);///retrieving the max value

            Random rand = new Random();///////////////////////////////////////////////////////////////Here we use class random!!!

            foreach (var kvp in courierDistribution)
            {
                int barHeight = (int)((double)kvp.Value / maxValue * maxHeight);
                Rectangle barRect = new Rectangle(startX, startY + maxHeight - barHeight, barWidth, barHeight);

                Color barColor = Color.FromArgb(rand.Next(256), rand.Next(256), rand.Next(256));
                graphics.FillRectangle(new SolidBrush(barColor), barRect);

                string text = $"{kvp.Key.ToString()}\n{kvp.Value}";
                SizeF textSize = graphics.MeasureString(text, this.Font);
                PointF textLocation = new PointF(startX + (barWidth - textSize.Width) / 2, startY + maxHeight - barHeight - textSize.Height - 5);
                //take care how you explain this
                graphics.DrawString(text, this.Font, Brushes.Black, textLocation);

               
                startX += barWidth + barSpacing;
              
            }
        }

        private void BarChartCouriers_Load(object sender, EventArgs e)
        {

        }
    }
}

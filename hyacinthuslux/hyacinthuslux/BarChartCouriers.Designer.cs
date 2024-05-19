namespace hyacinthuslux
{
    partial class BarChartCouriers
    {
        private System.Windows.Forms.Panel chartPanel;

        private void InitializeComponent()
        {
            this.chartPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // chartPanel
            // 
            this.chartPanel.BackColor = System.Drawing.Color.White;
            this.chartPanel.Location = new System.Drawing.Point(50, 50);
            this.chartPanel.Name = "chartPanel";
            this.chartPanel.Size = new System.Drawing.Size(700, 300);
            this.chartPanel.TabIndex = 0;
            this.chartPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.CouriersBarChart_Paint);
            // 
            // BarChartCouriers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartPanel);
            this.Name = "BarChartCouriers";
            this.Text = "BarChartCouriers";
            this.Load += new System.EventHandler(this.BarChartCouriers_Load);
            this.ResumeLayout(false);

        }
    }
}

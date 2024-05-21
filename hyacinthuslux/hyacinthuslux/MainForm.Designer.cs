namespace hyacinthuslux
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.addDeliveryBtn = new System.Windows.Forms.Button();
            this.addClientBtn = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.dataGridViewDeliveries = new System.Windows.Forms.DataGridView();
            this.btnDeleteDelivery = new System.Windows.Forms.Button();
            this.CouriersPieChart = new System.Windows.Forms.Button();
            this.CouriersBarChart = new System.Windows.Forms.Button();
            this.btnUserCtrl = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeliveries)).BeginInit();
            this.SuspendLayout();
            // 
            // addDeliveryBtn
            // 
            this.addDeliveryBtn.BackColor = System.Drawing.Color.PaleGreen;
            this.addDeliveryBtn.Location = new System.Drawing.Point(350, 615);
            this.addDeliveryBtn.Name = "addDeliveryBtn";
            this.addDeliveryBtn.Size = new System.Drawing.Size(167, 51);
            this.addDeliveryBtn.TabIndex = 2;
            this.addDeliveryBtn.Text = "Add &Delivery";
            this.addDeliveryBtn.UseVisualStyleBackColor = false;
            this.addDeliveryBtn.Click += new System.EventHandler(this.addDeliveryBtn_Click);
            // 
            // addClientBtn
            // 
            this.addClientBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.addClientBtn.Location = new System.Drawing.Point(12, 615);
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.Size = new System.Drawing.Size(170, 51);
            this.addClientBtn.TabIndex = 4;
            this.addClientBtn.Text = "Add &Client";
            this.addClientBtn.UseVisualStyleBackColor = false;
            this.addClientBtn.Click += new System.EventHandler(this.addClientBtn_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnAddProduct.Location = new System.Drawing.Point(188, 615);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(156, 51);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "Add &Product";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dataGridViewDeliveries
            // 
            this.dataGridViewDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeliveries.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewDeliveries.Name = "dataGridViewDeliveries";
            this.dataGridViewDeliveries.RowHeadersWidth = 51;
            this.dataGridViewDeliveries.RowTemplate.Height = 24;
            this.dataGridViewDeliveries.Size = new System.Drawing.Size(753, 577);
            this.dataGridViewDeliveries.TabIndex = 6;
            this.dataGridViewDeliveries.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewDeliveries_CellContentClick);
            // 
            // btnDeleteDelivery
            // 
            this.btnDeleteDelivery.BackColor = System.Drawing.Color.Red;
            this.btnDeleteDelivery.Location = new System.Drawing.Point(523, 615);
            this.btnDeleteDelivery.Name = "btnDeleteDelivery";
            this.btnDeleteDelivery.Size = new System.Drawing.Size(158, 48);
            this.btnDeleteDelivery.TabIndex = 7;
            this.btnDeleteDelivery.Text = "Delete Delivery";
            this.btnDeleteDelivery.UseVisualStyleBackColor = false;
            this.btnDeleteDelivery.Click += new System.EventHandler(this.btnDeleteDelivery_Click);
            // 
            // CouriersPieChart
            // 
            this.CouriersPieChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CouriersPieChart.Location = new System.Drawing.Point(779, 144);
            this.CouriersPieChart.Name = "CouriersPieChart";
            this.CouriersPieChart.Size = new System.Drawing.Size(207, 51);
            this.CouriersPieChart.TabIndex = 8;
            this.CouriersPieChart.Text = "Couriers Pie Chart";
            this.CouriersPieChart.UseVisualStyleBackColor = false;
            this.CouriersPieChart.Click += new System.EventHandler(this.CouriersPieChart_Click);
            // 
            // CouriersBarChart
            // 
            this.CouriersBarChart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CouriersBarChart.Location = new System.Drawing.Point(779, 221);
            this.CouriersBarChart.Name = "CouriersBarChart";
            this.CouriersBarChart.Size = new System.Drawing.Size(207, 51);
            this.CouriersBarChart.TabIndex = 9;
            this.CouriersBarChart.Text = "Couriers Bar Chart";
            this.CouriersBarChart.UseVisualStyleBackColor = false;
            this.CouriersBarChart.Click += new System.EventHandler(this.CouriersBarChart_Click);
            // 
            // btnUserCtrl
            // 
            this.btnUserCtrl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUserCtrl.Location = new System.Drawing.Point(779, 75);
            this.btnUserCtrl.Name = "btnUserCtrl";
            this.btnUserCtrl.Size = new System.Drawing.Size(207, 51);
            this.btnUserCtrl.TabIndex = 10;
            this.btnUserCtrl.Text = "UserCTRL: Couriers Bar Chart";
            this.btnUserCtrl.UseVisualStyleBackColor = false;
            this.btnUserCtrl.Click += new System.EventHandler(this.btnUserCtrl_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1009, 703);
            this.Controls.Add(this.btnUserCtrl);
            this.Controls.Add(this.CouriersBarChart);
            this.Controls.Add(this.CouriersPieChart);
            this.Controls.Add(this.btnDeleteDelivery);
            this.Controls.Add(this.dataGridViewDeliveries);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.addClientBtn);
            this.Controls.Add(this.addDeliveryBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeliveries)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addDeliveryBtn;
        private System.Windows.Forms.Button addClientBtn;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dataGridViewDeliveries;
        private System.Windows.Forms.Button btnDeleteDelivery;
        private System.Windows.Forms.Button CouriersPieChart;
        private System.Windows.Forms.Button CouriersBarChart;
        private System.Windows.Forms.Button btnUserCtrl;
    }
}
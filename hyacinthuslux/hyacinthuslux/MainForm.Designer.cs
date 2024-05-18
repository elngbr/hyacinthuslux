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
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdClient = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantities = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Products = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnDeleteDelivery = new System.Windows.Forms.Button();
            this.CouriersPieChart = new System.Windows.Forms.Button();
            this.CouriersBarChart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewDeliveries)).BeginInit();
            this.SuspendLayout();
            // 
            // addDeliveryBtn
            // 
            this.addDeliveryBtn.Location = new System.Drawing.Point(352, 618);
            this.addDeliveryBtn.Name = "addDeliveryBtn";
            this.addDeliveryBtn.Size = new System.Drawing.Size(167, 51);
            this.addDeliveryBtn.TabIndex = 2;
            this.addDeliveryBtn.Text = "Add &Delivery";
            this.addDeliveryBtn.UseVisualStyleBackColor = true;
            this.addDeliveryBtn.Click += new System.EventHandler(this.addDeliveryBtn_Click);
            // 
            // addClientBtn
            // 
            this.addClientBtn.Location = new System.Drawing.Point(12, 615);
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.Size = new System.Drawing.Size(170, 51);
            this.addClientBtn.TabIndex = 4;
            this.addClientBtn.Text = "Add &Client";
            this.addClientBtn.UseVisualStyleBackColor = true;
            this.addClientBtn.Click += new System.EventHandler(this.addClientBtn_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(525, 618);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(156, 51);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "Add &Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dataGridViewDeliveries
            // 
            this.dataGridViewDeliveries.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewDeliveries.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientName,
            this.IdClient,
            this.Quantities,
            this.Products,
            this.DeliveryMethod,
            this.DeliveryDate,
            this.delLocation,
            this.totalValue});
            this.dataGridViewDeliveries.Location = new System.Drawing.Point(3, 2);
            this.dataGridViewDeliveries.Name = "dataGridViewDeliveries";
            this.dataGridViewDeliveries.RowHeadersWidth = 51;
            this.dataGridViewDeliveries.RowTemplate.Height = 24;
            this.dataGridViewDeliveries.Size = new System.Drawing.Size(1190, 577);
            this.dataGridViewDeliveries.TabIndex = 6;
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "ClientName";
            this.ClientName.MinimumWidth = 6;
            this.ClientName.Name = "ClientName";
            this.ClientName.Width = 150;
            // 
            // IdClient
            // 
            this.IdClient.HeaderText = "IdClient";
            this.IdClient.MinimumWidth = 6;
            this.IdClient.Name = "IdClient";
            this.IdClient.Width = 45;
            // 
            // Quantities
            // 
            this.Quantities.HeaderText = "Quanitites";
            this.Quantities.MinimumWidth = 6;
            this.Quantities.Name = "Quantities";
            this.Quantities.Width = 70;
            // 
            // Products
            // 
            this.Products.HeaderText = "Products";
            this.Products.MinimumWidth = 6;
            this.Products.Name = "Products";
            this.Products.Width = 115;
            // 
            // DeliveryMethod
            // 
            this.DeliveryMethod.HeaderText = "Delivery Method";
            this.DeliveryMethod.MinimumWidth = 6;
            this.DeliveryMethod.Name = "DeliveryMethod";
            this.DeliveryMethod.Width = 95;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.HeaderText = "DeliveryDate";
            this.DeliveryDate.MinimumWidth = 6;
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Width = 125;
            // 
            // delLocation
            // 
            this.delLocation.HeaderText = "delLocation";
            this.delLocation.MinimumWidth = 6;
            this.delLocation.Name = "delLocation";
            this.delLocation.Width = 125;
            // 
            // totalValue
            // 
            this.totalValue.HeaderText = "totalValue";
            this.totalValue.MinimumWidth = 6;
            this.totalValue.Name = "totalValue";
            this.totalValue.Width = 70;
            // 
            // btnDeleteDelivery
            // 
            this.btnDeleteDelivery.Location = new System.Drawing.Point(188, 618);
            this.btnDeleteDelivery.Name = "btnDeleteDelivery";
            this.btnDeleteDelivery.Size = new System.Drawing.Size(158, 48);
            this.btnDeleteDelivery.TabIndex = 7;
            this.btnDeleteDelivery.Text = "Delete Delivery";
            this.btnDeleteDelivery.UseVisualStyleBackColor = true;
            this.btnDeleteDelivery.Click += new System.EventHandler(this.btnDeleteDelivery_Click);
            // 
            // CouriersPieChart
            // 
            this.CouriersPieChart.Location = new System.Drawing.Point(687, 618);
            this.CouriersPieChart.Name = "CouriersPieChart";
            this.CouriersPieChart.Size = new System.Drawing.Size(133, 51);
            this.CouriersPieChart.TabIndex = 8;
            this.CouriersPieChart.Text = "Couriers Pie Chart";
            this.CouriersPieChart.UseVisualStyleBackColor = true;
            this.CouriersPieChart.Click += new System.EventHandler(this.CouriersPieChart_Click);
            // 
            // CouriersBarChart
            // 
            this.CouriersBarChart.Location = new System.Drawing.Point(826, 618);
            this.CouriersBarChart.Name = "CouriersBarChart";
            this.CouriersBarChart.Size = new System.Drawing.Size(131, 51);
            this.CouriersBarChart.TabIndex = 9;
            this.CouriersBarChart.Text = "Couriers Bar Chart";
            this.CouriersBarChart.UseVisualStyleBackColor = true;
            this.CouriersBarChart.Click += new System.EventHandler(this.CouriersBarChart_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 778);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdClient;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantities;
        private System.Windows.Forms.DataGridViewTextBoxColumn Products;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn delLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalValue;
        private System.Windows.Forms.Button CouriersPieChart;
        private System.Windows.Forms.Button CouriersBarChart;
    }
}
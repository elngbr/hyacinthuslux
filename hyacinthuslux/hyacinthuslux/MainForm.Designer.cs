﻿namespace hyacinthuslux
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDeleteDelivery = new System.Windows.Forms.Button();
            this.ClientName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryMethod = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeliveryDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // addDeliveryBtn
            // 
            this.addDeliveryBtn.Location = new System.Drawing.Point(511, 637);
            this.addDeliveryBtn.Name = "addDeliveryBtn";
            this.addDeliveryBtn.Size = new System.Drawing.Size(167, 51);
            this.addDeliveryBtn.TabIndex = 2;
            this.addDeliveryBtn.Text = "Add &Delivery";
            this.addDeliveryBtn.UseVisualStyleBackColor = true;
            this.addDeliveryBtn.Click += new System.EventHandler(this.addDeliveryBtn_Click);
            // 
            // addClientBtn
            // 
            this.addClientBtn.Location = new System.Drawing.Point(140, 638);
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.Size = new System.Drawing.Size(170, 51);
            this.addClientBtn.TabIndex = 4;
            this.addClientBtn.Text = "Add &Client";
            this.addClientBtn.UseVisualStyleBackColor = true;
            this.addClientBtn.Click += new System.EventHandler(this.addClientBtn_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(694, 637);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(156, 51);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "Add &Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClientName,
            this.DeliveryMethod,
            this.DeliveryDate,
            this.delLocation,
            this.totalValue});
            this.dataGridView1.Location = new System.Drawing.Point(48, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(986, 567);
            this.dataGridView1.TabIndex = 6;
            // 
            // btnDeleteDelivery
            // 
            this.btnDeleteDelivery.Location = new System.Drawing.Point(332, 638);
            this.btnDeleteDelivery.Name = "btnDeleteDelivery";
            this.btnDeleteDelivery.Size = new System.Drawing.Size(158, 48);
            this.btnDeleteDelivery.TabIndex = 7;
            this.btnDeleteDelivery.Text = "Delete Delivery";
            this.btnDeleteDelivery.UseVisualStyleBackColor = true;
            // 
            // ClientName
            // 
            this.ClientName.HeaderText = "ClientName";
            this.ClientName.MinimumWidth = 6;
            this.ClientName.Name = "ClientName";
            this.ClientName.Width = 150;
            // 
            // DeliveryMethod
            // 
            this.DeliveryMethod.HeaderText = "Delivery Method";
            this.DeliveryMethod.MinimumWidth = 6;
            this.DeliveryMethod.Name = "DeliveryMethod";
            this.DeliveryMethod.Width = 125;
            // 
            // DeliveryDate
            // 
            this.DeliveryDate.HeaderText = "DeliveryDate";
            this.DeliveryDate.MinimumWidth = 6;
            this.DeliveryDate.Name = "DeliveryDate";
            this.DeliveryDate.Width = 150;
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
            this.totalValue.Width = 125;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1079, 778);
            this.Controls.Add(this.btnDeleteDelivery);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.addClientBtn);
            this.Controls.Add(this.addDeliveryBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addDeliveryBtn;
        private System.Windows.Forms.Button addClientBtn;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDeleteDelivery;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClientName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryMethod;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn delLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalValue;
    }
}
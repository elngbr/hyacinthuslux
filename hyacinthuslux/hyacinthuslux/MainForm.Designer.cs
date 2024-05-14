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
            this.listView1 = new System.Windows.Forms.ListView();
            this.addClientBtn = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addDeliveryBtn
            // 
            this.addDeliveryBtn.Location = new System.Drawing.Point(499, 522);
            this.addDeliveryBtn.Name = "addDeliveryBtn";
            this.addDeliveryBtn.Size = new System.Drawing.Size(167, 51);
            this.addDeliveryBtn.TabIndex = 2;
            this.addDeliveryBtn.Text = "Add &Delivery";
            this.addDeliveryBtn.UseVisualStyleBackColor = true;
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(39, 28);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(1109, 400);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // addClientBtn
            // 
            this.addClientBtn.Location = new System.Drawing.Point(98, 522);
            this.addClientBtn.Name = "addClientBtn";
            this.addClientBtn.Size = new System.Drawing.Size(170, 51);
            this.addClientBtn.TabIndex = 4;
            this.addClientBtn.Text = "Add &Client";
            this.addClientBtn.UseVisualStyleBackColor = true;
            this.addClientBtn.Click += new System.EventHandler(this.addClientBtn_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(877, 522);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(156, 51);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "Add &Product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 778);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.addClientBtn);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.addDeliveryBtn);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button addDeliveryBtn;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button addClientBtn;
        private System.Windows.Forms.Button btnAddProduct;
    }
}
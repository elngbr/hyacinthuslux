namespace hyacinthuslux
{
    partial class Delivery_Form
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
            this.comboBoxClients = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpDeliveryDate = new System.Windows.Forms.DateTimePicker();
            this.tbLocationDel = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxProducts = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.numQuantity = new System.Windows.Forms.NumericUpDown();
            this.dgvProductsForAnOrder = new System.Windows.Forms.DataGridView();
            this.Product = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Quantity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonDeleteProd = new System.Windows.Forms.Button();
            this.buttonSaveOrder = new System.Windows.Forms.Button();
            this.btnAddProdOrder = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonOk = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsForAnOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(107, 77);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(200, 24);
            this.comboBoxClients.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Client";
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(107, 124);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDeliveryDate.TabIndex = 6;
            // 
            // tbLocationDel
            // 
            this.tbLocationDel.Location = new System.Drawing.Point(107, 164);
            this.tbLocationDel.Name = "tbLocationDel";
            this.tbLocationDel.Size = new System.Drawing.Size(200, 22);
            this.tbLocationDel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Delivery Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Location";
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(448, 12);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(200, 24);
            this.comboBoxProducts.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Choose Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(337, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Choose Quantity";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(448, 49);
            this.numQuantity.Name = "numQuantity";
            this.numQuantity.Size = new System.Drawing.Size(120, 22);
            this.numQuantity.TabIndex = 15;
            // 
            // dgvProductsForAnOrder
            // 
            this.dgvProductsForAnOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductsForAnOrder.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Product,
            this.Quantity});
            this.dgvProductsForAnOrder.Location = new System.Drawing.Point(342, 77);
            this.dgvProductsForAnOrder.Name = "dgvProductsForAnOrder";
            this.dgvProductsForAnOrder.RowHeadersWidth = 51;
            this.dgvProductsForAnOrder.RowTemplate.Height = 24;
            this.dgvProductsForAnOrder.Size = new System.Drawing.Size(507, 420);
            this.dgvProductsForAnOrder.TabIndex = 16;
            this.dgvProductsForAnOrder.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductsForAnOrder_CellDoubleClick);
            // 
            // Product
            // 
            this.Product.HeaderText = "Product";
            this.Product.MinimumWidth = 6;
            this.Product.Name = "Product";
            this.Product.Width = 200;
            // 
            // Quantity
            // 
            this.Quantity.HeaderText = "Quantity";
            this.Quantity.MinimumWidth = 6;
            this.Quantity.Name = "Quantity";
            this.Quantity.Width = 125;
            // 
            // buttonDeleteProd
            // 
            this.buttonDeleteProd.Location = new System.Drawing.Point(342, 503);
            this.buttonDeleteProd.Name = "buttonDeleteProd";
            this.buttonDeleteProd.Size = new System.Drawing.Size(122, 48);
            this.buttonDeleteProd.TabIndex = 17;
            this.buttonDeleteProd.Text = "Delete ProdOrder";
            this.buttonDeleteProd.UseVisualStyleBackColor = true;
            // 
            // buttonSaveOrder
            // 
            this.buttonSaveOrder.Location = new System.Drawing.Point(470, 503);
            this.buttonSaveOrder.Name = "buttonSaveOrder";
            this.buttonSaveOrder.Size = new System.Drawing.Size(134, 48);
            this.buttonSaveOrder.TabIndex = 18;
            this.buttonSaveOrder.Text = "Save ProdOrder";
            this.buttonSaveOrder.UseVisualStyleBackColor = true;
            this.buttonSaveOrder.Click += new System.EventHandler(this.buttonSaveOrder_Click);
            // 
            // btnAddProdOrder
            // 
            this.btnAddProdOrder.Location = new System.Drawing.Point(610, 503);
            this.btnAddProdOrder.Name = "btnAddProdOrder";
            this.btnAddProdOrder.Size = new System.Drawing.Size(156, 48);
            this.btnAddProdOrder.TabIndex = 19;
            this.btnAddProdOrder.Text = "Add ProdOrder";
            this.btnAddProdOrder.UseVisualStyleBackColor = true;
            this.btnAddProdOrder.Click += new System.EventHandler(this.btnAddProdOrder_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(84, 593);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(235, 114);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(366, 593);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(238, 118);
            this.buttonOk.TabIndex = 21;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            // 
            // Delivery_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 719);
            this.Controls.Add(this.buttonOk);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.btnAddProdOrder);
            this.Controls.Add(this.buttonSaveOrder);
            this.Controls.Add(this.buttonDeleteProd);
            this.Controls.Add(this.dgvProductsForAnOrder);
            this.Controls.Add(this.numQuantity);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.comboBoxProducts);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbLocationDel);
            this.Controls.Add(this.dtpDeliveryDate);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBoxClients);
            this.Name = "Delivery_Form";
            this.Text = "Delivery_Form";
            this.Load += new System.EventHandler(this.Delivery_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsForAnOrder)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBoxClients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpDeliveryDate;
        private System.Windows.Forms.TextBox tbLocationDel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxProducts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown numQuantity;
        private System.Windows.Forms.DataGridView dgvProductsForAnOrder;
        private System.Windows.Forms.DataGridViewTextBoxColumn Product;
        private System.Windows.Forms.DataGridViewTextBoxColumn Quantity;
        private System.Windows.Forms.Button buttonDeleteProd;
        private System.Windows.Forms.Button buttonSaveOrder;
        private System.Windows.Forms.Button btnAddProdOrder;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonOk;
    }
}
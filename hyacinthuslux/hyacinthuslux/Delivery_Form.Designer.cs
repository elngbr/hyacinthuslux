﻿namespace hyacinthuslux
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
            this.tbTotal = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lbdeliveryMethod = new System.Windows.Forms.Label();
            this.comboBoxCourierMethod = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbDeliveryCost = new System.Windows.Forms.TextBox();
            this.tbSubtotal = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductsForAnOrder)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBoxClients
            // 
            this.comboBoxClients.FormattingEnabled = true;
            this.comboBoxClients.Location = new System.Drawing.Point(125, 9);
            this.comboBoxClients.Name = "comboBoxClients";
            this.comboBoxClients.Size = new System.Drawing.Size(200, 24);
            this.comboBoxClients.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Client";
            // 
            // dtpDeliveryDate
            // 
            this.dtpDeliveryDate.Location = new System.Drawing.Point(125, 51);
            this.dtpDeliveryDate.Name = "dtpDeliveryDate";
            this.dtpDeliveryDate.Size = new System.Drawing.Size(200, 22);
            this.dtpDeliveryDate.TabIndex = 6;
            // 
            // tbLocationDel
            // 
            this.tbLocationDel.Location = new System.Drawing.Point(125, 93);
            this.tbLocationDel.Name = "tbLocationDel";
            this.tbLocationDel.Size = new System.Drawing.Size(200, 22);
            this.tbLocationDel.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 51);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Delivery Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 16);
            this.label3.TabIndex = 9;
            this.label3.Text = "Location";
            // 
            // comboBoxProducts
            // 
            this.comboBoxProducts.FormattingEnabled = true;
            this.comboBoxProducts.Location = new System.Drawing.Point(25, 335);
            this.comboBoxProducts.Name = "comboBoxProducts";
            this.comboBoxProducts.Size = new System.Drawing.Size(200, 24);
            this.comboBoxProducts.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(66, 316);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Choose Product";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(237, 318);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 16);
            this.label5.TabIndex = 14;
            this.label5.Text = "Choose Quantity";
            // 
            // numQuantity
            // 
            this.numQuantity.Location = new System.Drawing.Point(240, 337);
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
            this.dgvProductsForAnOrder.Location = new System.Drawing.Point(366, 12);
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
            this.buttonDeleteProd.Location = new System.Drawing.Point(411, 438);
            this.buttonDeleteProd.Name = "buttonDeleteProd";
            this.buttonDeleteProd.Size = new System.Drawing.Size(122, 48);
            this.buttonDeleteProd.TabIndex = 17;
            this.buttonDeleteProd.Text = "Delete ProdOrder";
            this.buttonDeleteProd.UseVisualStyleBackColor = true;
            this.buttonDeleteProd.Click += new System.EventHandler(this.buttonDeleteProd_Click);
            // 
            // buttonSaveOrder
            // 
            this.buttonSaveOrder.Location = new System.Drawing.Point(539, 438);
            this.buttonSaveOrder.Name = "buttonSaveOrder";
            this.buttonSaveOrder.Size = new System.Drawing.Size(134, 48);
            this.buttonSaveOrder.TabIndex = 18;
            this.buttonSaveOrder.Text = "Save ProdOrder";
            this.buttonSaveOrder.UseVisualStyleBackColor = true;
            this.buttonSaveOrder.Click += new System.EventHandler(this.buttonSaveOrder_Click);
            // 
            // btnAddProdOrder
            // 
            this.btnAddProdOrder.Location = new System.Drawing.Point(679, 438);
            this.btnAddProdOrder.Name = "btnAddProdOrder";
            this.btnAddProdOrder.Size = new System.Drawing.Size(156, 48);
            this.btnAddProdOrder.TabIndex = 19;
            this.btnAddProdOrder.Text = "Add ProdOrder";
            this.btnAddProdOrder.UseVisualStyleBackColor = true;
            this.btnAddProdOrder.Click += new System.EventHandler(this.btnAddProdOrder_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(341, 597);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(235, 114);
            this.buttonCancel.TabIndex = 20;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(606, 593);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(238, 118);
            this.buttonOk.TabIndex = 21;
            this.buttonOk.Text = "Ok";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonOk_Click);
            // 
            // tbTotal
            // 
            this.tbTotal.Location = new System.Drawing.Point(107, 641);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.ReadOnly = true;
            this.tbTotal.Size = new System.Drawing.Size(133, 22);
            this.tbTotal.TabIndex = 22;
            this.tbTotal.TextChanged += new System.EventHandler(this.tbTotal_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 647);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 16);
            this.label6.TabIndex = 23;
            this.label6.Text = "total Value";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // lbdeliveryMethod
            // 
            this.lbdeliveryMethod.AutoSize = true;
            this.lbdeliveryMethod.Location = new System.Drawing.Point(-2, 132);
            this.lbdeliveryMethod.Name = "lbdeliveryMethod";
            this.lbdeliveryMethod.Size = new System.Drawing.Size(103, 16);
            this.lbdeliveryMethod.TabIndex = 24;
            this.lbdeliveryMethod.Text = "delivery Method";
            // 
            // comboBoxCourierMethod
            // 
            this.comboBoxCourierMethod.FormattingEnabled = true;
            this.comboBoxCourierMethod.Location = new System.Drawing.Point(125, 124);
            this.comboBoxCourierMethod.Name = "comboBoxCourierMethod";
            this.comboBoxCourierMethod.Size = new System.Drawing.Size(200, 24);
            this.comboBoxCourierMethod.TabIndex = 25;
            this.comboBoxCourierMethod.SelectedIndexChanged += new System.EventHandler(this.comboBoxCourierMethod_SelectedIndexChanged_1);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.label7.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(22, 282);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 15);
            this.label7.TabIndex = 26;
            this.label7.Text = "Choose your products :)";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // tbDeliveryCost
            // 
            this.tbDeliveryCost.Location = new System.Drawing.Point(107, 551);
            this.tbDeliveryCost.Name = "tbDeliveryCost";
            this.tbDeliveryCost.ReadOnly = true;
            this.tbDeliveryCost.Size = new System.Drawing.Size(133, 22);
            this.tbDeliveryCost.TabIndex = 27;
            this.tbDeliveryCost.TextChanged += new System.EventHandler(this.tbDeliveryCost_TextChanged);
            // 
            // tbSubtotal
            // 
            this.tbSubtotal.Location = new System.Drawing.Point(107, 597);
            this.tbSubtotal.Name = "tbSubtotal";
            this.tbSubtotal.ReadOnly = true;
            this.tbSubtotal.Size = new System.Drawing.Size(133, 22);
            this.tbSubtotal.TabIndex = 28;
            this.tbSubtotal.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 554);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(85, 16);
            this.label8.TabIndex = 29;
            this.label8.Text = "delivery Cost";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(36, 600);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(56, 16);
            this.label9.TabIndex = 30;
            this.label9.Text = "Subtotal";
            // 
            // Delivery_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 719);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbSubtotal);
            this.Controls.Add(this.tbDeliveryCost);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.comboBoxCourierMethod);
            this.Controls.Add(this.lbdeliveryMethod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbTotal);
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
        private System.Windows.Forms.TextBox tbTotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lbdeliveryMethod;
        private System.Windows.Forms.ComboBox comboBoxCourierMethod;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbDeliveryCost;
        private System.Windows.Forms.TextBox tbSubtotal;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}
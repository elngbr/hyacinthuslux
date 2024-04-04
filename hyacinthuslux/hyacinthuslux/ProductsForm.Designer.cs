namespace hyacinthuslux
{
    partial class ProductsForm
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
            this.components = new System.ComponentModel.Container();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxPrice = new System.Windows.Forms.TextBox();
            this.textBoxStock = new System.Windows.Forms.TextBox();
            this.labelPrice = new System.Windows.Forms.Label();
            this.labelName = new System.Windows.Forms.Label();
            this.labelFlowerType = new System.Windows.Forms.Label();
            this.labelProductStock = new System.Windows.Forms.Label();
            this.comboBoxFlowerEnum = new System.Windows.Forms.ComboBox();
            this.listViewProducts = new System.Windows.Forms.ListView();
            this.NameProduct = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Availability = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonSaveProduct = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.checkBoxAvailability = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource5)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(130, 59);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(100, 22);
            this.textBoxName.TabIndex = 0;
            // 
            // textBoxPrice
            // 
            this.textBoxPrice.Location = new System.Drawing.Point(130, 104);
            this.textBoxPrice.Name = "textBoxPrice";
            this.textBoxPrice.Size = new System.Drawing.Size(100, 22);
            this.textBoxPrice.TabIndex = 1;
            // 
            // textBoxStock
            // 
            this.textBoxStock.Location = new System.Drawing.Point(130, 150);
            this.textBoxStock.Name = "textBoxStock";
            this.textBoxStock.Size = new System.Drawing.Size(100, 22);
            this.textBoxStock.TabIndex = 4;
            // 
            // labelPrice
            // 
            this.labelPrice.AutoSize = true;
            this.labelPrice.BackColor = System.Drawing.Color.DarkViolet;
            this.labelPrice.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPrice.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.labelPrice.Location = new System.Drawing.Point(38, 104);
            this.labelPrice.Name = "labelPrice";
            this.labelPrice.Size = new System.Drawing.Size(52, 22);
            this.labelPrice.TabIndex = 5;
            this.labelPrice.Text = "Price";
            //this.labelPrice.Click += new System.EventHandler(this.labelPrice_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.BackColor = System.Drawing.Color.DarkViolet;
            this.labelName.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelName.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.labelName.Location = new System.Drawing.Point(37, 58);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(56, 22);
            this.labelName.TabIndex = 6;
            this.labelName.Text = "Name";
            // 
            // labelFlowerType
            // 
            this.labelFlowerType.AutoSize = true;
            this.labelFlowerType.Location = new System.Drawing.Point(517, 65);
            this.labelFlowerType.Name = "labelFlowerType";
            this.labelFlowerType.Size = new System.Drawing.Size(82, 16);
            this.labelFlowerType.TabIndex = 8;
            this.labelFlowerType.Text = "Flower Type";
            // 
            // labelProductStock
            // 
            this.labelProductStock.AutoSize = true;
            this.labelProductStock.Location = new System.Drawing.Point(22, 153);
            this.labelProductStock.Name = "labelProductStock";
            this.labelProductStock.Size = new System.Drawing.Size(90, 16);
            this.labelProductStock.TabIndex = 9;
            this.labelProductStock.Text = "Product Stock";
            // 
            // comboBoxFlowerEnum
            // 
            this.comboBoxFlowerEnum.FormattingEnabled = true;
            this.comboBoxFlowerEnum.Location = new System.Drawing.Point(622, 62);
            this.comboBoxFlowerEnum.Name = "comboBoxFlowerEnum";
            this.comboBoxFlowerEnum.Size = new System.Drawing.Size(100, 24);
            this.comboBoxFlowerEnum.TabIndex = 10;
           // this.comboBoxFlowerEnum.SelectedIndexChanged += new System.EventHandler(this.comboBoxFlowerEnum_SelectedIndexChanged);
            // 
            // listViewProducts
            // 
            this.listViewProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.NameProduct,
            this.Price,
            this.Availability,
            this.Type,
            this.Stock});
            this.listViewProducts.HideSelection = false;
            this.listViewProducts.Location = new System.Drawing.Point(112, 234);
            this.listViewProducts.Name = "listViewProducts";
            this.listViewProducts.Size = new System.Drawing.Size(600, 204);
            this.listViewProducts.TabIndex = 11;
            this.listViewProducts.UseCompatibleStateImageBehavior = false;
            this.listViewProducts.View = System.Windows.Forms.View.Details;
            // 
            // NameProduct
            // 
            this.NameProduct.Text = "NameProduct";
            this.NameProduct.Width = 120;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            // 
            // Availability
            // 
            this.Availability.Text = "Availability";
            this.Availability.Width = 112;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            // 
            // Stock
            // 
            this.Stock.Text = "Stock";
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.Location = new System.Drawing.Point(112, 205);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(118, 23);
            this.buttonDeleteProduct.TabIndex = 12;
            this.buttonDeleteProduct.Text = "Delete Product";
            this.buttonDeleteProduct.UseVisualStyleBackColor = true;
            // 
            // buttonSaveProduct
            // 
            this.buttonSaveProduct.Location = new System.Drawing.Point(340, 205);
            this.buttonSaveProduct.Name = "buttonSaveProduct";
            this.buttonSaveProduct.Size = new System.Drawing.Size(132, 23);
            this.buttonSaveProduct.TabIndex = 13;
            this.buttonSaveProduct.Text = "Save Product";
            this.buttonSaveProduct.UseVisualStyleBackColor = true;
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.Location = new System.Drawing.Point(579, 205);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(130, 23);
            this.buttonAddProduct.TabIndex = 14;
            this.buttonAddProduct.Text = "Add Product";
            this.buttonAddProduct.UseVisualStyleBackColor = true;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // checkBoxAvailability
            // 
            this.checkBoxAvailability.AutoSize = true;
            this.checkBoxAvailability.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.checkBoxAvailability.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxAvailability.Location = new System.Drawing.Point(607, 117);
            this.checkBoxAvailability.Name = "checkBoxAvailability";
            this.checkBoxAvailability.Size = new System.Drawing.Size(127, 26);
            this.checkBoxAvailability.TabIndex = 15;
            this.checkBoxAvailability.Text = "Availability";
            this.checkBoxAvailability.UseVisualStyleBackColor = false;
            //this.checkBoxAvailability.CheckedChanged += new System.EventHandler(this.checkBoxAvailability_CheckedChanged);
            // 
            // ProductsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBoxAvailability);
            this.Controls.Add(this.buttonAddProduct);
            this.Controls.Add(this.buttonSaveProduct);
            this.Controls.Add(this.buttonDeleteProduct);
            this.Controls.Add(this.listViewProducts);
            this.Controls.Add(this.comboBoxFlowerEnum);
            this.Controls.Add(this.labelProductStock);
            this.Controls.Add(this.labelFlowerType);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.labelPrice);
            this.Controls.Add(this.textBoxStock);
            this.Controls.Add(this.textBoxPrice);
            this.Controls.Add(this.textBoxName);
            this.Name = "ProductsForm";
            this.Text = "ProductsForm";
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.BindingSource bindingSource2;
        private System.Windows.Forms.BindingSource bindingSource3;
        private System.Windows.Forms.BindingSource bindingSource4;
        private System.Windows.Forms.BindingSource bindingSource5;
        private System.Windows.Forms.TextBox textBoxPrice;
        private System.Windows.Forms.TextBox textBoxStock;
        private System.Windows.Forms.Label labelPrice;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelFlowerType;
        private System.Windows.Forms.Label labelProductStock;
        private System.Windows.Forms.ComboBox comboBoxFlowerEnum;
        private System.Windows.Forms.ListView listViewProducts;
        private System.Windows.Forms.ColumnHeader NameProduct;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Availability;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonSaveProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.CheckBox checkBoxAvailability;
    }
}
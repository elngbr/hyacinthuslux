namespace hyacinthuslux
{
    partial class Product_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Product_Form));
            this.lvProducts = new System.Windows.Forms.ListView();
            this.Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Price = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Stock = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Type = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Availability = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tbPrice = new System.Windows.Forms.TextBox();
            this.tbTitle = new System.Windows.Forms.TextBox();
            this.cbTypeFlower = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ckBAvailability = new System.Windows.Forms.CheckBox();
            this.numStock = new System.Windows.Forms.NumericUpDown();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.SerializeBinary = new System.Windows.Forms.ToolStripButton();
            this.DeserializeBinary = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.buttonPrintPreview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvProducts
            // 
            this.lvProducts.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Title,
            this.Price,
            this.Stock,
            this.Type,
            this.Availability});
            this.lvProducts.FullRowSelect = true;
            this.lvProducts.HideSelection = false;
            this.lvProducts.Location = new System.Drawing.Point(22, 88);
            this.lvProducts.Name = "lvProducts";
            this.lvProducts.Size = new System.Drawing.Size(763, 321);
            this.lvProducts.TabIndex = 0;
            this.lvProducts.UseCompatibleStateImageBehavior = false;
            this.lvProducts.View = System.Windows.Forms.View.Details;
            this.lvProducts.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvProducts_MouseDoubleClick);
            // 
            // Title
            // 
            this.Title.Text = "Title";
            this.Title.Width = 120;
            // 
            // Price
            // 
            this.Price.Text = "Price";
            this.Price.Width = 120;
            // 
            // Stock
            // 
            this.Stock.Text = "Stock";
            this.Stock.Width = 120;
            // 
            // Type
            // 
            this.Type.Text = "Type";
            this.Type.Width = 120;
            // 
            // Availability
            // 
            this.Availability.Text = "Availability";
            this.Availability.Width = 120;
            // 
            // tbPrice
            // 
            this.tbPrice.Location = new System.Drawing.Point(144, 464);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Size = new System.Drawing.Size(100, 22);
            this.tbPrice.TabIndex = 2;
            this.tbPrice.Validating += new System.ComponentModel.CancelEventHandler(this.tbPrice_Validating);
            // 
            // tbTitle
            // 
            this.tbTitle.Location = new System.Drawing.Point(144, 427);
            this.tbTitle.Name = "tbTitle";
            this.tbTitle.Size = new System.Drawing.Size(100, 22);
            this.tbTitle.TabIndex = 3;
            this.tbTitle.Validating += new System.ComponentModel.CancelEventHandler(this.tbTitle_Validating);
            // 
            // cbTypeFlower
            // 
            this.cbTypeFlower.FormattingEnabled = true;
            this.cbTypeFlower.Location = new System.Drawing.Point(392, 433);
            this.cbTypeFlower.Name = "cbTypeFlower";
            this.cbTypeFlower.Size = new System.Drawing.Size(121, 24);
            this.cbTypeFlower.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(78, 427);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 16);
            this.label1.TabIndex = 5;
            this.label1.Text = "Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 464);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Price";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(78, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Stock";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(333, 433);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Type";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(81, 556);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(114, 31);
            this.btnDeleteProduct.TabIndex = 10;
            this.btnDeleteProduct.Text = "&Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(252, 556);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(120, 31);
            this.btnSave.TabIndex = 11;
            this.btnSave.Text = "&Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(438, 556);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(120, 31);
            this.btnAdd.TabIndex = 12;
            this.btnAdd.Text = "&Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // ckBAvailability
            // 
            this.ckBAvailability.AutoSize = true;
            this.ckBAvailability.Location = new System.Drawing.Point(419, 483);
            this.ckBAvailability.Name = "ckBAvailability";
            this.ckBAvailability.Size = new System.Drawing.Size(94, 20);
            this.ckBAvailability.TabIndex = 13;
            this.ckBAvailability.Text = "Availability";
            this.ckBAvailability.UseVisualStyleBackColor = true;
            // 
            // numStock
            // 
            this.numStock.Location = new System.Drawing.Point(144, 503);
            this.numStock.Name = "numStock";
            this.numStock.Size = new System.Drawing.Size(120, 22);
            this.numStock.TabIndex = 14;
            this.numStock.Validating += new System.ComponentModel.CancelEventHandler(this.numStock_Validating);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.SerializeBinary,
            this.DeserializeBinary});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(869, 27);
            this.toolStrip1.TabIndex = 15;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // SerializeBinary
            // 
            this.SerializeBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SerializeBinary.Image = ((System.Drawing.Image)(resources.GetObject("SerializeBinary.Image")));
            this.SerializeBinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SerializeBinary.Name = "SerializeBinary";
            this.SerializeBinary.Size = new System.Drawing.Size(114, 24);
            this.SerializeBinary.Text = "Serialize Binary";
            this.SerializeBinary.Click += new System.EventHandler(this.SerializeBinary_Click);
            // 
            // DeserializeBinary
            // 
            this.DeserializeBinary.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.DeserializeBinary.Image = ((System.Drawing.Image)(resources.GetObject("DeserializeBinary.Image")));
            this.DeserializeBinary.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeserializeBinary.Name = "DeserializeBinary";
            this.DeserializeBinary.Size = new System.Drawing.Size(131, 24);
            this.DeserializeBinary.Text = "Deserialize Binary";
            this.DeserializeBinary.Click += new System.EventHandler(this.DeserializeBinary_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.statusStrip1.Location = new System.Drawing.Point(0, 693);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(869, 26);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(98, 20);
            this.toolStripStatusLabel1.Text = "Serialize XML";
            this.toolStripStatusLabel1.Click += new System.EventHandler(this.toolStripStatusLabel1_Click);
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(115, 20);
            this.toolStripStatusLabel2.Text = "Deserialize XML";
            this.toolStripStatusLabel2.Click += new System.EventHandler(this.toolStripStatusLabel2_Click);
            // 
            // buttonPrintPreview
            // 
            this.buttonPrintPreview.Location = new System.Drawing.Point(620, 556);
            this.buttonPrintPreview.Name = "buttonPrintPreview";
            this.buttonPrintPreview.Size = new System.Drawing.Size(124, 31);
            this.buttonPrintPreview.TabIndex = 17;
            this.buttonPrintPreview.Text = "Print Preview";
            this.buttonPrintPreview.UseVisualStyleBackColor = true;
            this.buttonPrintPreview.Click += new System.EventHandler(this.buttonPrintPreview_Click);
            // 
            // Product_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(869, 719);
            this.Controls.Add(this.buttonPrintPreview);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.numStock);
            this.Controls.Add(this.ckBAvailability);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbTypeFlower);
            this.Controls.Add(this.tbTitle);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.lvProducts);
            this.Name = "Product_Form";
            this.Text = "Product_Form";
            this.Load += new System.EventHandler(this.Product_Form_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Product_Form_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.numStock)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvProducts;
        private System.Windows.Forms.ColumnHeader Title;
        private System.Windows.Forms.ColumnHeader Price;
        private System.Windows.Forms.ColumnHeader Stock;
        private System.Windows.Forms.ColumnHeader Type;
        private System.Windows.Forms.ColumnHeader Availability;
        private System.Windows.Forms.TextBox tbPrice;
        private System.Windows.Forms.TextBox tbTitle;
        private System.Windows.Forms.ComboBox cbTypeFlower;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.CheckBox ckBAvailability;
        private System.Windows.Forms.NumericUpDown numStock;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton SerializeBinary;
        private System.Windows.Forms.ToolStripButton DeserializeBinary;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.Button buttonPrintPreview;
    }
}
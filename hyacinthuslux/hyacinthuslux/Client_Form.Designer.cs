﻿namespace hyacinthuslux
{
    partial class Client_Form
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
            this.tbFirstName = new System.Windows.Forms.TextBox();
            this.tbPhoneNumber = new System.Windows.Forms.TextBox();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.tbAddress = new System.Windows.Forms.TextBox();
            this.tbLastName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.numId = new System.Windows.Forms.NumericUpDown();
            this.numLoy = new System.Windows.Forms.NumericUpDown();
            this.bntAddClient = new System.Windows.Forms.Button();
            this.btnSaveClient = new System.Windows.Forms.Button();
            this.btnDeleteClient = new System.Windows.Forms.Button();
            this.lvClients = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LoyaltyPoints = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStripXML = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.serializeXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuBinClient = new System.Windows.Forms.ToolStripMenuItem();
            this.serializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deserializeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCopy = new System.Windows.Forms.Button();
            this.btnPaste = new System.Windows.Forms.Button();
            this.btnTXT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numId)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoy)).BeginInit();
            this.contextMenuStripXML.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbFirstName
            // 
            this.tbFirstName.Location = new System.Drawing.Point(136, 413);
            this.tbFirstName.Multiline = true;
            this.tbFirstName.Name = "tbFirstName";
            this.tbFirstName.Size = new System.Drawing.Size(144, 22);
            this.tbFirstName.TabIndex = 1;
            this.tbFirstName.TextChanged += new System.EventHandler(this.tbFirstName_TextChanged);
            this.tbFirstName.Validating += new System.ComponentModel.CancelEventHandler(this.tbFirstName_Validating);
            // 
            // tbPhoneNumber
            // 
            this.tbPhoneNumber.Location = new System.Drawing.Point(783, 458);
            this.tbPhoneNumber.Name = "tbPhoneNumber";
            this.tbPhoneNumber.Size = new System.Drawing.Size(152, 22);
            this.tbPhoneNumber.TabIndex = 5;
            this.tbPhoneNumber.DragDrop += new System.Windows.Forms.DragEventHandler(this.tbPhoneNumber_DragDrop);
            this.tbPhoneNumber.DragEnter += new System.Windows.Forms.DragEventHandler(this.tbPhoneNumber_DragEnter);
            this.tbPhoneNumber.MouseDown += new System.Windows.Forms.MouseEventHandler(this.tbPhoneNumber_MouseDown);
            this.tbPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.tbPhoneNumber_Validating);
            // 
            // tbEmail
            // 
            this.tbEmail.Location = new System.Drawing.Point(783, 419);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(152, 22);
            this.tbEmail.TabIndex = 3;
            this.tbEmail.Validating += new System.ComponentModel.CancelEventHandler(this.tbEmail_Validating);
            // 
            // tbAddress
            // 
            this.tbAddress.Location = new System.Drawing.Point(317, 549);
            this.tbAddress.Name = "tbAddress";
            this.tbAddress.Size = new System.Drawing.Size(447, 22);
            this.tbAddress.TabIndex = 4;
            this.tbAddress.TextChanged += new System.EventHandler(this.tbAddress_TextChanged);
            this.tbAddress.Validating += new System.ComponentModel.CancelEventHandler(this.tbAddress_Validating);
            // 
            // tbLastName
            // 
            this.tbLastName.Location = new System.Drawing.Point(136, 455);
            this.tbLastName.Name = "tbLastName";
            this.tbLastName.Size = new System.Drawing.Size(144, 22);
            this.tbLastName.TabIndex = 2;
            this.tbLastName.TextChanged += new System.EventHandler(this.tbLastName_TextChanged);
            this.tbLastName.Validating += new System.ComponentModel.CancelEventHandler(this.tbLastName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 416);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 461);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(717, 419);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 10;
            this.label4.Text = "email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(244, 549);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 11;
            this.label5.Text = "address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(667, 455);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(97, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Phone Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(667, 500);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 16);
            this.label7.TabIndex = 13;
            this.label7.Text = "Loyalty Points";
            // 
            // numId
            // 
            this.numId.Location = new System.Drawing.Point(136, 504);
            this.numId.Name = "numId";
            this.numId.Size = new System.Drawing.Size(144, 22);
            this.numId.TabIndex = 0;
            this.numId.ValueChanged += new System.EventHandler(this.numId_ValueChanged);
            this.numId.Validating += new System.ComponentModel.CancelEventHandler(this.numId_Validating);
            // 
            // numLoy
            // 
            this.numLoy.Location = new System.Drawing.Point(783, 500);
            this.numLoy.Name = "numLoy";
            this.numLoy.Size = new System.Drawing.Size(152, 22);
            this.numLoy.TabIndex = 6;
            this.numLoy.ValueChanged += new System.EventHandler(this.numLoy_ValueChanged);
            this.numLoy.Validating += new System.ComponentModel.CancelEventHandler(this.numLoy_Validating);
            // 
            // bntAddClient
            // 
            this.bntAddClient.BackColor = System.Drawing.Color.MediumOrchid;
            this.bntAddClient.Location = new System.Drawing.Point(84, 616);
            this.bntAddClient.Name = "bntAddClient";
            this.bntAddClient.Size = new System.Drawing.Size(196, 85);
            this.bntAddClient.TabIndex = 16;
            this.bntAddClient.Text = "&Add";
            this.bntAddClient.UseVisualStyleBackColor = false;
            this.bntAddClient.Click += new System.EventHandler(this.bntAdd_Click);
            // 
            // btnSaveClient
            // 
            this.btnSaveClient.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnSaveClient.Location = new System.Drawing.Point(286, 616);
            this.btnSaveClient.Name = "btnSaveClient";
            this.btnSaveClient.Size = new System.Drawing.Size(180, 85);
            this.btnSaveClient.TabIndex = 17;
            this.btnSaveClient.Text = "&Save";
            this.btnSaveClient.UseVisualStyleBackColor = false;
            this.btnSaveClient.Click += new System.EventHandler(this.btnSaveClient_Click);
            // 
            // btnDeleteClient
            // 
            this.btnDeleteClient.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnDeleteClient.Location = new System.Drawing.Point(642, 616);
            this.btnDeleteClient.Name = "btnDeleteClient";
            this.btnDeleteClient.Size = new System.Drawing.Size(182, 85);
            this.btnDeleteClient.TabIndex = 18;
            this.btnDeleteClient.Text = "&Delete";
            this.btnDeleteClient.UseVisualStyleBackColor = false;
            this.btnDeleteClient.Click += new System.EventHandler(this.btnDeleteClient_Click);
            // 
            // lvClients
            // 
            this.lvClients.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.FirstName,
            this.LastName,
            this.email,
            this.Address,
            this.Phone,
            this.LoyaltyPoints});
            this.lvClients.ContextMenuStrip = this.contextMenuStripXML;
            this.lvClients.Font = new System.Drawing.Font("Times New Roman", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lvClients.FullRowSelect = true;
            this.lvClients.HideSelection = false;
            this.lvClients.Location = new System.Drawing.Point(12, 88);
            this.lvClients.Name = "lvClients";
            this.lvClients.Size = new System.Drawing.Size(1156, 304);
            this.lvClients.TabIndex = 19;
            this.lvClients.UseCompatibleStateImageBehavior = false;
            this.lvClients.View = System.Windows.Forms.View.Details;
            this.lvClients.SelectedIndexChanged += new System.EventHandler(this.lvClients_SelectedIndexChanged);
            this.lvClients.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lvClients_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "ID";
            // 
            // FirstName
            // 
            this.FirstName.Text = "FirstName";
            this.FirstName.Width = 120;
            // 
            // LastName
            // 
            this.LastName.Text = "LastName";
            this.LastName.Width = 120;
            // 
            // email
            // 
            this.email.Text = "email";
            this.email.Width = 120;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 200;
            // 
            // Phone
            // 
            this.Phone.Text = "Phone";
            this.Phone.Width = 120;
            // 
            // LoyaltyPoints
            // 
            this.LoyaltyPoints.Text = "LoyaltyPoints";
            this.LoyaltyPoints.Width = 120;
            // 
            // contextMenuStripXML
            // 
            this.contextMenuStripXML.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStripXML.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeXMLToolStripMenuItem,
            this.deserializeXMLToolStripMenuItem});
            this.contextMenuStripXML.Name = "contextMenuStrip1";
            this.contextMenuStripXML.Size = new System.Drawing.Size(185, 52);
            this.contextMenuStripXML.TabStop = true;
            this.contextMenuStripXML.Text = "Serialize XML";
            this.contextMenuStripXML.UseWaitCursor = true;
            this.contextMenuStripXML.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStripXML_Opening);
            // 
            // serializeXMLToolStripMenuItem
            // 
            this.serializeXMLToolStripMenuItem.Name = "serializeXMLToolStripMenuItem";
            this.serializeXMLToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.serializeXMLToolStripMenuItem.Text = "Serialize XML";
            this.serializeXMLToolStripMenuItem.Click += new System.EventHandler(this.serializeXMLToolStripMenuItem_Click);
            // 
            // deserializeXMLToolStripMenuItem
            // 
            this.deserializeXMLToolStripMenuItem.Name = "deserializeXMLToolStripMenuItem";
            this.deserializeXMLToolStripMenuItem.Size = new System.Drawing.Size(184, 24);
            this.deserializeXMLToolStripMenuItem.Text = "Deserialize XML";
            this.deserializeXMLToolStripMenuItem.Click += new System.EventHandler(this.deserializeXMLToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuBinClient});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1180, 28);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuBinClient
            // 
            this.toolStripMenuBinClient.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.serializeToolStripMenuItem,
            this.deserializeToolStripMenuItem});
            this.toolStripMenuBinClient.Name = "toolStripMenuBinClient";
            this.toolStripMenuBinClient.Size = new System.Drawing.Size(124, 24);
            this.toolStripMenuBinClient.Text = "Serialize Binary";
            // 
            // serializeToolStripMenuItem
            // 
            this.serializeToolStripMenuItem.Name = "serializeToolStripMenuItem";
            this.serializeToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.serializeToolStripMenuItem.Text = "Serialize";
            this.serializeToolStripMenuItem.Click += new System.EventHandler(this.serializeToolStripMenuItem_Click);
            // 
            // deserializeToolStripMenuItem
            // 
            this.deserializeToolStripMenuItem.Name = "deserializeToolStripMenuItem";
            this.deserializeToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.deserializeToolStripMenuItem.Text = "Deserialize";
            this.deserializeToolStripMenuItem.Click += new System.EventHandler(this.deserializeToolStripMenuItem_Click);
            // 
            // btnCopy
            // 
            this.btnCopy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCopy.Location = new System.Drawing.Point(295, 413);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 28);
            this.btnCopy.TabIndex = 21;
            this.btnCopy.Text = "Copy";
            this.btnCopy.UseVisualStyleBackColor = false;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // btnPaste
            // 
            this.btnPaste.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnPaste.Location = new System.Drawing.Point(376, 413);
            this.btnPaste.Name = "btnPaste";
            this.btnPaste.Size = new System.Drawing.Size(75, 28);
            this.btnPaste.TabIndex = 22;
            this.btnPaste.Text = "Paste";
            this.btnPaste.UseVisualStyleBackColor = false;
            this.btnPaste.Click += new System.EventHandler(this.btnPaste_Click);
            // 
            // btnTXT
            // 
            this.btnTXT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnTXT.Location = new System.Drawing.Point(472, 616);
            this.btnTXT.Name = "btnTXT";
            this.btnTXT.Size = new System.Drawing.Size(164, 85);
            this.btnTXT.TabIndex = 23;
            this.btnTXT.Text = "Export as txt";
            this.btnTXT.UseVisualStyleBackColor = false;
            this.btnTXT.Click += new System.EventHandler(this.btnTXT_Click);
            // 
            // Client_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(1180, 724);
            this.ContextMenuStrip = this.contextMenuStripXML;
            this.Controls.Add(this.btnTXT);
            this.Controls.Add(this.btnPaste);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.lvClients);
            this.Controls.Add(this.btnDeleteClient);
            this.Controls.Add(this.btnSaveClient);
            this.Controls.Add(this.bntAddClient);
            this.Controls.Add(this.numLoy);
            this.Controls.Add(this.numId);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbLastName);
            this.Controls.Add(this.tbAddress);
            this.Controls.Add(this.tbEmail);
            this.Controls.Add(this.tbPhoneNumber);
            this.Controls.Add(this.tbFirstName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Client_Form";
            this.Text = "Client_Form";
            this.Load += new System.EventHandler(this.Client_Form_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numId)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numLoy)).EndInit();
            this.contextMenuStripXML.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbFirstName;
        private System.Windows.Forms.TextBox tbPhoneNumber;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.TextBox tbAddress;
        private System.Windows.Forms.TextBox tbLastName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown numId;
        private System.Windows.Forms.NumericUpDown numLoy;
        private System.Windows.Forms.Button bntAddClient;
        private System.Windows.Forms.Button btnSaveClient;
        private System.Windows.Forms.Button btnDeleteClient;
        private System.Windows.Forms.ListView lvClients;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ColumnHeader LoyaltyPoints;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuBinClient;
        private System.Windows.Forms.ToolStripMenuItem serializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serializeXMLToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deserializeXMLToolStripMenuItem;
        public System.Windows.Forms.ContextMenuStrip contextMenuStripXML;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Button btnPaste;
        private System.Windows.Forms.Button btnTXT;
    }
}
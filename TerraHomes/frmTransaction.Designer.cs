namespace TerraHomes
{
    partial class frmTransaction
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
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearAll = new Guna.UI2.WinForms.Guna2Button();
            this.txtPropertyPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPropertyId = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPropertyDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtPropertyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPropertyAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.dtpTransacDateTime = new Guna.UI2.WinForms.Guna2DateTimePicker();
            this.cbCustomers = new Guna.UI2.WinForms.Guna2ComboBox();
            this.txtCustAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCustLname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCustPhone = new Guna.UI2.WinForms.Guna2TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtCustEmail = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCustFname = new Guna.UI2.WinForms.Guna2TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.chbExisting = new Guna.UI2.WinForms.Guna2CheckBox();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSubmit
            // 
            this.btnSubmit.BorderRadius = 6;
            this.btnSubmit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmit.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(43)))));
            this.btnSubmit.Font = new System.Drawing.Font("Fredoka Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.Color.White;
            this.btnSubmit.Location = new System.Drawing.Point(698, 18);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(207, 31);
            this.btnSubmit.TabIndex = 67;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnClearAll
            // 
            this.btnClearAll.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(43)))));
            this.btnClearAll.BorderRadius = 6;
            this.btnClearAll.BorderThickness = 1;
            this.btnClearAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearAll.FillColor = System.Drawing.Color.Transparent;
            this.btnClearAll.Font = new System.Drawing.Font("Fredoka Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearAll.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(43)))));
            this.btnClearAll.Location = new System.Drawing.Point(478, 18);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(196, 31);
            this.btnClearAll.TabIndex = 66;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
            // 
            // txtPropertyPrice
            // 
            this.txtPropertyPrice.BackColor = System.Drawing.Color.Transparent;
            this.txtPropertyPrice.BorderColor = System.Drawing.Color.Black;
            this.txtPropertyPrice.BorderRadius = 6;
            this.txtPropertyPrice.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPropertyPrice.DefaultText = "";
            this.txtPropertyPrice.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPropertyPrice.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPropertyPrice.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPropertyPrice.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPropertyPrice.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPropertyPrice.Font = new System.Drawing.Font("Fredoka", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyPrice.ForeColor = System.Drawing.Color.Black;
            this.txtPropertyPrice.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPropertyPrice.Location = new System.Drawing.Point(312, 989);
            this.txtPropertyPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPropertyPrice.Name = "txtPropertyPrice";
            this.txtPropertyPrice.PasswordChar = '\0';
            this.txtPropertyPrice.PlaceholderText = "";
            this.txtPropertyPrice.ReadOnly = true;
            this.txtPropertyPrice.SelectedText = "";
            this.txtPropertyPrice.Size = new System.Drawing.Size(570, 45);
            this.txtPropertyPrice.TabIndex = 65;
            this.txtPropertyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Fredoka", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(231, 989);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 30);
            this.label10.TabIndex = 64;
            this.label10.Text = "Price:";
            // 
            // txtPropertyId
            // 
            this.txtPropertyId.BackColor = System.Drawing.Color.Transparent;
            this.txtPropertyId.BorderColor = System.Drawing.Color.Black;
            this.txtPropertyId.BorderRadius = 6;
            this.txtPropertyId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPropertyId.DefaultText = "";
            this.txtPropertyId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPropertyId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPropertyId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPropertyId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPropertyId.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPropertyId.Font = new System.Drawing.Font("Fredoka", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyId.ForeColor = System.Drawing.Color.Black;
            this.txtPropertyId.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPropertyId.Location = new System.Drawing.Point(313, 579);
            this.txtPropertyId.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPropertyId.Name = "txtPropertyId";
            this.txtPropertyId.PasswordChar = '\0';
            this.txtPropertyId.PlaceholderText = "";
            this.txtPropertyId.ReadOnly = true;
            this.txtPropertyId.SelectedText = "";
            this.txtPropertyId.Size = new System.Drawing.Size(570, 31);
            this.txtPropertyId.TabIndex = 62;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Fredoka", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(181, 579);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 20);
            this.label8.TabIndex = 63;
            this.label8.Text = "Property ID:";
            // 
            // txtPropertyDesc
            // 
            this.txtPropertyDesc.BackColor = System.Drawing.Color.Transparent;
            this.txtPropertyDesc.BorderColor = System.Drawing.Color.Black;
            this.txtPropertyDesc.BorderRadius = 6;
            this.txtPropertyDesc.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPropertyDesc.DefaultText = "";
            this.txtPropertyDesc.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPropertyDesc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPropertyDesc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPropertyDesc.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPropertyDesc.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPropertyDesc.Font = new System.Drawing.Font("Fredoka", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyDesc.ForeColor = System.Drawing.Color.Black;
            this.txtPropertyDesc.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPropertyDesc.Location = new System.Drawing.Point(313, 824);
            this.txtPropertyDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPropertyDesc.Multiline = true;
            this.txtPropertyDesc.Name = "txtPropertyDesc";
            this.txtPropertyDesc.PasswordChar = '\0';
            this.txtPropertyDesc.PlaceholderText = "";
            this.txtPropertyDesc.ReadOnly = true;
            this.txtPropertyDesc.SelectedText = "";
            this.txtPropertyDesc.Size = new System.Drawing.Size(570, 140);
            this.txtPropertyDesc.TabIndex = 60;
            // 
            // txtPropertyName
            // 
            this.txtPropertyName.BackColor = System.Drawing.Color.Transparent;
            this.txtPropertyName.BorderColor = System.Drawing.Color.Black;
            this.txtPropertyName.BorderRadius = 6;
            this.txtPropertyName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPropertyName.DefaultText = "";
            this.txtPropertyName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPropertyName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPropertyName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPropertyName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPropertyName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPropertyName.Font = new System.Drawing.Font("Fredoka", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyName.ForeColor = System.Drawing.Color.Black;
            this.txtPropertyName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPropertyName.Location = new System.Drawing.Point(313, 625);
            this.txtPropertyName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPropertyName.Name = "txtPropertyName";
            this.txtPropertyName.PasswordChar = '\0';
            this.txtPropertyName.PlaceholderText = "";
            this.txtPropertyName.ReadOnly = true;
            this.txtPropertyName.SelectedText = "";
            this.txtPropertyName.Size = new System.Drawing.Size(570, 31);
            this.txtPropertyName.TabIndex = 56;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fredoka", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 625);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 20);
            this.label2.TabIndex = 57;
            this.label2.Text = "Property Name:";
            // 
            // txtPropertyAddress
            // 
            this.txtPropertyAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtPropertyAddress.BorderColor = System.Drawing.Color.Black;
            this.txtPropertyAddress.BorderRadius = 6;
            this.txtPropertyAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPropertyAddress.DefaultText = "";
            this.txtPropertyAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPropertyAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPropertyAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPropertyAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPropertyAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPropertyAddress.Font = new System.Drawing.Font("Fredoka", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertyAddress.ForeColor = System.Drawing.Color.Black;
            this.txtPropertyAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPropertyAddress.Location = new System.Drawing.Point(313, 677);
            this.txtPropertyAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPropertyAddress.Multiline = true;
            this.txtPropertyAddress.Name = "txtPropertyAddress";
            this.txtPropertyAddress.PasswordChar = '\0';
            this.txtPropertyAddress.PlaceholderText = "";
            this.txtPropertyAddress.ReadOnly = true;
            this.txtPropertyAddress.SelectedText = "";
            this.txtPropertyAddress.Size = new System.Drawing.Size(570, 127);
            this.txtPropertyAddress.TabIndex = 58;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fredoka", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(235, 677);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 20);
            this.label3.TabIndex = 59;
            this.label3.Text = "Address:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Fredoka", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(208, 824);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 20);
            this.label4.TabIndex = 61;
            this.label4.Text = "Description:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fredoka Medium", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(118, 511);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 26);
            this.label1.TabIndex = 55;
            this.label1.Text = "Property Information";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 9;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.chbExisting);
            this.guna2Panel1.Controls.Add(this.dtpTransacDateTime);
            this.guna2Panel1.Controls.Add(this.cbCustomers);
            this.guna2Panel1.Controls.Add(this.txtCustAddress);
            this.guna2Panel1.Controls.Add(this.label12);
            this.guna2Panel1.Controls.Add(this.txtCustLname);
            this.guna2Panel1.Controls.Add(this.label11);
            this.guna2Panel1.Controls.Add(this.txtCustPhone);
            this.guna2Panel1.Controls.Add(this.label9);
            this.guna2Panel1.Controls.Add(this.txtCustEmail);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.txtCustFname);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(87, 78);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(818, 412);
            this.guna2Panel1.TabIndex = 54;
            // 
            // dtpTransacDateTime
            // 
            this.dtpTransacDateTime.BackColor = System.Drawing.Color.Transparent;
            this.dtpTransacDateTime.BorderRadius = 9;
            this.dtpTransacDateTime.Checked = true;
            this.dtpTransacDateTime.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.dtpTransacDateTime.Font = new System.Drawing.Font("Fredoka", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpTransacDateTime.ForeColor = System.Drawing.Color.White;
            this.dtpTransacDateTime.Format = System.Windows.Forms.DateTimePickerFormat.Long;
            this.dtpTransacDateTime.Location = new System.Drawing.Point(437, 343);
            this.dtpTransacDateTime.MaxDate = new System.DateTime(9998, 12, 31, 0, 0, 0, 0);
            this.dtpTransacDateTime.MinDate = new System.DateTime(1753, 1, 1, 0, 0, 0, 0);
            this.dtpTransacDateTime.Name = "dtpTransacDateTime";
            this.dtpTransacDateTime.Size = new System.Drawing.Size(321, 40);
            this.dtpTransacDateTime.TabIndex = 48;
            this.dtpTransacDateTime.Value = new System.DateTime(2023, 12, 9, 1, 57, 57, 39);
            // 
            // cbCustomers
            // 
            this.cbCustomers.BackColor = System.Drawing.Color.Transparent;
            this.cbCustomers.BorderRadius = 6;
            this.cbCustomers.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbCustomers.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbCustomers.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCustomers.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbCustomers.Font = new System.Drawing.Font("Fredoka", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbCustomers.ForeColor = System.Drawing.Color.Black;
            this.cbCustomers.ItemHeight = 30;
            this.cbCustomers.Location = new System.Drawing.Point(373, 26);
            this.cbCustomers.Name = "cbCustomers";
            this.cbCustomers.Size = new System.Drawing.Size(385, 36);
            this.cbCustomers.TabIndex = 47;
            this.cbCustomers.TextOffset = new System.Drawing.Point(10, 0);
            this.cbCustomers.SelectedIndexChanged += new System.EventHandler(this.cbCustomers_SelectedIndexChanged);
            // 
            // txtCustAddress
            // 
            this.txtCustAddress.BackColor = System.Drawing.Color.Transparent;
            this.txtCustAddress.BorderColor = System.Drawing.Color.Black;
            this.txtCustAddress.BorderRadius = 6;
            this.txtCustAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustAddress.DefaultText = "";
            this.txtCustAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustAddress.Font = new System.Drawing.Font("Fredoka", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustAddress.ForeColor = System.Drawing.Color.Black;
            this.txtCustAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustAddress.Location = new System.Drawing.Point(188, 287);
            this.txtCustAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustAddress.Name = "txtCustAddress";
            this.txtCustAddress.PasswordChar = '\0';
            this.txtCustAddress.PlaceholderText = "";
            this.txtCustAddress.SelectedText = "";
            this.txtCustAddress.Size = new System.Drawing.Size(570, 31);
            this.txtCustAddress.TabIndex = 45;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Fredoka", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(56, 287);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 46;
            this.label12.Text = "Address:";
            // 
            // txtCustLname
            // 
            this.txtCustLname.BackColor = System.Drawing.Color.Transparent;
            this.txtCustLname.BorderColor = System.Drawing.Color.Black;
            this.txtCustLname.BorderRadius = 6;
            this.txtCustLname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustLname.DefaultText = "";
            this.txtCustLname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustLname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustLname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustLname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustLname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustLname.Font = new System.Drawing.Font("Fredoka", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustLname.ForeColor = System.Drawing.Color.Black;
            this.txtCustLname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustLname.Location = new System.Drawing.Point(188, 133);
            this.txtCustLname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustLname.Name = "txtCustLname";
            this.txtCustLname.PasswordChar = '\0';
            this.txtCustLname.PlaceholderText = "";
            this.txtCustLname.SelectedText = "";
            this.txtCustLname.Size = new System.Drawing.Size(570, 31);
            this.txtCustLname.TabIndex = 43;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Fredoka", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(56, 133);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(84, 20);
            this.label11.TabIndex = 44;
            this.label11.Text = "Lastname:";
            // 
            // txtCustPhone
            // 
            this.txtCustPhone.BackColor = System.Drawing.Color.Transparent;
            this.txtCustPhone.BorderColor = System.Drawing.Color.Black;
            this.txtCustPhone.BorderRadius = 6;
            this.txtCustPhone.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustPhone.DefaultText = "";
            this.txtCustPhone.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustPhone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustPhone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustPhone.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustPhone.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustPhone.Font = new System.Drawing.Font("Fredoka", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustPhone.ForeColor = System.Drawing.Color.Black;
            this.txtCustPhone.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustPhone.Location = new System.Drawing.Point(188, 233);
            this.txtCustPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustPhone.Name = "txtCustPhone";
            this.txtCustPhone.PasswordChar = '\0';
            this.txtCustPhone.PlaceholderText = "";
            this.txtCustPhone.SelectedText = "";
            this.txtCustPhone.Size = new System.Drawing.Size(570, 31);
            this.txtCustPhone.TabIndex = 41;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Fredoka", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(56, 233);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 20);
            this.label9.TabIndex = 42;
            this.label9.Text = "Phone:";
            // 
            // txtCustEmail
            // 
            this.txtCustEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtCustEmail.BorderColor = System.Drawing.Color.Black;
            this.txtCustEmail.BorderRadius = 6;
            this.txtCustEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustEmail.DefaultText = "";
            this.txtCustEmail.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustEmail.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustEmail.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustEmail.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustEmail.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustEmail.Font = new System.Drawing.Font("Fredoka", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustEmail.ForeColor = System.Drawing.Color.Black;
            this.txtCustEmail.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustEmail.Location = new System.Drawing.Point(188, 183);
            this.txtCustEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustEmail.Name = "txtCustEmail";
            this.txtCustEmail.PasswordChar = '\0';
            this.txtCustEmail.PlaceholderText = "";
            this.txtCustEmail.SelectedText = "";
            this.txtCustEmail.Size = new System.Drawing.Size(570, 31);
            this.txtCustEmail.TabIndex = 39;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Fredoka", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 20);
            this.label7.TabIndex = 40;
            this.label7.Text = "Email:";
            // 
            // txtCustFname
            // 
            this.txtCustFname.BackColor = System.Drawing.Color.Transparent;
            this.txtCustFname.BorderColor = System.Drawing.Color.Black;
            this.txtCustFname.BorderRadius = 6;
            this.txtCustFname.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtCustFname.DefaultText = "";
            this.txtCustFname.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtCustFname.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtCustFname.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustFname.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtCustFname.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustFname.Font = new System.Drawing.Font("Fredoka", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustFname.ForeColor = System.Drawing.Color.Black;
            this.txtCustFname.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtCustFname.Location = new System.Drawing.Point(188, 83);
            this.txtCustFname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtCustFname.Name = "txtCustFname";
            this.txtCustFname.PasswordChar = '\0';
            this.txtCustFname.PlaceholderText = "";
            this.txtCustFname.SelectedText = "";
            this.txtCustFname.Size = new System.Drawing.Size(570, 31);
            this.txtCustFname.TabIndex = 37;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Fredoka", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(86, 20);
            this.label6.TabIndex = 38;
            this.label6.Text = "Firstname:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Fredoka", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(50, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(220, 26);
            this.label5.TabIndex = 2;
            this.label5.Text = "Customer Information";
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(52, 1056);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(831, 59);
            this.panel1.TabIndex = 68;
            // 
            // chbExisting
            // 
            this.chbExisting.AutoSize = true;
            this.chbExisting.BackColor = System.Drawing.Color.White;
            this.chbExisting.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.chbExisting.CheckedState.BorderRadius = 0;
            this.chbExisting.CheckedState.BorderThickness = 0;
            this.chbExisting.CheckedState.FillColor = System.Drawing.SystemColors.HotTrack;
            this.chbExisting.CheckMarkColor = System.Drawing.Color.Black;
            this.chbExisting.Font = new System.Drawing.Font("Fredoka Medium", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbExisting.Location = new System.Drawing.Point(295, 32);
            this.chbExisting.Name = "chbExisting";
            this.chbExisting.Size = new System.Drawing.Size(72, 20);
            this.chbExisting.TabIndex = 49;
            this.chbExisting.Text = "Existing";
            this.chbExisting.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbExisting.UncheckedState.BorderRadius = 0;
            this.chbExisting.UncheckedState.BorderThickness = 0;
            this.chbExisting.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.chbExisting.UseVisualStyleBackColor = false;
            this.chbExisting.CheckedChanged += new System.EventHandler(this.chbExisting_CheckedChanged);
            // 
            // frmTransaction
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(980, 575);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClearAll);
            this.Controls.Add(this.txtPropertyPrice);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtPropertyId);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtPropertyDesc);
            this.Controls.Add(this.txtPropertyName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPropertyAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "frmTransaction";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Transaction";
            this.Load += new System.EventHandler(this.frmTransaction_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2Button btnClearAll;
        public Guna.UI2.WinForms.Guna2TextBox txtPropertyPrice;
        private System.Windows.Forms.Label label10;
        public Guna.UI2.WinForms.Guna2TextBox txtPropertyId;
        private System.Windows.Forms.Label label8;
        public Guna.UI2.WinForms.Guna2TextBox txtPropertyDesc;
        public Guna.UI2.WinForms.Guna2TextBox txtPropertyName;
        private System.Windows.Forms.Label label2;
        public Guna.UI2.WinForms.Guna2TextBox txtPropertyAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2DateTimePicker dtpTransacDateTime;
        private Guna.UI2.WinForms.Guna2ComboBox cbCustomers;
        public Guna.UI2.WinForms.Guna2TextBox txtCustAddress;
        private System.Windows.Forms.Label label12;
        public Guna.UI2.WinForms.Guna2TextBox txtCustLname;
        private System.Windows.Forms.Label label11;
        public Guna.UI2.WinForms.Guna2TextBox txtCustPhone;
        private System.Windows.Forms.Label label9;
        public Guna.UI2.WinForms.Guna2TextBox txtCustEmail;
        private System.Windows.Forms.Label label7;
        public Guna.UI2.WinForms.Guna2TextBox txtCustFname;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2CheckBox chbExisting;
    }
}
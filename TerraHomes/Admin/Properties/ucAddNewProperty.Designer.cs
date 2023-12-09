namespace TerraHomes.Admin.Properties
{
    partial class ucAddNewProperty
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAddNewProperty));
            this.cbPropertyStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtPropertyName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPropertyAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPropertyDesc = new Guna.UI2.WinForms.Guna2TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbType = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPropertyPrice = new Guna.UI2.WinForms.Guna2TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPropertySize = new Guna.UI2.WinForms.Guna2TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddImage = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearImages = new Guna.UI2.WinForms.Guna2Button();
            this.btnClearAll = new Guna.UI2.WinForms.Guna2Button();
            this.btnSubmit = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbPropertyStatus
            // 
            this.cbPropertyStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbPropertyStatus.BorderRadius = 6;
            this.cbPropertyStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cbPropertyStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbPropertyStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbPropertyStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPropertyStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbPropertyStatus.Font = new System.Drawing.Font("Fredoka", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbPropertyStatus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbPropertyStatus.ItemHeight = 30;
            this.cbPropertyStatus.Items.AddRange(new object[] {
            "Available",
            "Rented",
            "Sold",
            "Pending",
            "Inactive"});
            this.cbPropertyStatus.Location = new System.Drawing.Point(145, 505);
            this.cbPropertyStatus.Name = "cbPropertyStatus";
            this.cbPropertyStatus.Size = new System.Drawing.Size(170, 36);
            this.cbPropertyStatus.StartIndex = 0;
            this.cbPropertyStatus.TabIndex = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(485, 154);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(470, 328);
            this.flowLayoutPanel1.TabIndex = 0;
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
            this.txtPropertyName.Location = new System.Drawing.Point(145, 87);
            this.txtPropertyName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPropertyName.Name = "txtPropertyName";
            this.txtPropertyName.PasswordChar = '\0';
            this.txtPropertyName.PlaceholderText = "";
            this.txtPropertyName.SelectedText = "";
            this.txtPropertyName.Size = new System.Drawing.Size(307, 31);
            this.txtPropertyName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fredoka", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(122, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Property Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fredoka", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(67, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Address:";
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
            this.txtPropertyAddress.Location = new System.Drawing.Point(145, 139);
            this.txtPropertyAddress.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPropertyAddress.Multiline = true;
            this.txtPropertyAddress.Name = "txtPropertyAddress";
            this.txtPropertyAddress.PasswordChar = '\0';
            this.txtPropertyAddress.PlaceholderText = "";
            this.txtPropertyAddress.SelectedText = "";
            this.txtPropertyAddress.Size = new System.Drawing.Size(307, 127);
            this.txtPropertyAddress.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fredoka", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(40, 286);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Description:";
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
            this.txtPropertyDesc.Location = new System.Drawing.Point(145, 286);
            this.txtPropertyDesc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPropertyDesc.Multiline = true;
            this.txtPropertyDesc.Name = "txtPropertyDesc";
            this.txtPropertyDesc.PasswordChar = '\0';
            this.txtPropertyDesc.PlaceholderText = "";
            this.txtPropertyDesc.SelectedText = "";
            this.txtPropertyDesc.Size = new System.Drawing.Size(307, 140);
            this.txtPropertyDesc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Fredoka", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 455);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Type:";
            // 
            // cbType
            // 
            this.cbType.BackColor = System.Drawing.Color.Transparent;
            this.cbType.BorderRadius = 6;
            this.cbType.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbType.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbType.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbType.Font = new System.Drawing.Font("Fredoka", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbType.ItemHeight = 30;
            this.cbType.Items.AddRange(new object[] {
            "For Sale",
            "For Rent",
            "Others"});
            this.cbType.Location = new System.Drawing.Point(145, 448);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(170, 36);
            this.cbType.StartIndex = 0;
            this.cbType.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Fredoka", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(80, 512);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 20);
            this.label5.TabIndex = 9;
            this.label5.Text = "Status:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Fredoka", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(480, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 30);
            this.label6.TabIndex = 11;
            this.label6.Text = "Price:";
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
            this.txtPropertyPrice.Location = new System.Drawing.Point(561, 87);
            this.txtPropertyPrice.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.txtPropertyPrice.Name = "txtPropertyPrice";
            this.txtPropertyPrice.PasswordChar = '\0';
            this.txtPropertyPrice.PlaceholderText = "";
            this.txtPropertyPrice.SelectedText = "";
            this.txtPropertyPrice.Size = new System.Drawing.Size(394, 45);
            this.txtPropertyPrice.TabIndex = 12;
            this.txtPropertyPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPropertyPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPropertyPrice_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Fredoka", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(92, 562);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "Size:";
            // 
            // txtPropertySize
            // 
            this.txtPropertySize.BackColor = System.Drawing.Color.Transparent;
            this.txtPropertySize.BorderColor = System.Drawing.Color.Black;
            this.txtPropertySize.BorderRadius = 6;
            this.txtPropertySize.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtPropertySize.DefaultText = "";
            this.txtPropertySize.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtPropertySize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtPropertySize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPropertySize.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtPropertySize.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPropertySize.Font = new System.Drawing.Font("Fredoka", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPropertySize.ForeColor = System.Drawing.Color.Black;
            this.txtPropertySize.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtPropertySize.Location = new System.Drawing.Point(145, 562);
            this.txtPropertySize.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPropertySize.Multiline = true;
            this.txtPropertySize.Name = "txtPropertySize";
            this.txtPropertySize.PasswordChar = '\0';
            this.txtPropertySize.PlaceholderText = "";
            this.txtPropertySize.SelectedText = "";
            this.txtPropertySize.Size = new System.Drawing.Size(307, 39);
            this.txtPropertySize.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Fredoka", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(23, 15);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(876, 45);
            this.label8.TabIndex = 15;
            this.label8.Text = "Add a New Property";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddImage
            // 
            this.btnAddImage.BorderRadius = 6;
            this.btnAddImage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddImage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddImage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddImage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddImage.FillColor = System.Drawing.Color.Black;
            this.btnAddImage.Font = new System.Drawing.Font("Fredoka Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddImage.ForeColor = System.Drawing.Color.White;
            this.btnAddImage.Location = new System.Drawing.Point(485, 488);
            this.btnAddImage.Name = "btnAddImage";
            this.btnAddImage.Size = new System.Drawing.Size(239, 34);
            this.btnAddImage.TabIndex = 16;
            this.btnAddImage.Text = "Add Image";
            this.btnAddImage.Click += new System.EventHandler(this.btnAddImage_Click);
            // 
            // btnClearImages
            // 
            this.btnClearImages.BorderRadius = 6;
            this.btnClearImages.BorderThickness = 1;
            this.btnClearImages.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnClearImages.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnClearImages.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnClearImages.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnClearImages.FillColor = System.Drawing.Color.Transparent;
            this.btnClearImages.Font = new System.Drawing.Font("Fredoka Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearImages.ForeColor = System.Drawing.Color.Black;
            this.btnClearImages.Location = new System.Drawing.Point(732, 488);
            this.btnClearImages.Name = "btnClearImages";
            this.btnClearImages.Size = new System.Drawing.Size(223, 34);
            this.btnClearImages.TabIndex = 17;
            this.btnClearImages.Text = "Clear Images";
            this.btnClearImages.Click += new System.EventHandler(this.btnClearImages_Click);
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
            this.btnClearAll.Location = new System.Drawing.Point(485, 546);
            this.btnClearAll.Name = "btnClearAll";
            this.btnClearAll.Size = new System.Drawing.Size(223, 55);
            this.btnClearAll.TabIndex = 19;
            this.btnClearAll.Text = "Clear All";
            this.btnClearAll.Click += new System.EventHandler(this.btnClearAll_Click);
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
            this.btnSubmit.Location = new System.Drawing.Point(716, 546);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(239, 55);
            this.btnSubmit.TabIndex = 18;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BorderRadius = 6;
            this.btnCancel.BorderThickness = 1;
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Transparent;
            this.btnCancel.Font = new System.Drawing.Font("Fredoka Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Black;
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.Location = new System.Drawing.Point(905, 15);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(44, 42);
            this.btnCancel.TabIndex = 20;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 9;
            this.guna2Elipse1.TargetControl = this;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.Black;
            this.guna2Panel1.BorderRadius = 9;
            this.guna2Panel1.BorderThickness = 1;
            this.guna2Panel1.Controls.Add(this.btnClearAll);
            this.guna2Panel1.Controls.Add(this.btnCancel);
            this.guna2Panel1.Controls.Add(this.btnSubmit);
            this.guna2Panel1.Controls.Add(this.txtPropertyDesc);
            this.guna2Panel1.Controls.Add(this.btnClearImages);
            this.guna2Panel1.Controls.Add(this.flowLayoutPanel1);
            this.guna2Panel1.Controls.Add(this.btnAddImage);
            this.guna2Panel1.Controls.Add(this.txtPropertyName);
            this.guna2Panel1.Controls.Add(this.label8);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.label7);
            this.guna2Panel1.Controls.Add(this.txtPropertyAddress);
            this.guna2Panel1.Controls.Add(this.txtPropertySize);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.txtPropertyPrice);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label6);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.cbPropertyStatus);
            this.guna2Panel1.Controls.Add(this.cbType);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(3, 3);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(968, 626);
            this.guna2Panel1.TabIndex = 21;
            // 
            // ucAddNewProperty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ucAddNewProperty";
            this.Size = new System.Drawing.Size(976, 632);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Guna.UI2.WinForms.Guna2TextBox txtPropertyName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2TextBox txtPropertyAddress;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2TextBox txtPropertyDesc;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2ComboBox cbType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2TextBox txtPropertyPrice;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2TextBox txtPropertySize;
        private System.Windows.Forms.Label label8;
        private Guna.UI2.WinForms.Guna2Button btnAddImage;
        private Guna.UI2.WinForms.Guna2Button btnClearImages;
        private Guna.UI2.WinForms.Guna2Button btnClearAll;
        private Guna.UI2.WinForms.Guna2Button btnSubmit;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ComboBox cbPropertyStatus;
    }
}

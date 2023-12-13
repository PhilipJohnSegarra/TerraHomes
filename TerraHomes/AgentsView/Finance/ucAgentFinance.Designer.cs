namespace TerraHomes.AgentsView.Finance
{
    partial class ucAgentFinance
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
            Guna.Charts.WinForms.ChartFont chartFont1 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont2 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont3 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.ChartFont chartFont4 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid1 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick1 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont5 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid2 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.Tick tick2 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont6 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Grid grid3 = new Guna.Charts.WinForms.Grid();
            Guna.Charts.WinForms.PointLabel pointLabel1 = new Guna.Charts.WinForms.PointLabel();
            Guna.Charts.WinForms.ChartFont chartFont7 = new Guna.Charts.WinForms.ChartFont();
            Guna.Charts.WinForms.Tick tick3 = new Guna.Charts.WinForms.Tick();
            Guna.Charts.WinForms.ChartFont chartFont8 = new Guna.Charts.WinForms.ChartFont();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucAgentFinance));
            this.cbYear = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblYear = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.revenueChart = new Guna.Charts.WinForms.GunaChart();
            this.barRevenue = new Guna.Charts.WinForms.GunaBarDataset();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblYear2 = new System.Windows.Forms.Label();
            this.lblOthers = new System.Windows.Forms.Label();
            this.lblPropRented = new System.Windows.Forms.Label();
            this.lblPropSold = new System.Windows.Forms.Label();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalCommissiom = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.dgvTransactions = new Guna.UI2.WinForms.Guna2DataGridView();
            this.label30 = new System.Windows.Forms.Label();
            this.btnRefresh = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).BeginInit();
            this.SuspendLayout();
            // 
            // cbYear
            // 
            this.cbYear.BackColor = System.Drawing.Color.Transparent;
            this.cbYear.BorderRadius = 9;
            this.cbYear.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbYear.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbYear.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbYear.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.cbYear.ItemHeight = 30;
            this.cbYear.Items.AddRange(new object[] {
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
            this.cbYear.Location = new System.Drawing.Point(718, 19);
            this.cbYear.Name = "cbYear";
            this.cbYear.Size = new System.Drawing.Size(243, 36);
            this.cbYear.StartIndex = 0;
            this.cbYear.TabIndex = 18;
            this.cbYear.SelectedIndexChanged += new System.EventHandler(this.cbYear_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Fredoka", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(40, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(254, 16);
            this.label2.TabIndex = 17;
            this.label2.Text = "See budgets, expenses, revenue and profit.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Fredoka", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 34);
            this.label1.TabIndex = 16;
            this.label1.Text = "Finance";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel1.BorderRadius = 9;
            this.guna2Panel1.Controls.Add(this.lblYear);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.revenueChart);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(43, 77);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.BorderRadius = 9;
            this.guna2Panel1.ShadowDecoration.Enabled = true;
            this.guna2Panel1.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 4, 4);
            this.guna2Panel1.Size = new System.Drawing.Size(963, 402);
            this.guna2Panel1.TabIndex = 19;
            // 
            // lblYear
            // 
            this.lblYear.AutoSize = true;
            this.lblYear.Font = new System.Drawing.Font("Fredoka Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(43)))));
            this.lblYear.Location = new System.Drawing.Point(855, 36);
            this.lblYear.Name = "lblYear";
            this.lblYear.Size = new System.Drawing.Size(45, 20);
            this.lblYear.TabIndex = 12;
            this.lblYear.Text = "2023";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Fredoka Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(43)))));
            this.label3.Location = new System.Drawing.Point(44, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(181, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Montly Revenue Report";
            // 
            // revenueChart
            // 
            this.revenueChart.Datasets.AddRange(new Guna.Charts.Interfaces.IGunaDataset[] {
            this.barRevenue});
            chartFont1.FontName = "Arial";
            this.revenueChart.Legend.LabelFont = chartFont1;
            this.revenueChart.Location = new System.Drawing.Point(34, 36);
            this.revenueChart.Name = "revenueChart";
            this.revenueChart.Size = new System.Drawing.Size(904, 343);
            this.revenueChart.TabIndex = 0;
            chartFont2.FontName = "Arial";
            chartFont2.Size = 12;
            chartFont2.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.revenueChart.Title.Font = chartFont2;
            chartFont3.FontName = "Arial";
            this.revenueChart.Tooltips.BodyFont = chartFont3;
            chartFont4.FontName = "Arial";
            chartFont4.Size = 9;
            chartFont4.Style = Guna.Charts.WinForms.ChartFontStyle.Bold;
            this.revenueChart.Tooltips.TitleFont = chartFont4;
            this.revenueChart.XAxes.GridLines = grid1;
            chartFont5.FontName = "Arial";
            tick1.Font = chartFont5;
            this.revenueChart.XAxes.Ticks = tick1;
            this.revenueChart.YAxes.GridLines = grid2;
            chartFont6.FontName = "Arial";
            tick2.Font = chartFont6;
            this.revenueChart.YAxes.Ticks = tick2;
            this.revenueChart.ZAxes.GridLines = grid3;
            chartFont7.FontName = "Arial";
            pointLabel1.Font = chartFont7;
            this.revenueChart.ZAxes.PointLabels = pointLabel1;
            chartFont8.FontName = "Arial";
            tick3.Font = chartFont8;
            this.revenueChart.ZAxes.Ticks = tick3;
            // 
            // barRevenue
            // 
            this.barRevenue.BorderColors.AddRange(new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(43)))))});
            this.barRevenue.FillColors.AddRange(new System.Drawing.Color[] {
            System.Drawing.Color.FromArgb(((int)(((byte)(79)))), ((int)(((byte)(59)))), ((int)(((byte)(43)))))});
            this.barRevenue.Label = "Revenue";
            this.barRevenue.TargetChart = this.revenueChart;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderRadius = 9;
            this.guna2Panel2.Controls.Add(this.lblYear2);
            this.guna2Panel2.Controls.Add(this.lblOthers);
            this.guna2Panel2.Controls.Add(this.lblPropRented);
            this.guna2Panel2.Controls.Add(this.lblPropSold);
            this.guna2Panel2.Controls.Add(this.lblTotalRevenue);
            this.guna2Panel2.Controls.Add(this.label10);
            this.guna2Panel2.Controls.Add(this.label9);
            this.guna2Panel2.Controls.Add(this.label8);
            this.guna2Panel2.Controls.Add(this.label7);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(142)))), ((int)(((byte)(142)))), ((int)(((byte)(142)))));
            this.guna2Panel2.Location = new System.Drawing.Point(43, 510);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 100, 0);
            this.guna2Panel2.ShadowDecoration.BorderRadius = 9;
            this.guna2Panel2.ShadowDecoration.Enabled = true;
            this.guna2Panel2.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.guna2Panel2.Size = new System.Drawing.Size(518, 187);
            this.guna2Panel2.TabIndex = 20;
            // 
            // lblYear2
            // 
            this.lblYear2.AutoSize = true;
            this.lblYear2.Font = new System.Drawing.Font("Fredoka Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblYear2.ForeColor = System.Drawing.Color.White;
            this.lblYear2.Location = new System.Drawing.Point(450, 33);
            this.lblYear2.Name = "lblYear2";
            this.lblYear2.Size = new System.Drawing.Size(45, 20);
            this.lblYear2.TabIndex = 38;
            this.lblYear2.Text = "2023";
            // 
            // lblOthers
            // 
            this.lblOthers.Font = new System.Drawing.Font("Fredoka", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOthers.ForeColor = System.Drawing.Color.White;
            this.lblOthers.Location = new System.Drawing.Point(313, 132);
            this.lblOthers.Name = "lblOthers";
            this.lblOthers.Size = new System.Drawing.Size(182, 19);
            this.lblOthers.TabIndex = 30;
            this.lblOthers.Text = "0.00";
            this.lblOthers.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPropRented
            // 
            this.lblPropRented.Font = new System.Drawing.Font("Fredoka", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropRented.ForeColor = System.Drawing.Color.White;
            this.lblPropRented.Location = new System.Drawing.Point(313, 113);
            this.lblPropRented.Name = "lblPropRented";
            this.lblPropRented.Size = new System.Drawing.Size(182, 19);
            this.lblPropRented.TabIndex = 29;
            this.lblPropRented.Text = "0.00";
            this.lblPropRented.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblPropSold
            // 
            this.lblPropSold.Font = new System.Drawing.Font("Fredoka", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPropSold.ForeColor = System.Drawing.Color.White;
            this.lblPropSold.Location = new System.Drawing.Point(313, 94);
            this.lblPropSold.Name = "lblPropSold";
            this.lblPropSold.Size = new System.Drawing.Size(182, 19);
            this.lblPropSold.TabIndex = 28;
            this.lblPropSold.Text = "0.00";
            this.lblPropSold.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.Font = new System.Drawing.Font("Fredoka Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.ForeColor = System.Drawing.Color.White;
            this.lblTotalRevenue.Location = new System.Drawing.Point(283, 74);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalRevenue.Size = new System.Drawing.Size(212, 20);
            this.lblTotalRevenue.TabIndex = 27;
            this.lblTotalRevenue.Text = "0.00";
            this.lblTotalRevenue.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Fredoka", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(59, 132);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 19);
            this.label10.TabIndex = 19;
            this.label10.Text = "-Others";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Fredoka", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(59, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 19);
            this.label9.TabIndex = 18;
            this.label9.Text = "-Rentals";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Fredoka", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(59, 94);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(115, 19);
            this.label8.TabIndex = 17;
            this.label8.Text = "-Property Sales";
            this.label8.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Fredoka Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 74);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(115, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Total Revenue";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Fredoka Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 33);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "Financial Summary";
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel3.BorderRadius = 9;
            this.guna2Panel3.Controls.Add(this.lblTotalCommissiom);
            this.guna2Panel3.Controls.Add(this.label13);
            this.guna2Panel3.Controls.Add(this.label12);
            this.guna2Panel3.Controls.Add(this.label11);
            this.guna2Panel3.Controls.Add(this.label5);
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.guna2Panel3.Location = new System.Drawing.Point(578, 510);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.BorderRadius = 9;
            this.guna2Panel3.ShadowDecoration.Enabled = true;
            this.guna2Panel3.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.guna2Panel3.Size = new System.Drawing.Size(428, 187);
            this.guna2Panel3.TabIndex = 21;
            // 
            // lblTotalCommissiom
            // 
            this.lblTotalCommissiom.Font = new System.Drawing.Font("Fredoka", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCommissiom.ForeColor = System.Drawing.Color.White;
            this.lblTotalCommissiom.Location = new System.Drawing.Point(218, 94);
            this.lblTotalCommissiom.Name = "lblTotalCommissiom";
            this.lblTotalCommissiom.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblTotalCommissiom.Size = new System.Drawing.Size(185, 58);
            this.lblTotalCommissiom.TabIndex = 29;
            this.lblTotalCommissiom.Text = "0.00";
            this.lblTotalCommissiom.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Font = new System.Drawing.Font("Fredoka", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(65, 94);
            this.label13.Name = "label13";
            this.label13.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label13.Size = new System.Drawing.Size(81, 58);
            this.label13.TabIndex = 28;
            this.label13.Text = "5%";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Font = new System.Drawing.Font("Fredoka Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(246, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 20);
            this.label12.TabIndex = 18;
            this.label12.Text = "Total Commission";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Font = new System.Drawing.Font("Fredoka Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(33, 74);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Rate";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Fredoka Medium", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(33, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Commission";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Location = new System.Drawing.Point(46, 1256);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(960, 32);
            this.panel2.TabIndex = 23;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel4.BorderRadius = 9;
            this.guna2Panel4.Controls.Add(this.dgvTransactions);
            this.guna2Panel4.FillColor = System.Drawing.Color.White;
            this.guna2Panel4.Location = new System.Drawing.Point(43, 753);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.BorderRadius = 9;
            this.guna2Panel4.ShadowDecoration.Enabled = true;
            this.guna2Panel4.ShadowDecoration.Shadow = new System.Windows.Forms.Padding(0, 0, 5, 5);
            this.guna2Panel4.Size = new System.Drawing.Size(963, 395);
            this.guna2Panel4.TabIndex = 30;
            // 
            // dgvTransactions
            // 
            this.dgvTransactions.AllowUserToAddRows = false;
            this.dgvTransactions.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvTransactions.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Fredoka", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvTransactions.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvTransactions.ColumnHeadersHeight = 40;
            this.dgvTransactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.Gainsboro;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTransactions.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvTransactions.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransactions.Location = new System.Drawing.Point(11, 12);
            this.dgvTransactions.Margin = new System.Windows.Forms.Padding(3, 3, 3, 50);
            this.dgvTransactions.Name = "dgvTransactions";
            this.dgvTransactions.ReadOnly = true;
            this.dgvTransactions.RowHeadersVisible = false;
            this.dgvTransactions.Size = new System.Drawing.Size(932, 367);
            this.dgvTransactions.TabIndex = 14;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgvTransactions.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgvTransactions.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransactions.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgvTransactions.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvTransactions.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransactions.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgvTransactions.ThemeStyle.HeaderStyle.Height = 40;
            this.dgvTransactions.ThemeStyle.ReadOnly = true;
            this.dgvTransactions.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgvTransactions.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgvTransactions.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgvTransactions.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgvTransactions.ThemeStyle.RowsStyle.Height = 22;
            this.dgvTransactions.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgvTransactions.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Fredoka", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(52)))), ((int)(((byte)(52)))));
            this.label30.Location = new System.Drawing.Point(39, 724);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(198, 26);
            this.label30.TabIndex = 29;
            this.label30.Text = "Transaction History";
            // 
            // btnRefresh
            // 
            this.btnRefresh.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnRefresh.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnRefresh.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnRefresh.FillColor = System.Drawing.Color.Transparent;
            this.btnRefresh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnRefresh.ForeColor = System.Drawing.Color.White;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageOffset = new System.Drawing.Point(1, 0);
            this.btnRefresh.ImageSize = new System.Drawing.Size(25, 25);
            this.btnRefresh.Location = new System.Drawing.Point(968, 21);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(38, 34);
            this.btnRefresh.TabIndex = 31;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // ucAgentFinance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.guna2Panel4);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.cbYear);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ucAgentFinance";
            this.Size = new System.Drawing.Size(1026, 766);
            this.Load += new System.EventHandler(this.ucAgentFinance_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTransactions)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ComboBox cbYear;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblYear;
        private System.Windows.Forms.Label label3;
        private Guna.Charts.WinForms.GunaChart revenueChart;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label lblYear2;
        private System.Windows.Forms.Label lblOthers;
        private System.Windows.Forms.Label lblPropRented;
        private System.Windows.Forms.Label lblPropSold;
        private System.Windows.Forms.Label lblTotalRevenue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Panel panel2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2DataGridView dgvTransactions;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblTotalCommissiom;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label5;
        private Guna.Charts.WinForms.GunaBarDataset barRevenue;
        private Guna.UI2.WinForms.Guna2Button btnRefresh;
    }
}

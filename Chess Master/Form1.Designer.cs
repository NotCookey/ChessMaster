namespace Chess_Bot_2
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : global::System.Windows.Forms.Form
	{
		// Token: 0x06000027 RID: 39
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000028 RID: 40
		private void InitializeComponent()
		{
			global::System.ComponentModel.ComponentResourceManager componentResourceManager = new global::System.ComponentModel.ComponentResourceManager(typeof(global::Chess_Bot_2.Form1));
			this.menuStrip1 = new global::System.Windows.Forms.MenuStrip();
			this.menuToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.getKeyToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.aboutToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new global::System.Windows.Forms.ToolStripMenuItem();
			this.statusStrip1 = new global::System.Windows.Forms.StatusStrip();
			this.toolStripStatusLabel1 = new global::System.Windows.Forms.ToolStripStatusLabel();
			this.tabControl1 = new global::System.Windows.Forms.TabControl();
			this.tabPage1 = new global::System.Windows.Forms.TabPage();
			this.labelHour = new global::System.Windows.Forms.Label();
			this.labelMoveCount = new global::System.Windows.Forms.Label();
			this.labelLicenseInfo = new global::System.Windows.Forms.Label();
			this.textBox1 = new global::System.Windows.Forms.TextBox();
			this.comboBox1 = new global::System.Windows.Forms.ComboBox();
			this.label1 = new global::System.Windows.Forms.Label();
			this.tabPage2 = new global::System.Windows.Forms.TabPage();
			this.buttonLicense = new global::System.Windows.Forms.Button();
			this.textBoxLicense = new global::System.Windows.Forms.TextBox();
			this.label2 = new global::System.Windows.Forms.Label();
			this.tabPage3 = new global::System.Windows.Forms.TabPage();
			this.buttonStop = new global::System.Windows.Forms.Button();
			this.labelCalcDepth = new global::System.Windows.Forms.Label();
			this.comboBoxCalc = new global::System.Windows.Forms.ComboBox();
			this.textBoxCalculate = new global::System.Windows.Forms.TextBox();
			this.labelResult = new global::System.Windows.Forms.Label();
			this.linkLabel1 = new global::System.Windows.Forms.LinkLabel();
			this.buttonCalculate = new global::System.Windows.Forms.Button();
			this.textBoxCalcFen = new global::System.Windows.Forms.TextBox();
			this.label3 = new global::System.Windows.Forms.Label();
			this.tabPage4 = new global::System.Windows.Forms.TabPage();
			this.textBoxCoord = new global::System.Windows.Forms.TextBox();
			this.buttonSaveCoords = new global::System.Windows.Forms.Button();
			this.comboBoxSites = new global::System.Windows.Forms.ComboBox();
			this.labelChess = new global::System.Windows.Forms.Label();
			this.textBoxCoords = new global::System.Windows.Forms.TextBox();
			this.buttonBorder = new global::System.Windows.Forms.Button();
			this.tabPage5 = new global::System.Windows.Forms.TabPage();
			this.labelDelay = new global::System.Windows.Forms.Label();
			this.comboBoxDelay = new global::System.Windows.Forms.ComboBox();
			this.buttonSetConfig = new global::System.Windows.Forms.Button();
			this.comboBoxThreads = new global::System.Windows.Forms.ComboBox();
			this.label5 = new global::System.Windows.Forms.Label();
			this.label4 = new global::System.Windows.Forms.Label();
			this.comboBoxHash = new global::System.Windows.Forms.ComboBox();
			this.linkLabelInfo = new global::System.Windows.Forms.LinkLabel();
			this.menuStrip1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.tabPage5.SuspendLayout();
			base.SuspendLayout();
			this.menuStrip1.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.menuStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.menuToolStripMenuItem
			});
			this.menuStrip1.Location = new global::System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new global::System.Drawing.Size(509, 28);
			this.menuStrip1.TabIndex = 0;
			this.menuStrip1.Text = "menuStrip1";
			this.menuToolStripMenuItem.DropDownItems.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.getKeyToolStripMenuItem,
				this.aboutToolStripMenuItem,
				this.exitToolStripMenuItem
			});
			this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
			this.menuToolStripMenuItem.Size = new global::System.Drawing.Size(60, 24);
			this.menuToolStripMenuItem.Text = "Menu";
			this.getKeyToolStripMenuItem.Name = "getKeyToolStripMenuItem";
			this.getKeyToolStripMenuItem.Size = new global::System.Drawing.Size(143, 26);
			this.getKeyToolStripMenuItem.Text = "Get Key";
			this.getKeyToolStripMenuItem.Click += new global::System.EventHandler(this.ox026);
			this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
			this.aboutToolStripMenuItem.Size = new global::System.Drawing.Size(143, 26);
			this.aboutToolStripMenuItem.Text = "About";
			this.aboutToolStripMenuItem.Click += new global::System.EventHandler(this.aboutToolStripMenuItem_Click);
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new global::System.Drawing.Size(143, 26);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new global::System.EventHandler(this.ox025);
			this.statusStrip1.ImageScalingSize = new global::System.Drawing.Size(20, 20);
			this.statusStrip1.Items.AddRange(new global::System.Windows.Forms.ToolStripItem[]
			{
				this.toolStripStatusLabel1
			});
			this.statusStrip1.Location = new global::System.Drawing.Point(0, 421);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Padding = new global::System.Windows.Forms.Padding(1, 0, 19, 0);
			this.statusStrip1.Size = new global::System.Drawing.Size(509, 26);
			this.statusStrip1.TabIndex = 1;
			this.statusStrip1.Text = "statusStrip1";
			this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
			this.toolStripStatusLabel1.Size = new global::System.Drawing.Size(151, 20);
			this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Controls.Add(this.tabPage3);
			this.tabControl1.Controls.Add(this.tabPage4);
			this.tabControl1.Controls.Add(this.tabPage5);
			this.tabControl1.ItemSize = new global::System.Drawing.Size(42, 18);
			this.tabControl1.Location = new global::System.Drawing.Point(16, 33);
			this.tabControl1.Margin = new global::System.Windows.Forms.Padding(4);
			this.tabControl1.Multiline = true;
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.Padding = new global::System.Drawing.Point(10, 3);
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new global::System.Drawing.Size(480, 388);
			this.tabControl1.TabIndex = 2;
			this.tabPage1.BackColor = global::System.Drawing.SystemColors.Control;
			this.tabPage1.Controls.Add(this.labelHour);
			this.tabPage1.Controls.Add(this.labelMoveCount);
			this.tabPage1.Controls.Add(this.labelLicenseInfo);
			this.tabPage1.Controls.Add(this.textBox1);
			this.tabPage1.Controls.Add(this.comboBox1);
			this.tabPage1.Controls.Add(this.label1);
			this.tabPage1.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage1.Margin = new global::System.Windows.Forms.Padding(4);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new global::System.Windows.Forms.Padding(4);
			this.tabPage1.Size = new global::System.Drawing.Size(472, 362);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Main";
			this.labelHour.AutoSize = true;
			this.labelHour.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 8.25f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelHour.Location = new global::System.Drawing.Point(29, 313);
			this.labelHour.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelHour.Name = "labelHour";
			this.labelHour.Size = new global::System.Drawing.Size(12, 17);
			this.labelHour.TabIndex = 26;
			this.labelHour.Text = " ";
			this.labelMoveCount.AutoSize = true;
			this.labelMoveCount.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelMoveCount.Location = new global::System.Drawing.Point(339, 310);
			this.labelMoveCount.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelMoveCount.Name = "labelMoveCount";
			this.labelMoveCount.Size = new global::System.Drawing.Size(53, 18);
			this.labelMoveCount.TabIndex = 25;
			this.labelMoveCount.Text = "Moves";
			this.labelLicenseInfo.AutoSize = true;
			this.labelLicenseInfo.BackColor = global::System.Drawing.SystemColors.Control;
			this.labelLicenseInfo.Cursor = global::System.Windows.Forms.Cursors.Default;
			this.labelLicenseInfo.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelLicenseInfo.ForeColor = global::System.Drawing.Color.Red;
			this.labelLicenseInfo.Location = new global::System.Drawing.Point(4, 334);
			this.labelLicenseInfo.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelLicenseInfo.Name = "labelLicenseInfo";
			this.labelLicenseInfo.Size = new global::System.Drawing.Size(59, 18);
			this.labelLicenseInfo.TabIndex = 24;
			this.labelLicenseInfo.Text = "License";
			this.textBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBox1.Location = new global::System.Drawing.Point(33, 105);
			this.textBox1.Margin = new global::System.Windows.Forms.Padding(4);
			this.textBox1.Multiline = true;
			this.textBox1.Name = "textBox1";
			this.textBox1.ReadOnly = true;
			this.textBox1.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.textBox1.Size = new global::System.Drawing.Size(403, 201);
			this.textBox1.TabIndex = 16;
			this.textBox1.Text = "Chess Master v1.3";
			this.comboBox1.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBox1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.comboBox1.FormattingEnabled = true;
			this.comboBox1.Items.AddRange(new object[]
			{
				"5",
				"6",
				"7",
				"8",
				"9",
				"10",
				"11",
				"12",
				"13",
				"14",
				"15",
				"16",
				"17",
				"18",
				"19",
				"20"
			});
			this.comboBox1.Location = new global::System.Drawing.Point(276, 57);
			this.comboBox1.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboBox1.Name = "comboBox1";
			this.comboBox1.Size = new global::System.Drawing.Size(160, 28);
			this.comboBox1.TabIndex = 15;
			this.label1.AutoSize = true;
			this.label1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label1.ForeColor = global::System.Drawing.SystemColors.MenuHighlight;
			this.label1.Location = new global::System.Drawing.Point(28, 57);
			this.label1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new global::System.Drawing.Size(152, 25);
			this.label1.TabIndex = 14;
			this.label1.Text = "Engine Strength";
			this.tabPage2.BackColor = global::System.Drawing.SystemColors.Control;
			this.tabPage2.Controls.Add(this.buttonLicense);
			this.tabPage2.Controls.Add(this.textBoxLicense);
			this.tabPage2.Controls.Add(this.label2);
			this.tabPage2.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage2.Margin = new global::System.Windows.Forms.Padding(4);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new global::System.Windows.Forms.Padding(4);
			this.tabPage2.Size = new global::System.Drawing.Size(472, 362);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "License";
			this.buttonLicense.BackColor = global::System.Drawing.Color.DodgerBlue;
			this.buttonLicense.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonLicense.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonLicense.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.buttonLicense.Location = new global::System.Drawing.Point(152, 118);
			this.buttonLicense.Margin = new global::System.Windows.Forms.Padding(4);
			this.buttonLicense.Name = "buttonLicense";
			this.buttonLicense.Size = new global::System.Drawing.Size(149, 38);
			this.buttonLicense.TabIndex = 22;
			this.buttonLicense.Text = "Save";
			this.buttonLicense.UseVisualStyleBackColor = false;
			this.buttonLicense.Click += new global::System.EventHandler(this.button1_Click);
			this.textBoxLicense.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBoxLicense.Location = new global::System.Drawing.Point(19, 75);
			this.textBoxLicense.Margin = new global::System.Windows.Forms.Padding(4);
			this.textBoxLicense.MaxLength = 60;
			this.textBoxLicense.Name = "textBoxLicense";
			this.textBoxLicense.Size = new global::System.Drawing.Size(424, 34);
			this.textBoxLicense.TabIndex = 21;
			this.label2.AutoSize = true;
			this.label2.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label2.ForeColor = global::System.Drawing.Color.Green;
			this.label2.Location = new global::System.Drawing.Point(13, 36);
			this.label2.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new global::System.Drawing.Size(80, 25);
			this.label2.TabIndex = 20;
			this.label2.Text = "License";
			this.tabPage3.BackColor = global::System.Drawing.SystemColors.Control;
			this.tabPage3.Controls.Add(this.buttonStop);
			this.tabPage3.Controls.Add(this.labelCalcDepth);
			this.tabPage3.Controls.Add(this.comboBoxCalc);
			this.tabPage3.Controls.Add(this.textBoxCalculate);
			this.tabPage3.Controls.Add(this.labelResult);
			this.tabPage3.Controls.Add(this.linkLabel1);
			this.tabPage3.Controls.Add(this.buttonCalculate);
			this.tabPage3.Controls.Add(this.textBoxCalcFen);
			this.tabPage3.Controls.Add(this.label3);
			this.tabPage3.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage3.Margin = new global::System.Windows.Forms.Padding(4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new global::System.Windows.Forms.Padding(4);
			this.tabPage3.Size = new global::System.Drawing.Size(472, 362);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "Calculate Best Move";
			this.buttonStop.Location = new global::System.Drawing.Point(359, 315);
			this.buttonStop.Margin = new global::System.Windows.Forms.Padding(4);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new global::System.Drawing.Size(93, 28);
			this.buttonStop.TabIndex = 31;
			this.buttonStop.Text = "Stop";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new global::System.EventHandler(this.buttonStop_Click);
			this.labelCalcDepth.AutoSize = true;
			this.labelCalcDepth.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelCalcDepth.ForeColor = global::System.Drawing.SystemColors.MenuHighlight;
			this.labelCalcDepth.Location = new global::System.Drawing.Point(241, 146);
			this.labelCalcDepth.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelCalcDepth.Name = "labelCalcDepth";
			this.labelCalcDepth.Size = new global::System.Drawing.Size(72, 20);
			this.labelCalcDepth.TabIndex = 30;
			this.labelCalcDepth.Text = "Strength";
			this.comboBoxCalc.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxCalc.DropDownWidth = 90;
			this.comboBoxCalc.FormattingEnabled = true;
			this.comboBoxCalc.Items.AddRange(new object[]
			{
				"20",
				"30",
				"40",
				"50",
				"60",
				"70",
				"80",
				"90",
				"100"
			});
			this.comboBoxCalc.Location = new global::System.Drawing.Point(332, 145);
			this.comboBoxCalc.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboBoxCalc.Name = "comboBoxCalc";
			this.comboBoxCalc.Size = new global::System.Drawing.Size(119, 24);
			this.comboBoxCalc.TabIndex = 29;
			this.textBoxCalculate.BackColor = global::System.Drawing.Color.WhiteSmoke;
			this.textBoxCalculate.ForeColor = global::System.Drawing.Color.Black;
			this.textBoxCalculate.Location = new global::System.Drawing.Point(4, 178);
			this.textBoxCalculate.Margin = new global::System.Windows.Forms.Padding(4);
			this.textBoxCalculate.Multiline = true;
			this.textBoxCalculate.Name = "textBoxCalculate";
			this.textBoxCalculate.ReadOnly = true;
			this.textBoxCalculate.ScrollBars = global::System.Windows.Forms.ScrollBars.Vertical;
			this.textBoxCalculate.Size = new global::System.Drawing.Size(447, 132);
			this.textBoxCalculate.TabIndex = 28;
			this.textBoxCalculate.Text = "Chess Master v1.3";
			this.labelResult.AutoSize = true;
			this.labelResult.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelResult.ForeColor = global::System.Drawing.SystemColors.MenuHighlight;
			this.labelResult.Location = new global::System.Drawing.Point(8, 315);
			this.labelResult.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelResult.Name = "labelResult";
			this.labelResult.Size = new global::System.Drawing.Size(57, 20);
			this.labelResult.TabIndex = 26;
			this.labelResult.Text = "Result";
			this.linkLabel1.AutoSize = true;
			this.linkLabel1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.linkLabel1.Location = new global::System.Drawing.Point(412, 28);
			this.linkLabel1.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkLabel1.Name = "linkLabel1";
			this.linkLabel1.Size = new global::System.Drawing.Size(43, 18);
			this.linkLabel1.TabIndex = 27;
			this.linkLabel1.TabStop = true;
			this.linkLabel1.Text = "Clear";
			this.linkLabel1.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
			this.buttonCalculate.BackColor = global::System.Drawing.Color.DodgerBlue;
			this.buttonCalculate.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonCalculate.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonCalculate.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.buttonCalculate.Location = new global::System.Drawing.Point(144, 95);
			this.buttonCalculate.Margin = new global::System.Windows.Forms.Padding(4);
			this.buttonCalculate.Name = "buttonCalculate";
			this.buttonCalculate.Size = new global::System.Drawing.Size(149, 38);
			this.buttonCalculate.TabIndex = 25;
			this.buttonCalculate.Text = "Calculate";
			this.buttonCalculate.UseVisualStyleBackColor = false;
			this.buttonCalculate.Click += new global::System.EventHandler(this.buttonCalculate_Click);
			this.textBoxCalcFen.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 14f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBoxCalcFen.Location = new global::System.Drawing.Point(12, 52);
			this.textBoxCalcFen.Margin = new global::System.Windows.Forms.Padding(4);
			this.textBoxCalcFen.MaxLength = 60;
			this.textBoxCalcFen.Name = "textBoxCalcFen";
			this.textBoxCalcFen.Size = new global::System.Drawing.Size(448, 34);
			this.textBoxCalcFen.TabIndex = 24;
			this.label3.AutoSize = true;
			this.label3.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label3.ForeColor = global::System.Drawing.Color.Green;
			this.label3.Location = new global::System.Drawing.Point(7, 22);
			this.label3.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new global::System.Drawing.Size(102, 25);
			this.label3.TabIndex = 23;
			this.label3.Text = "Enter FEN";
			this.tabPage4.BackColor = global::System.Drawing.SystemColors.Control;
			this.tabPage4.Controls.Add(this.textBoxCoord);
			this.tabPage4.Controls.Add(this.buttonSaveCoords);
			this.tabPage4.Controls.Add(this.comboBoxSites);
			this.tabPage4.Controls.Add(this.labelChess);
			this.tabPage4.Controls.Add(this.textBoxCoords);
			this.tabPage4.Controls.Add(this.buttonBorder);
			this.tabPage4.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage4.Margin = new global::System.Windows.Forms.Padding(4);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new global::System.Windows.Forms.Padding(4);
			this.tabPage4.Size = new global::System.Drawing.Size(472, 362);
			this.tabPage4.TabIndex = 3;
			this.tabPage4.Text = "Auto Step";
			this.textBoxCoord.BackColor = global::System.Drawing.SystemColors.Control;
			this.textBoxCoord.Location = new global::System.Drawing.Point(31, 139);
			this.textBoxCoord.Margin = new global::System.Windows.Forms.Padding(4);
			this.textBoxCoord.Multiline = true;
			this.textBoxCoord.Name = "textBoxCoord";
			this.textBoxCoord.ReadOnly = true;
			this.textBoxCoord.Size = new global::System.Drawing.Size(416, 109);
			this.textBoxCoord.TabIndex = 5;
			this.buttonSaveCoords.BackColor = global::System.Drawing.SystemColors.Control;
			this.buttonSaveCoords.Enabled = false;
			this.buttonSaveCoords.FlatStyle = global::System.Windows.Forms.FlatStyle.System;
			this.buttonSaveCoords.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonSaveCoords.ForeColor = global::System.Drawing.Color.Black;
			this.buttonSaveCoords.Location = new global::System.Drawing.Point(293, 262);
			this.buttonSaveCoords.Margin = new global::System.Windows.Forms.Padding(4);
			this.buttonSaveCoords.Name = "buttonSaveCoords";
			this.buttonSaveCoords.Size = new global::System.Drawing.Size(155, 31);
			this.buttonSaveCoords.TabIndex = 4;
			this.buttonSaveCoords.Text = "Save";
			this.buttonSaveCoords.UseVisualStyleBackColor = false;
			this.buttonSaveCoords.Click += new global::System.EventHandler(this.button1_Click_1);
			this.comboBoxSites.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxSites.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.comboBoxSites.FormattingEnabled = true;
			this.comboBoxSites.Items.AddRange(new object[]
			{
				"chess.com",
				"lichess.com",
				"chess24.com",
				"chessbase.com"
			});
			this.comboBoxSites.Location = new global::System.Drawing.Point(31, 73);
			this.comboBoxSites.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboBoxSites.Name = "comboBoxSites";
			this.comboBoxSites.Size = new global::System.Drawing.Size(227, 28);
			this.comboBoxSites.TabIndex = 3;
			this.comboBoxSites.SelectedIndexChanged += new global::System.EventHandler(this.comboBoxSites_SelectedIndexChanged);
			this.labelChess.AutoSize = true;
			this.labelChess.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelChess.ForeColor = global::System.Drawing.SystemColors.MenuHighlight;
			this.labelChess.Location = new global::System.Drawing.Point(27, 34);
			this.labelChess.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelChess.Name = "labelChess";
			this.labelChess.Size = new global::System.Drawing.Size(102, 25);
			this.labelChess.TabIndex = 2;
			this.labelChess.Text = "Select site";
			this.textBoxCoords.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.textBoxCoords.Location = new global::System.Drawing.Point(31, 262);
			this.textBoxCoords.Margin = new global::System.Windows.Forms.Padding(4);
			this.textBoxCoords.Name = "textBoxCoords";
			this.textBoxCoords.ReadOnly = true;
			this.textBoxCoords.Size = new global::System.Drawing.Size(227, 26);
			this.textBoxCoords.TabIndex = 1;
			this.buttonBorder.BackColor = global::System.Drawing.Color.DodgerBlue;
			this.buttonBorder.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonBorder.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonBorder.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.buttonBorder.Location = new global::System.Drawing.Point(293, 70);
			this.buttonBorder.Margin = new global::System.Windows.Forms.Padding(4);
			this.buttonBorder.Name = "buttonBorder";
			this.buttonBorder.Size = new global::System.Drawing.Size(155, 36);
			this.buttonBorder.TabIndex = 0;
			this.buttonBorder.Text = "Open Frame";
			this.buttonBorder.UseVisualStyleBackColor = false;
			this.buttonBorder.Click += new global::System.EventHandler(this.buttonBorder_Click);
			this.tabPage5.BackColor = global::System.Drawing.SystemColors.Control;
			this.tabPage5.Controls.Add(this.labelDelay);
			this.tabPage5.Controls.Add(this.comboBoxDelay);
			this.tabPage5.Controls.Add(this.buttonSetConfig);
			this.tabPage5.Controls.Add(this.comboBoxThreads);
			this.tabPage5.Controls.Add(this.label5);
			this.tabPage5.Controls.Add(this.label4);
			this.tabPage5.Controls.Add(this.comboBoxHash);
			this.tabPage5.Location = new global::System.Drawing.Point(4, 22);
			this.tabPage5.Margin = new global::System.Windows.Forms.Padding(4);
			this.tabPage5.Name = "tabPage5";
			this.tabPage5.Padding = new global::System.Windows.Forms.Padding(4);
			this.tabPage5.Size = new global::System.Drawing.Size(472, 362);
			this.tabPage5.TabIndex = 4;
			this.tabPage5.Text = "Config";
			this.labelDelay.AutoSize = true;
			this.labelDelay.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.labelDelay.ForeColor = global::System.Drawing.SystemColors.MenuHighlight;
			this.labelDelay.Location = new global::System.Drawing.Point(272, 49);
			this.labelDelay.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.labelDelay.Name = "labelDelay";
			this.labelDelay.Size = new global::System.Drawing.Size(153, 24);
			this.labelDelay.TabIndex = 25;
			this.labelDelay.Text = "Clicks Delay (ms)";
			this.comboBoxDelay.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxDelay.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.comboBoxDelay.FormattingEnabled = true;
			this.comboBoxDelay.Items.AddRange(new object[]
			{
				"20",
				"40",
				"60",
				"80",
				"100",
				"120",
				"150",
				"180",
				"200",
				"250",
				"280",
				"300",
				"350",
				"400",
				"450",
				"500"
			});
			this.comboBoxDelay.Location = new global::System.Drawing.Point(276, 75);
			this.comboBoxDelay.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboBoxDelay.Name = "comboBoxDelay";
			this.comboBoxDelay.Size = new global::System.Drawing.Size(167, 28);
			this.comboBoxDelay.TabIndex = 24;
			this.buttonSetConfig.BackColor = global::System.Drawing.Color.DodgerBlue;
			this.buttonSetConfig.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.buttonSetConfig.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 12f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.buttonSetConfig.ForeColor = global::System.Drawing.SystemColors.ButtonFace;
			this.buttonSetConfig.Location = new global::System.Drawing.Point(19, 224);
			this.buttonSetConfig.Margin = new global::System.Windows.Forms.Padding(4);
			this.buttonSetConfig.Name = "buttonSetConfig";
			this.buttonSetConfig.Size = new global::System.Drawing.Size(149, 38);
			this.buttonSetConfig.TabIndex = 23;
			this.buttonSetConfig.Text = "Set";
			this.buttonSetConfig.UseVisualStyleBackColor = false;
			this.buttonSetConfig.Click += new global::System.EventHandler(this.buttonSetConfig_Click);
			this.comboBoxThreads.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxThreads.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.comboBoxThreads.FormattingEnabled = true;
			this.comboBoxThreads.Items.AddRange(new object[]
			{
				"1",
				"2",
				"4",
				"8"
			});
			this.comboBoxThreads.Location = new global::System.Drawing.Point(19, 166);
			this.comboBoxThreads.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboBoxThreads.Name = "comboBoxThreads";
			this.comboBoxThreads.Size = new global::System.Drawing.Size(167, 28);
			this.comboBoxThreads.TabIndex = 5;
			this.label5.AutoSize = true;
			this.label5.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label5.ForeColor = global::System.Drawing.SystemColors.MenuHighlight;
			this.label5.Location = new global::System.Drawing.Point(15, 140);
			this.label5.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label5.Name = "label5";
			this.label5.Size = new global::System.Drawing.Size(80, 24);
			this.label5.TabIndex = 4;
			this.label5.Text = "Threads";
			this.label4.AutoSize = true;
			this.label4.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 11f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.label4.ForeColor = global::System.Drawing.SystemColors.MenuHighlight;
			this.label4.Location = new global::System.Drawing.Point(15, 49);
			this.label4.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new global::System.Drawing.Size(144, 24);
			this.label4.TabIndex = 3;
			this.label4.Text = "Hash table (MB)";
			this.comboBoxHash.DropDownStyle = global::System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.comboBoxHash.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.comboBoxHash.FormattingEnabled = true;
			this.comboBoxHash.Items.AddRange(new object[]
			{
				"16",
				"32",
				"64",
				"128",
				"256",
				"512",
				"1024",
				"2048"
			});
			this.comboBoxHash.Location = new global::System.Drawing.Point(19, 75);
			this.comboBoxHash.Margin = new global::System.Windows.Forms.Padding(4);
			this.comboBoxHash.Name = "comboBoxHash";
			this.comboBoxHash.Size = new global::System.Drawing.Size(167, 28);
			this.comboBoxHash.TabIndex = 0;
			this.linkLabelInfo.AutoSize = true;
			this.linkLabelInfo.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 9f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.linkLabelInfo.Location = new global::System.Drawing.Point(439, 431);
			this.linkLabelInfo.Margin = new global::System.Windows.Forms.Padding(4, 0, 4, 0);
			this.linkLabelInfo.Name = "linkLabelInfo";
			this.linkLabelInfo.Size = new global::System.Drawing.Size(46, 18);
			this.linkLabelInfo.TabIndex = 27;
			this.linkLabelInfo.TabStop = true;
			this.linkLabelInfo.Text = "About";
			this.linkLabelInfo.LinkClicked += new global::System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelInfo_LinkClicked);
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(8f, 16f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(509, 447);
			base.Controls.Add(this.linkLabelInfo);
			base.Controls.Add(this.tabControl1);
			base.Controls.Add(this.statusStrip1);
			base.Controls.Add(this.menuStrip1);
			base.Icon = (global::System.Drawing.Icon)componentResourceManager.GetObject("$this.Icon");
			base.MainMenuStrip = this.menuStrip1;
			base.Margin = new global::System.Windows.Forms.Padding(4);
			base.MaximizeBox = false;
			this.MaximumSize = new global::System.Drawing.Size(527, 494);
			this.MinimumSize = new global::System.Drawing.Size(527, 494);
			base.Name = "Form1";
			this.Text = "Chess Master";
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tabPage1.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tabPage2.PerformLayout();
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.tabPage5.ResumeLayout(false);
			this.tabPage5.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x0400001A RID: 26
		private global::System.ComponentModel.IContainer components;

		// Token: 0x0400001B RID: 27
		private global::System.Windows.Forms.MenuStrip menuStrip1;

		// Token: 0x0400001C RID: 28
		private global::System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;

		// Token: 0x0400001D RID: 29
		private global::System.Windows.Forms.ToolStripMenuItem getKeyToolStripMenuItem;

		// Token: 0x0400001E RID: 30
		private global::System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;

		// Token: 0x0400001F RID: 31
		private global::System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;

		// Token: 0x04000020 RID: 32
		private global::System.Windows.Forms.StatusStrip statusStrip1;

		// Token: 0x04000021 RID: 33
		private global::System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;

		// Token: 0x04000022 RID: 34
		private global::System.Windows.Forms.TabControl tabControl1;

		// Token: 0x04000023 RID: 35
		private global::System.Windows.Forms.TabPage tabPage1;

		// Token: 0x04000024 RID: 36
		private global::System.Windows.Forms.TextBox textBox1;

		// Token: 0x04000025 RID: 37
		private global::System.Windows.Forms.ComboBox comboBox1;

		// Token: 0x04000026 RID: 38
		private global::System.Windows.Forms.Label label1;

		// Token: 0x04000027 RID: 39
		private global::System.Windows.Forms.TabPage tabPage2;

		// Token: 0x04000028 RID: 40
		private global::System.Windows.Forms.Button buttonLicense;

		// Token: 0x04000029 RID: 41
		private global::System.Windows.Forms.TextBox textBoxLicense;

		// Token: 0x0400002A RID: 42
		private global::System.Windows.Forms.Label label2;

		// Token: 0x0400002B RID: 43
		private global::System.Windows.Forms.Label labelLicenseInfo;

		// Token: 0x0400002C RID: 44
		private global::System.Windows.Forms.TabPage tabPage3;

		// Token: 0x0400002D RID: 45
		private global::System.Windows.Forms.Button buttonCalculate;

		// Token: 0x0400002E RID: 46
		private global::System.Windows.Forms.TextBox textBoxCalcFen;

		// Token: 0x0400002F RID: 47
		private global::System.Windows.Forms.Label label3;

		// Token: 0x04000030 RID: 48
		private global::System.Windows.Forms.Label labelResult;

		// Token: 0x04000031 RID: 49
		private global::System.Windows.Forms.LinkLabel linkLabel1;

		// Token: 0x04000032 RID: 50
		private global::System.Windows.Forms.TextBox textBoxCalculate;

		// Token: 0x04000033 RID: 51
		private global::System.Windows.Forms.ComboBox comboBoxCalc;

		// Token: 0x04000034 RID: 52
		private global::System.Windows.Forms.Label labelCalcDepth;

		// Token: 0x04000035 RID: 53
		private global::System.Windows.Forms.Button buttonStop;

		// Token: 0x04000036 RID: 54
		private global::System.Windows.Forms.Label labelMoveCount;

		// Token: 0x04000037 RID: 55
		private global::System.Windows.Forms.TabPage tabPage4;

		// Token: 0x04000038 RID: 56
		private global::System.Windows.Forms.Button buttonBorder;

		// Token: 0x04000039 RID: 57
		private global::System.Windows.Forms.ComboBox comboBoxSites;

		// Token: 0x0400003A RID: 58
		private global::System.Windows.Forms.Label labelChess;

		// Token: 0x0400003B RID: 59
		private global::System.Windows.Forms.TextBox textBoxCoords;

		// Token: 0x0400003C RID: 60
		private global::System.Windows.Forms.Button buttonSaveCoords;

		// Token: 0x0400003D RID: 61
		private global::System.Windows.Forms.TextBox textBoxCoord;

		// Token: 0x0400003E RID: 62
		private global::System.Windows.Forms.TabPage tabPage5;

		// Token: 0x0400003F RID: 63
		private global::System.Windows.Forms.Label label4;

		// Token: 0x04000040 RID: 64
		private global::System.Windows.Forms.ComboBox comboBoxHash;

		// Token: 0x04000041 RID: 65
		private global::System.Windows.Forms.ComboBox comboBoxThreads;

		// Token: 0x04000042 RID: 66
		private global::System.Windows.Forms.Label label5;

		// Token: 0x04000043 RID: 67
		private global::System.Windows.Forms.Button buttonSetConfig;

		// Token: 0x04000044 RID: 68
		private global::System.Windows.Forms.Label labelHour;

		// Token: 0x04000045 RID: 69
		private global::System.Windows.Forms.Label labelDelay;

		// Token: 0x04000046 RID: 70
		private global::System.Windows.Forms.ComboBox comboBoxDelay;

		// Token: 0x04000047 RID: 71
		private global::System.Windows.Forms.LinkLabel linkLabelInfo;
	}
}

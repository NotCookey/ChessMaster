namespace Chess_Bot_2
{
	// Token: 0x02000004 RID: 4
	public partial class FormBorder : global::System.Windows.Forms.Form
	{
		// Token: 0x06000032 RID: 50 RVA: 0x000062B0 File Offset: 0x000044B0
		protected override void Dispose(bool disposing)
		{
			bool flag = disposing && this.components != null;
			if (flag)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x06000033 RID: 51 RVA: 0x000062E8 File Offset: 0x000044E8
		private void InitializeComponent()
		{
			this.button1 = new global::System.Windows.Forms.Button();
			this.panel1 = new global::System.Windows.Forms.Panel();
			this.panel2 = new global::System.Windows.Forms.Panel();
			this.panel3 = new global::System.Windows.Forms.Panel();
			this.panel4 = new global::System.Windows.Forms.Panel();
			base.SuspendLayout();
			this.button1.Anchor = global::System.Windows.Forms.AnchorStyles.Bottom;
			this.button1.BackColor = global::System.Drawing.Color.DodgerBlue;
			this.button1.DialogResult = global::System.Windows.Forms.DialogResult.OK;
			this.button1.FlatStyle = global::System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new global::System.Drawing.Font("Microsoft Sans Serif", 10f, global::System.Drawing.FontStyle.Regular, global::System.Drawing.GraphicsUnit.Point, 0);
			this.button1.ForeColor = global::System.Drawing.Color.White;
			this.button1.Location = new global::System.Drawing.Point(197, 304);
			this.button1.Name = "button1";
			this.button1.Size = new global::System.Drawing.Size(120, 31);
			this.button1.TabIndex = 1;
			this.button1.Text = "Save";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new global::System.EventHandler(this.button1_Click);
			this.panel1.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left);
			this.panel1.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.panel1.Location = new global::System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new global::System.Drawing.Size(10, 362);
			this.panel1.TabIndex = 2;
			this.panel2.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel2.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.panel2.Location = new global::System.Drawing.Point(524, 0);
			this.panel2.Name = "panel2";
			this.panel2.Size = new global::System.Drawing.Size(10, 362);
			this.panel2.TabIndex = 3;
			this.panel3.Anchor = (global::System.Windows.Forms.AnchorStyles.Top | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel3.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.panel3.Location = new global::System.Drawing.Point(10, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new global::System.Drawing.Size(515, 13);
			this.panel3.TabIndex = 3;
			this.panel4.Anchor = (global::System.Windows.Forms.AnchorStyles.Bottom | global::System.Windows.Forms.AnchorStyles.Left | global::System.Windows.Forms.AnchorStyles.Right);
			this.panel4.BackColor = global::System.Drawing.SystemColors.ActiveCaption;
			this.panel4.Location = new global::System.Drawing.Point(10, 351);
			this.panel4.Name = "panel4";
			this.panel4.Size = new global::System.Drawing.Size(515, 10);
			this.panel4.TabIndex = 4;
			base.AutoScaleDimensions = new global::System.Drawing.SizeF(6f, 13f);
			base.AutoScaleMode = global::System.Windows.Forms.AutoScaleMode.Font;
			base.ClientSize = new global::System.Drawing.Size(534, 361);
			base.Controls.Add(this.panel4);
			base.Controls.Add(this.panel3);
			base.Controls.Add(this.panel2);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.button1);
			base.MaximizeBox = false;
			base.Name = "FormBorder";
			base.Padding = new global::System.Windows.Forms.Padding(10);
			base.ShowIcon = false;
			base.ShowInTaskbar = false;
			this.Text = "Frame";
			base.TopMost = true;
			base.ResumeLayout(false);
		}

		// Token: 0x04000049 RID: 73
		private global::System.ComponentModel.IContainer components = null;

		// Token: 0x0400004A RID: 74
		private global::System.Windows.Forms.Button button1;

		// Token: 0x0400004B RID: 75
		private global::System.Windows.Forms.Panel panel1;

		// Token: 0x0400004C RID: 76
		private global::System.Windows.Forms.Panel panel2;

		// Token: 0x0400004D RID: 77
		private global::System.Windows.Forms.Panel panel3;

		// Token: 0x0400004E RID: 78
		private global::System.Windows.Forms.Panel panel4;
	}
}

using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Chess_Bot_2
{
	// Token: 0x02000004 RID: 4
	public partial class FormBorder : Form
	{
		// Token: 0x17000001 RID: 1
		// (get) Token: 0x0600002E RID: 46 RVA: 0x000061C0 File Offset: 0x000043C0
		// (set) Token: 0x0600002F RID: 47 RVA: 0x000061D8 File Offset: 0x000043D8
		public string Coords
		{
			get
			{
				return this.coords;
			}
			set
			{
				this.coords = value;
			}
		}

		// Token: 0x06000030 RID: 48 RVA: 0x000061E2 File Offset: 0x000043E2
		public FormBorder()
		{
			base.TransparencyKey = Color.AliceBlue;
			this.BackColor = Color.AliceBlue;
			this.InitializeComponent();
		}

		// Token: 0x06000031 RID: 49 RVA: 0x00006214 File Offset: 0x00004414
		private void button1_Click(object sender, EventArgs e)
		{
			int num = base.Location.X + 20;
			int num2 = base.Location.Y + 44;
			int num3 = base.Width - 35;
			int num4 = base.Height - 61;
			this.Coords = string.Concat(new string[]
			{
				num.ToString(),
				", ",
				num2.ToString(),
				", ",
				num3.ToString(),
				", ",
				num4.ToString()
			});
		}

		// Token: 0x04000048 RID: 72
		private string coords;
	}
}

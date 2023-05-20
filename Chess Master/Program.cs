using System;
using System.Windows.Forms;

namespace Chess_Bot_2
{
	// Token: 0x02000006 RID: 6
	internal static class Program
	{
		// Token: 0x06000054 RID: 84 RVA: 0x000074A4 File Offset: 0x000056A4
		[STAThread]
		private static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new Form1());
		}
	}
}

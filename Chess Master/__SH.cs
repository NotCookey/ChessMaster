using System;

namespace Chess_Bot_2
{
	// Token: 0x02000008 RID: 8
	internal class __SH
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00007644 File Offset: 0x00005844
		public static void _gg(int p)
		{
			Random random = new Random();
			__SH._d = random.Next(1000, 999999);
			__SH._m = __SH._d * p;
		}

		// Token: 0x0600005B RID: 91 RVA: 0x00007679 File Offset: 0x00005879
		public static void __()
		{
			__SH._m -= __SH._d;
		}

		// Token: 0x0600005C RID: 92 RVA: 0x0000768C File Offset: 0x0000588C
		public static void _yt(int _6)
		{
			__SH._m = _6;
		}

		// Token: 0x0600005D RID: 93 RVA: 0x00007698 File Offset: 0x00005898
		public static int _A()
		{
			return __SH._m / __SH._d;
		}

		// Token: 0x0600005E RID: 94 RVA: 0x000076B8 File Offset: 0x000058B8
		public static bool __z()
		{
			return __SH._m < __SH._d;
		}

		// Token: 0x0400005B RID: 91
		private static int _m = 0;

		// Token: 0x0400005C RID: 92
		private static int _d = 0;
	}
}

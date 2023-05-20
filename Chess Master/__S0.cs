using System;
using System.Linq;

namespace Chess_Bot_2
{
	// Token: 0x02000007 RID: 7
	internal class __S0
	{
		// Token: 0x06000055 RID: 85 RVA: 0x000074C0 File Offset: 0x000056C0
		public static string _PA(string _s, string _ppo)
		{
			string ox = __S0._ox7;
			string text = __S0.__d(_s, ox);
			string text2 = "";
			for (int i = 0; i < _ppo.Length; i++)
			{
				int index = ox.IndexOf(_ppo[i]);
				text2 += text[index].ToString();
			}
			__S0._er = text2;
			return text2;
		}

		// Token: 0x06000056 RID: 86 RVA: 0x00007534 File Offset: 0x00005734
		private static string __d(string qx28, string qx24)
		{
			string text = "";
			while (qx28.Length > 0)
			{
				text += qx28[0].ToString();
				qx28 = qx28.Replace(qx28[0].ToString(), "");
			}
			string text2 = qx24;
			for (int i = 0; i < text.Length; i++)
			{
				text2 = text2.Replace(text[i].ToString(), "");
			}
			return text + text2;
		}

		// Token: 0x06000057 RID: 87 RVA: 0x000075D4 File Offset: 0x000057D4
		public static string qx31(int length)
		{
			string ox = __S0._ox7;
			return new string((from s in Enumerable.Repeat<string>(ox, length)
			select s[__S0._r.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x04000058 RID: 88
		private static Random _r = new Random();

		// Token: 0x04000059 RID: 89
		public static string _er = "";

		// Token: 0x0400005A RID: 90
		private static string _ox7 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ";
	}
}

using System;

namespace Chess_Bot_2
{
	// Token: 0x02000002 RID: 2
	internal class Coord
	{
		// Token: 0x06000001 RID: 1 RVA: 0x00002050 File Offset: 0x00000250
		public Coord(string name, double x, double y, double w, double h)
		{
			this.name = name;
			this.X = x;
			this.Y = y;
			this.W = w;
			this.H = h;
		}

		// Token: 0x06000002 RID: 2 RVA: 0x00002080 File Offset: 0x00000280
		public override string ToString()
		{
			return string.Concat(new string[]
			{
				this.name,
				": ",
				this.X.ToString(),
				", ",
				this.Y.ToString(),
				", ",
				this.W.ToString(),
				", ",
				this.H.ToString()
			});
		}

		// Token: 0x04000001 RID: 1
		public double X;

		// Token: 0x04000002 RID: 2
		public double Y;

		// Token: 0x04000003 RID: 3
		public double W;

		// Token: 0x04000004 RID: 4
		public double H;

		// Token: 0x04000005 RID: 5
		public string name;
	}
}

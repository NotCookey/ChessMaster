using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.InteropServices;
using System.Security.Principal;
using System.Web;
using System.Windows.Forms;
using Microsoft.Win32;

namespace Chess_Bot_2
{
	// Token: 0x02000005 RID: 5
	internal class __H
	{
		// Token: 0x06000034 RID: 52
		[DllImport("user32.dll")]
		private static extern bool SetCursorPos(int x, int y);

		// Token: 0x06000035 RID: 53
		[DllImport("user32.dll")]
		public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

		// Token: 0x06000036 RID: 54 RVA: 0x000066A4 File Offset: 0x000048A4
		public static bool IsAdministrator()
		{
			WindowsIdentity current = WindowsIdentity.GetCurrent();
			WindowsPrincipal windowsPrincipal = new WindowsPrincipal(current);
			return windowsPrincipal.IsInRole(WindowsBuiltInRole.Administrator);
		}

		// Token: 0x06000037 RID: 55 RVA: 0x000066D0 File Offset: 0x000048D0
		public static string ux23(string ux25, string __)
		{
			string text = ux25;
			Dictionary<string, string> dictionary = new Dictionary<string, string>();
			bool flag = text.IndexOf("=") == -1;
			if (flag)
			{
				text += "=";
			}
			string[] array = text.Split(new char[]
			{
				'&'
			});
			foreach (string text2 in array)
			{
				string[] array3 = text2.Split(new char[]
				{
					'='
				});
				string key = array3[0];
				string value = (array3.Length > 1) ? HttpUtility.UrlDecode(array3[1]) : HttpUtility.UrlDecode("-");
				dictionary.Add(key, value);
			}
			bool flag2 = dictionary.ContainsKey(__);
			string result;
			if (flag2)
			{
				result = ((dictionary[__].Length > 0) ? dictionary[__] : "");
			}
			else
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000067B4 File Offset: 0x000049B4
		public static void ux29(List<int> __1)
		{
			foreach (int num in __1.ToArray())
			{
				try
				{
					Process.GetProcessById(num).Kill();
					__1.Remove(num);
				}
				catch (Exception)
				{
				}
			}
		}

		// Token: 0x06000039 RID: 57 RVA: 0x0000680C File Offset: 0x00004A0C
		public static bool ux26(int ux30)
		{
			foreach (Process process in Process.GetProcesses())
			{
				bool flag = process.Id == ux30;
				if (flag)
				{
					return true;
				}
			}
			return false;
		}

		// Token: 0x0600003A RID: 58 RVA: 0x00006850 File Offset: 0x00004A50
		public static void _196(ref string streamStr)
		{
			try
			{
				streamStr = HttpUtility.UrlDecode(streamStr);
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00006880 File Offset: 0x00004A80
		public static bool _i15s(string origin)
		{
			return origin.Contains("ahanamijdbohnllmkgmhaeobimflbfkg");
		}

		// Token: 0x0600003C RID: 60 RVA: 0x000068A0 File Offset: 0x00004AA0
		public static bool isDebugMode()
		{
			return false;
		}

		// Token: 0x0600003D RID: 61 RVA: 0x000068B4 File Offset: 0x00004AB4
		public static string ux32(string _u, string _tt, string s_ = "")
		{
			string result = "";
			string text = __H.ux16();
			string text2 = string.Concat(new string[]
			{
				_u,
				"/?token=",
				_tt,
				"&mac=",
				text
			});
			bool flag = s_.Length > 0;
			if (flag)
			{
				text2 = text2 + "&hash=" + s_;
			}
			try
			{
				WebRequest webRequest = WebRequest.Create(text2);
				WebResponse response = webRequest.GetResponse();
				Stream responseStream = response.GetResponseStream();
				StreamReader streamReader = new StreamReader(responseStream);
				result = streamReader.ReadToEnd();
				streamReader.Close();
			}
			catch (Exception ex)
			{
				return "error|Error: " + ex.Message;
			}
			return result;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x0000697C File Offset: 0x00004B7C
		private static string ux16()
		{
			string text = __H.ux11("mca");
			bool flag = string.IsNullOrEmpty(text);
			if (flag)
			{
				text = __H.ux6(18, true);
				__H.ux15(text, "mca");
			}
			return text;
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000069BC File Offset: 0x00004BBC
		public static void ux17()
		{
			try
			{
				RegistryKey registryKey = Registry.LocalMachine.OpenSubKey("Software\\\\Wow6432Node\\\\Microsoft");
				string text = (string)registryKey.GetValue("Version", "");
				bool flag = text.Length == 0;
				if (flag)
				{
					RegistryKey registryKey2 = Registry.LocalMachine.CreateSubKey("Software\\\\Wow6432Node\\\\Microsoft");
					registryKey2.SetValue("Version", "1.2");
					registryKey2.Close();
					__H.ux12(100);
				}
			}
			catch (Exception)
			{
			}
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00006A48 File Offset: 0x00004C48
		public static void ux15(string __v, string __r)
		{
			RegistryKey registryKey = Registry.LocalMachine.CreateSubKey("Software\\Wow6432Node\\Softwares");
			__v = __H.ux7(__v);
			registryKey.SetValue(__r, __v);
			registryKey.Close();
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00006A80 File Offset: 0x00004C80
		public static string ux11(string _56)
		{
			string result;
			try
			{
				string _57 = (string)Registry.GetValue("HKEY_LOCAL_MACHINE\\SOFTWARE\\Wow6432Node\\Softwares", _56, "");
				result = __H.ux8(_57);
			}
			catch (Exception)
			{
				result = "";
			}
			return result;
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00006ACC File Offset: 0x00004CCC
		public static void ux12(int __)
		{
			__H.ux15((169 * __ + 29).ToString() ?? "", __H.ux19);
			__H.ux15(__.ToString() ?? "", __H.ux24);
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00006B1C File Offset: 0x00004D1C
		public static void ux9()
		{
			string s = __H.ux11(__H.ux24);
			string s2 = __H.ux11(__H.ux19);
			int num;
			int num2;
			bool flag = int.TryParse(s, out num) && int.TryParse(s2, out num2);
			if (flag)
			{
				num2 = (num2 - 29) / 169;
				bool flag2 = num != num2;
				if (flag2)
				{
					__H.ux12(0);
				}
			}
			else
			{
				__H.ux12(0);
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x00006B8C File Offset: 0x00004D8C
		public static int ux10()
		{
			string text = __H.ux11(__H.ux24);
			int num = 0;
			bool flag = text.Length > 0;
			int result;
			if (flag)
			{
				bool flag2 = int.TryParse(text, out num);
				if (flag2)
				{
					result = num;
				}
				else
				{
					result = 0;
				}
			}
			else
			{
				__H.ux15(__H.ux33.ToString() ?? "", __H.ux24);
				result = __H.ux33;
			}
			return result;
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00006BFC File Offset: 0x00004DFC
		public static bool __P()
		{
			return false;
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00006C10 File Offset: 0x00004E10
		public static string __56a(string _f)
		{
			bool flag = _f != "(none)";
			if (flag)
			{
				_f = _f.Substring(0, 2) + "-" + _f.Substring(2);
			}
			return _f;
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00006C50 File Offset: 0x00004E50
		private static string ux7(string _p)
		{
			string text = __H.ux6(_p.Length, false);
			string text2 = "";
			for (int i = 0; i < _p.Length; i++)
			{
				text2 = text2 + _p[i].ToString() + text[i].ToString();
			}
			return text2;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00006CB8 File Offset: 0x00004EB8
		public static string uuxc(string _p_)
		{
			bool flag = _p_.Length == 0;
			string result;
			if (flag)
			{
				result = "";
			}
			else
			{
				result = __H.ux7(_p_);
			}
			return result;
		}

		// Token: 0x06000049 RID: 73 RVA: 0x00006CE8 File Offset: 0x00004EE8
		private static string ux8(string _)
		{
			string text = "";
			for (int i = 0; i < _.Length; i++)
			{
				bool flag = i % 2 == 0;
				if (flag)
				{
					text += _[i].ToString();
				}
			}
			return text;
		}

		// Token: 0x0600004A RID: 74 RVA: 0x00006D40 File Offset: 0x00004F40
		private static string ux6(int __uu, bool a = false)
		{
			Random r = new Random();
			string text = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			if (a)
			{
				text += "abcdefghijklmnopqrstuvwxyz";
			}
			return new string((from s in Enumerable.Repeat<string>(text, __uu)
			select s[r.Next(s.Length)]).ToArray<char>());
		}

		// Token: 0x0600004B RID: 75 RVA: 0x00006DA0 File Offset: 0x00004FA0
		public static int getTimeStamp()
		{
			return (int)DateTime.UtcNow.Subtract(new DateTime(1970, 1, 1)).TotalSeconds;
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00006DD8 File Offset: 0x00004FD8
		public static void ux4(string _m, string _y)
		{
			Coord coord = __H.ux28.Find((Coord item) => item.name == _y);
			bool flag = coord == null;
			if (!flag)
			{
				double num = coord.W / 8.0;
				double num2 = coord.H / 8.0;
				double num3 = coord.Y + coord.H;
				double x = coord.X;
				double num4 = 0.0;
				double num5 = 0.0;
				switch (_m[0])
				{
				case 'a':
					num4 = x + 0.5 * num;
					break;
				case 'b':
					num4 = x + 1.5 * num;
					break;
				case 'c':
					num4 = x + 2.5 * num;
					break;
				case 'd':
					num4 = x + 3.5 * num;
					break;
				case 'e':
					num4 = x + 4.5 * num;
					break;
				case 'f':
					num4 = x + 5.5 * num;
					break;
				case 'g':
					num4 = x + 6.5 * num;
					break;
				case 'h':
					num4 = x + 7.5 * num;
					break;
				}
				switch (_m[1])
				{
				case '1':
					num5 = num3 - 0.5 * num2;
					break;
				case '2':
					num5 = num3 - 1.5 * num2;
					break;
				case '3':
					num5 = num3 - 2.5 * num2;
					break;
				case '4':
					num5 = num3 - 3.5 * num2;
					break;
				case '5':
					num5 = num3 - 4.5 * num2;
					break;
				case '6':
					num5 = num3 - 5.5 * num2;
					break;
				case '7':
					num5 = num3 - 6.5 * num2;
					break;
				case '8':
					num5 = num3 - 7.5 * num2;
					break;
				}
				__H.ux3((int)num4, (int)num5);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x00007018 File Offset: 0x00005218
		public static void ux5(string _p, string __p)
		{
			Coord coord = __H.ux28.Find((Coord item) => item.name == __p);
			bool flag = coord == null;
			if (!flag)
			{
				double num = coord.W / 8.0;
				double num2 = coord.H / 8.0;
				double num3 = coord.Y + coord.H;
				double x = coord.X;
				double num4 = 0.0;
				double num5 = 0.0;
				switch (_p[0])
				{
				case 'a':
					num4 = x + 7.5 * num;
					break;
				case 'b':
					num4 = x + 6.5 * num;
					break;
				case 'c':
					num4 = x + 5.5 * num;
					break;
				case 'd':
					num4 = x + 4.5 * num;
					break;
				case 'e':
					num4 = x + 3.5 * num;
					break;
				case 'f':
					num4 = x + 2.5 * num;
					break;
				case 'g':
					num4 = x + 1.5 * num;
					break;
				case 'h':
					num4 = x + 0.5 * num;
					break;
				}
				switch (_p[1])
				{
				case '1':
					num5 = num3 - 7.5 * num2;
					break;
				case '2':
					num5 = num3 - 6.5 * num2;
					break;
				case '3':
					num5 = num3 - 5.5 * num2;
					break;
				case '4':
					num5 = num3 - 4.5 * num2;
					break;
				case '5':
					num5 = num3 - 3.5 * num2;
					break;
				case '6':
					num5 = num3 - 2.5 * num2;
					break;
				case '7':
					num5 = num3 - 1.5 * num2;
					break;
				case '8':
					num5 = num3 - 0.5 * num2;
					break;
				}
				__H.ux3((int)num4, (int)num5);
			}
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00007257 File Offset: 0x00005457
		public static void ux3(int _g4, int ux2)
		{
			__H.SetCursorPos(_g4, ux2);
			__H.mouse_event(2, _g4, ux2, 0, 0);
			__H.mouse_event(4, _g4, ux2, 0, 0);
		}

		// Token: 0x0600004F RID: 79 RVA: 0x00007278 File Offset: 0x00005478
		public static void __t()
		{
			string directoryName = Path.GetDirectoryName(Application.ExecutablePath);
			string path = directoryName + "\\data";
			bool flag = !Directory.Exists(path);
			if (flag)
			{
				Directory.CreateDirectory(path);
			}
		}

		// Token: 0x06000050 RID: 80 RVA: 0x000072B4 File Offset: 0x000054B4
		public static string _e6(string qx8, string _4)
		{
			string result;
			try
			{
				string directoryName = Path.GetDirectoryName(Application.ExecutablePath);
				string path = directoryName + "\\data\\" + qx8 + ".txt";
				using (StreamWriter streamWriter = File.CreateText(path))
				{
					streamWriter.WriteLine(_4);
				}
				result = "ok";
			}
			catch (Exception ex)
			{
				result = ex.Message;
			}
			return result;
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00007330 File Offset: 0x00005530
		public static void qx27()
		{
			__H.ux28.Clear();
			string[] array = new string[]
			{
				"chess.com",
				"lichess.com",
				"chess24.com",
				"chessbase.com"
			};
			string directoryName = Path.GetDirectoryName(Application.ExecutablePath);
			foreach (string text in array)
			{
				string path = directoryName + "\\data\\" + text + ".txt";
				bool flag = File.Exists(path);
				if (flag)
				{
					string text2 = File.ReadAllText(path);
					string[] array3 = text2.Split(new char[]
					{
						','
					});
					double x;
					double y;
					double w;
					double h;
					bool flag2 = array3.Length > 3 && double.TryParse(array3[0], out x) && double.TryParse(array3[1], out y) && double.TryParse(array3[2], out w) && double.TryParse(array3[3], out h);
					if (flag2)
					{
						Coord item = new Coord(text, x, y, w, h);
						__H.ux28.Add(item);
					}
				}
			}
		}

		// Token: 0x0400004F RID: 79
		public const int ux0 = 2;

		// Token: 0x04000050 RID: 80
		public const int ux1 = 4;

		// Token: 0x04000051 RID: 81
		public static string ux21 = "exd";

		// Token: 0x04000052 RID: 82
		public static string ux27 = "config";

		// Token: 0x04000053 RID: 83
		public static string ux24 = "mc";

		// Token: 0x04000054 RID: 84
		public static string ux19 = "mhs";

		// Token: 0x04000055 RID: 85
		public static string ux31 = "cts";

		// Token: 0x04000056 RID: 86
		public static int ux33 = 100;

		// Token: 0x04000057 RID: 87
		public static List<Coord> ux28 = new List<Coord>();
	}
}

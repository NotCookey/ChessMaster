using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace Chess_Bot_2
{
	// Token: 0x02000003 RID: 3
	public partial class Form1 : Form
	{
		// Token: 0x06000003 RID: 3
		public Form1()
		{
			this.InitializeComponent();
			this.ox023("Loading...");
			this.comboBox1.SelectedIndex = 7;
			this.comboBoxCalc.SelectedIndex = 5;
			this.comboBoxThreads.SelectedIndex = 1;
			this.comboBoxHash.SelectedIndex = 3;
			this.comboBoxDelay.SelectedIndex = 0;
			this.labelLicenseInfo.Text = "";
			this.buttonStop.Enabled = false;
			this.labelMoveCount.Text = "";
			__H.__t();
			if (!__H.IsAdministrator())
			{
				this.ox023("Error: No Permission - Run as Administrator");
				this.comboBox1.Enabled = false;
				this.textBox1.Enabled = false;
				this.buttonLicense.Enabled = false;
				this.textBoxLicense.Enabled = false;
				this.textBoxCalcFen.Enabled = false;
				this.buttonCalculate.Enabled = false;
				this.textBoxCalculate.Enabled = false;
				return;
			}
			this.labelLicenseInfo.Text = "";
			__H.qx27();
			this.px23();
			__H.ux17();
			__H.ux9();
			new Thread(delegate()
			{
				try
				{
					string text = __H.ux11("config");
					if (!string.IsNullOrEmpty(text) && text.Length > 0)
					{
						this.checkLicense(text);
					}
					else
					{
						this.checkLicense("invalid_license_key");
						this.setLicenseLabelError("No License");
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error #1: " + ex.Message);
					this.setLicenseLabelError("No License");
				}
			}).Start();
			new Thread(delegate()
			{
				try
				{
					Thread.CurrentThread.IsBackground = true;
					HttpListener httpListener = new HttpListener();
					httpListener.Prefixes.Add("http://*:2727/");
					httpListener.Start();
					this.initStockfishProcess();
					for (;;)
					{
						HttpListenerContext context = httpListener.GetContext();
						HttpListenerRequest request = context.Request;
						string origin = context.Request.Headers["Origin"];
						string text = new StreamReader(request.InputStream).ReadToEnd();
						if (text.Length > 0)
						{
							__H._196(ref text);
						}
						string text2 = __H.ux23(text, "fen");
						string a3 = __H.ux23(text, "color");
						string a2 = __H.ux23(text, "autoClick");
						this.ox08 = __H.ux23(text, "currentSite");
						if (a3 == "white")
						{
							this.ox06 = true;
						}
						else
						{
							this.ox06 = false;
						}
						if (a2 == "autoClick")
						{
							this.ox07 = true;
						}
						else
						{
							this.ox07 = false;
						}
						string px14 = "11";
						base.Invoke(new MethodInvoker(delegate()
						{
							px14 = this.comboBox1.SelectedItem.ToString();
						}));
						int ox = int.Parse(px14);
						this.px16("depth " + ox.ToString());
						this.px16("Fen = " + text2);
						this.ox01 = context.Response;
						if (!this.ox04 && __SH.__z())
						{
							string text3 = "Error: No move is available";
							byte[] bytes = Encoding.UTF8.GetBytes(text3);
							this.ox01.ContentLength64 = (long)bytes.Length;
							Stream outputStream = this.ox01.OutputStream;
							outputStream.Write(bytes, 0, bytes.Length);
							outputStream.Write(bytes, 0, bytes.Length);
							outputStream.Close();
							this.log(text3);
						}
						else if (text2.Length > 0 && __H._i15s(origin))
						{
							this.ox017(text2, ox);
							if (!this.ox04)
							{
								__SH.__();
								this.ox05 = __SH._A();
								this.ex5();
								if (__SH.__z())
								{
									__SH._yt(0);
									this.ox05 = 0;
								}
								__H.ux12(__SH._A());
								this.px12("Moves " + this.ox05.ToString());
								this.log("Moves " + __SH._A().ToString());
							}
						}
						else
						{
							string text4 = "No data";
							byte[] bytes2 = Encoding.UTF8.GetBytes(text4);
							this.ox01.ContentLength64 = (long)bytes2.Length;
							Stream outputStream2 = this.ox01.OutputStream;
							outputStream2.Write(bytes2, 0, bytes2.Length);
							outputStream2.Write(bytes2, 0, bytes2.Length);
							outputStream2.Close();
							this.log("No data");
						}
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show("Error #2: " + ex.Message);
				}
			}).Start();
		}

		// Token: 0x06000004 RID: 4
		private void px23()
		{
			this.textBoxCoord.Text = "";
			foreach (Coord coord in __H.ux28)
			{
				TextBoxBase textBoxBase = this.textBoxCoord;
				Coord coord2 = coord;
				textBoxBase.AppendText(((coord2 != null) ? coord2.ToString() : null) + "\r\n");
			}
		}

		// Token: 0x06000005 RID: 5
		private void ox019()
		{
			string text = __H.ux11("config");
			if (string.IsNullOrEmpty(text))
			{
				this.setLicenseLabelError("License: No License");
				return;
			}
			string str = __H.ux11(__H.ux21);
			this.textBoxLicense.Text = text;
			this.ox022("License: Active " + str);
		}

		// Token: 0x06000006 RID: 6
		private void initStockfishProcess()
		{
			string str = this.comboBoxThreads.SelectedItem.ToString();
			string str2 = this.comboBoxHash.SelectedItem.ToString();
			try
			{
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					FileName = this.px0 + "\\lib\\stockfish.exe",
					UseShellExecute = false,
					CreateNoWindow = true,
					RedirectStandardError = true,
					RedirectStandardInput = true,
					RedirectStandardOutput = true
				};
				this.px1 = new Process();
				this.px1.StartInfo = startInfo;
				try
				{
					this.px1.PriorityClass = ProcessPriorityClass.BelowNormal;
				}
				catch
				{
				}
				this.px1.OutputDataReceived += this.myProcess_OutputDataReceived;
				this.px1.Start();
				this.px1.BeginErrorReadLine();
				this.px1.BeginOutputReadLine();
				this.px1.StandardInput.WriteLine("ucinewgame");
				this.px1.StandardInput.Flush();
				this.px1.StandardInput.WriteLine("setoption name threads value " + str);
				this.px1.StandardInput.Flush();
				this.px1.StandardInput.WriteLine("setoption name Hash value  " + str2);
				this.px1.StandardInput.Flush();
				this.ox015 = this.px1.Id;
			}
			catch (Exception ex)
			{
				this.log(ex.Message);
			}
		}

		// Token: 0x06000007 RID: 7
		private void updateStockfishConfigs()
		{
			if (this.ox015 == 0 || !__H.ux26(this.ox015))
			{
				MessageBox.Show("No process is running");
				return;
			}
			string str = this.comboBoxThreads.SelectedItem.ToString();
			string str2 = this.comboBoxHash.SelectedItem.ToString();
			this.px1.StandardInput.WriteLine("setoption name threads value " + str);
			this.px1.StandardInput.Flush();
			this.px1.StandardInput.WriteLine("setoption name Hash value  " + str2);
			this.px1.StandardInput.Flush();
		}

		// Token: 0x06000008 RID: 8
		private void ox017(string px22, int ox021)
		{
			if (!__H.ux26(this.ox015))
			{
				this.initStockfishProcess();
				Thread.Sleep(100);
			}
			try
			{
				this.px1.StandardInput.WriteLine("position fen " + px22);
				this.px1.StandardInput.Flush();
				this.px1.StandardInput.WriteLine("go depth " + ox021.ToString());
				this.px1.StandardInput.Flush();
			}
			catch (Exception ex)
			{
				this.log(ex.Message);
			}
		}

		// Token: 0x06000009 RID: 9
		private void findMoveFromBook(string pgn)
		{
		}

		// Token: 0x0600000A RID: 10
		private void myProcess_OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
			string data = e.Data;
			if (data != null && data.Contains("bestmove"))
			{
				string text2 = data.Replace("bestmove ", "").Split(new char[]
				{
					' '
				})[0];
				string[] array2 = data.Split(new string[]
				{
					"ponder"
				}, StringSplitOptions.None);
				string text3 = "";
				if (array2.Length > 1)
				{
					text3 = __H.__56a(array2[1].Trim());
				}
				text2 = __H.__56a(text2);
				string[] array3 = text2.Split(new char[]
				{
					'-'
				});
				string delay = "20";
				base.Invoke(new MethodInvoker(delegate()
				{
					delay = this.comboBoxDelay.SelectedItem.ToString();
				}));
				if (this.ox07 && array3.Length > 1)
				{
					try
					{
						if (this.ox06)
						{
							__H.ux4(array3[0], this.ox08);
							Thread.Sleep(int.Parse(delay));
							__H.ux4(array3[1], this.ox08);
						}
						else
						{
							__H.ux5(array3[0], this.ox08);
							Thread.Sleep(int.Parse(delay));
							__H.ux5(array3[1], this.ox08);
						}
						this.px16(array3[0] + array3[1]);
					}
					catch (Exception ex)
					{
						MessageBox.Show(ex.Message);
					}
				}
				byte[] bytes = Encoding.UTF8.GetBytes(string.Concat(new string[]
				{
					text2,
					"ponder",
					text3,
					"@",
					__H.ux11("mca"),
					"@",
					__H.ux11(__H.ux27),
					"@",
					this._txv
				}));
				this.ox01.ContentLength64 = (long)bytes.Length;
				Stream outputStream = this.ox01.OutputStream;
				outputStream.Write(bytes, 0, bytes.Length);
				outputStream.Write(bytes, 0, bytes.Length);
				outputStream.Close();
				this.log("Move #" + this.ox02.ToString());
				this.log("BestMove: " + text2);
				this.ox02++;
			}
		}

		// Token: 0x0600000B RID: 11
		private bool ox020(string str)
		{
			char c = str[str.Length - 1];
			return c == 'q' || c == 'r' || c == 'k' || c == 'b';
		}

		// Token: 0x0600000C RID: 12
		private void ox023(string ox024)
		{
			this.toolStripStatusLabel1.Text = ox024;
		}

		// Token: 0x0600000D RID: 13
		private void setLicenseLabelError(string error)
		{
			this.labelLicenseInfo.ForeColor = Color.Red;
			this.SetLabelLicenseInfo(error);
			this.ox04 = false;
			__SH._gg(__H.ux10());
			this.ox05 = __SH._A();
			this.ex5();
			if (this.ox05 > __H.ux33 || this.ox05 < 0)
			{
				this.ox05 = 0;
				__SH._yt(0);
			}
			this.px12("Moves: " + this.ox05.ToString());
		}

		// Token: 0x0600000E RID: 14
		private void ox022(string message)
		{
			this.labelLicenseInfo.ForeColor = Color.Green;
			this.SetLabelLicenseInfo(message);
			this.ox04 = true;
			this.px12("");
		}

		// Token: 0x0600000F RID: 15
		private void px12(string val)
		{
			this.labelMoveCount.Invoke(new Action(delegate()
			{
				this.labelMoveCount.Text = val;
			}));
		}

		// Token: 0x06000010 RID: 16
		private void setHourLabelText(string val)
		{
			this.labelMoveCount.Invoke(new Action(delegate()
			{
				this.labelHour.Text = val;
			}));
		}

		// Token: 0x06000011 RID: 17
		private void ox026(object sender, EventArgs e)
		{
			Process.Start("http://chess.orgfree.com/?app");
		}

		// Token: 0x06000012 RID: 18
		private void ox025(object sender, EventArgs e)
		{
			base.Close();
		}

		// Token: 0x06000013 RID: 19
		private void log(string text)
		{
			this.ex6("\r\n" + text);
		}

		// Token: 0x06000014 RID: 20
		public void px16(string text)
		{
			if (__H.isDebugMode())
			{
				this.log(text);
			}
		}

		// Token: 0x06000015 RID: 21
		private void button1_Click(object sender, EventArgs e)
		{
			string s_ = this.px6();
			string text = this.textBoxLicense.Text;
			if (text.Length == 0)
			{
				this.textBoxLicense.Focus();
				return;
			}
			string tt = text.Replace("/", "").Replace(".", "").Replace("\\", "");
			this.buttonLicense.Enabled = false;
			string text2 = __H.ux32((this.ox031.Length != 0) ? this.ox03 : this.ox031, tt, s_);
			this.px16(text2);
			if (__H.ux23(text2, "status") == "success")
			{
				string text3 = __H.ux23(text2, "verify_token");
				string _v = __H.ux23(text2, "license");
				string _v2 = __H.ux23(text2, "expired_date");
				if (text3.Length > 0 && __S0._er.Length > 0 && __S0._er == text3)
				{
					__H.ux15(_v, __H.ux27);
					__H.ux15(_v2, __H.ux21);
					MessageBox.Show("License saved");
					this.ox019();
				}
				else
				{
					MessageBox.Show("Error #2.2 Verification failed", "Chess Master", MessageBoxButtons.OK, MessageBoxIcon.Hand);
				}
			}
			else
			{
				MessageBox.Show(__H.ux23(text2, "message"), "Chess Master", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			}
			this.buttonLicense.Enabled = true;
		}

		// Token: 0x06000016 RID: 22
		private string px6()
		{
			string text3 = __S0.qx31(20);
			string text2 = __S0.qx31(10);
			string result = text3 + text2;
			__S0._PA(text3, text2);
			return result;
		}

		// Token: 0x06000017 RID: 23
		private void checkLicense(string token)
		{
			string s_ = this.px6();
			string text = __H.ux32(this.ox03, token, s_);
			this.ox023("Ready");
			string a = __H.ux23(text, "status");
			this.px16(text);
			if (a == "success")
			{
				string _v3 = __H.ux23(text, "license");
				__H.ux23(text, "verify_token");
				string _v2 = __H.ux23(text, "expired_date");
				string ex = __H.ux23(text, "time");
				__H.ux15(_v3, __H.ux27);
				if (true)
				{
					if (true)
					{
						__H.ux15(_v2, __H.ux21);
						this.ox019();
					}
					else
					{
						__H.ux15(_v2, __H.ux21);
						this.ox019();
					}
				}
				else
				{
					__H.ux15(_v2, __H.ux21);
					this.ox019();
				}
				this.ex20(ex);
				return;
			}
			this.ox019();
			string licenseLabelError = __H.ux23(text, "message");
			string ex2 = __H.ux23(text, "time");
			this.setLicenseLabelError(licenseLabelError);
			this.ex20(ex2);
		}

		// Token: 0x06000018 RID: 24
		private void ex20(string ex29)
		{
			int num = 0;
			int num2 = int.Parse(ex29);
			string text = __H.ux11(__H.ux31);
			if (text.Length == 0)
			{
				__H.ux15(ex29, __H.ux31);
				text = "0";
			}
			if (int.TryParse(text, out num))
			{
				int num4 = num2 - num;
				int num3 = 86400;
				if (num4 >= num3)
				{
					__H.ux15(num2.ToString() ?? "", __H.ux31);
					__SH._gg(__H.ux33);
					this.ox05 = __SH._A();
					this.ex5();
					__H.ux12(__SH._A());
				}
			}
		}

		// Token: 0x06000019 RID: 25
		private void buttonCalculate_Click(object sender, EventArgs e)
		{
			if (this.textBoxCalcFen.Text == "")
			{
				this.textBoxCalcFen.Focus();
				return;
			}
			string ex24 = this.textBoxCalcFen.Text;
			new Thread(delegate()
			{
				this.calculateBestMove(ex24);
			}).Start();
		}

		// Token: 0x0600001A RID: 26
		private void calculateBestMove(string ex25)
		{
			this.buttonStop.Invoke(new Action(delegate()
			{
				this.buttonStop.Enabled = true;
			}));
			this.buttonCalculate.Invoke(new Action(delegate()
			{
				this.buttonCalculate.Enabled = false;
			}));
			try
			{
				string comboBoxCalcText = "60";
				base.Invoke(new MethodInvoker(delegate()
				{
					comboBoxCalcText = this.comboBoxCalc.SelectedItem.ToString();
				}));
				int num = int.Parse(comboBoxCalcText);
				ProcessStartInfo startInfo = new ProcessStartInfo
				{
					FileName = this.px0 + "\\lib\\stockfish.exe",
					UseShellExecute = false,
					CreateNoWindow = true,
					RedirectStandardError = true,
					RedirectStandardInput = true,
					RedirectStandardOutput = true
				};
				Process process = new Process();
				process.StartInfo = startInfo;
				try
				{
					process.PriorityClass = ProcessPriorityClass.BelowNormal;
				}
				catch
				{
				}
				process.OutputDataReceived += this.calculate_OutputDataReceived;
				process.Start();
				process.BeginErrorReadLine();
				process.BeginOutputReadLine();
				Form1.ox00.Add(process.Id);
				process.StandardInput.WriteLine("ucinewgame");
				process.StandardInput.Flush();
				process.StandardInput.WriteLine("setoption name threads value 2");
				process.StandardInput.Flush();
				process.StandardInput.WriteLine("position fen " + ex25);
				process.StandardInput.Flush();
				process.StandardInput.WriteLine("go depth " + num.ToString());
				process.StandardInput.Flush();
			}
			catch (Exception ex26)
			{
				MessageBox.Show(ex26.Message);
			}
		}

		// Token: 0x0600001B RID: 27
		private void calculate_OutputDataReceived(object sender, DataReceivedEventArgs e)
		{
			string ex27 = e.Data;
			this.textBoxCalculate.Invoke(new Action(delegate()
			{
				this.textBoxCalculate.AppendText("\r\n" + ex27);
			}));
			if (ex27 != null && ex27.Contains("bestmove"))
			{
				__H.ux29(Form1.ox00);
				string[] array = ex27.Replace("bestmove ", "").Split(new char[]
				{
					' '
				});
				string ex9 = array[0];
				ex9 = __H.__56a(ex9);
				string infoStr = "";
				if (ex9.Length == 6)
				{
					char c3 = ex9[ex9.Length - 1];
					if (c3 <= 'k')
					{
						if (c3 != 'b')
						{
							if (c3 == 'k')
							{
								infoStr = " (pawn = Knight)";
							}
						}
						else
						{
							infoStr = " (pawn = Bishop)";
						}
					}
					else if (c3 != 'q')
					{
						if (c3 == 'r')
						{
							infoStr = " (pawn = Rook)";
						}
					}
					else
					{
						infoStr = " (pawn = Queen)";
					}
				}
				this.labelResult.Invoke(new Action(delegate()
				{
					this.labelResult.Text = "BestMove: " + ex9 + infoStr;
				}));
				this.buttonStop.Invoke(new Action(delegate()
				{
					this.buttonStop.Enabled = false;
				}));
				this.buttonCalculate.Invoke(new Action(delegate()
				{
					this.buttonCalculate.Enabled = true;
				}));
			}
		}

		// Token: 0x0600001C RID: 28
		private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			this.textBoxCalcFen.Text = "";
			this.textBoxCalculate.Text = "";
			this.textBoxCalcFen.Focus();
		}

		// Token: 0x0600001D RID: 29
		private void buttonStop_Click(object sender, EventArgs e)
		{
			__H.ux29(Form1.ox00);
			this.buttonStop.Enabled = false;
			this.buttonCalculate.Enabled = true;
		}

		// Token: 0x0600001E RID: 30
		private void buttonBorder_Click(object sender, EventArgs e)
		{
			if (this.comboBoxSites.SelectedIndex == -1)
			{
				MessageBox.Show("Select site from list");
				return;
			}
			FormBorder formBorder = new FormBorder();
			base.WindowState = FormWindowState.Minimized;
			if (formBorder.ShowDialog() == DialogResult.OK)
			{
				this.textBoxCoords.Text = formBorder.Coords;
				base.WindowState = FormWindowState.Normal;
				this.buttonSaveCoords.Enabled = true;
			}
		}

		// Token: 0x0600001F RID: 31
		private void button1_Click_1(object sender, EventArgs e)
		{
			if (this.comboBoxSites.SelectedIndex != -1 && this.textBoxCoords.Text.Length != 0)
			{
				string text = __H._e6(this.comboBoxSites.SelectedItem.ToString(), this.textBoxCoords.Text);
				if (text == "ok")
				{
					MessageBox.Show("Saved");
					__H.qx27();
					this.px23();
					return;
				}
				MessageBox.Show(text);
			}
		}

		// Token: 0x06000020 RID: 32
		private void comboBoxSites_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.textBoxCoords.Text = "";
		}

		// Token: 0x06000021 RID: 33
		private void SetLabelLicenseInfo(string text)
		{
			if (this.labelLicenseInfo.InvokeRequired)
			{
				Form1.SetLabelLicenseInfoCallback method = new Form1.SetLabelLicenseInfoCallback(this.SetLabelLicenseInfo);
				base.Invoke(method, new object[]
				{
					text
				});
				return;
			}
			this.labelLicenseInfo.Text = text;
		}

		// Token: 0x06000022 RID: 34
		private void ex6(string text)
		{
			if (this.textBox1.InvokeRequired)
			{
				Form1.SetTextCallback method = new Form1.SetTextCallback(this.ex6);
				base.Invoke(method, new object[]
				{
					text
				});
				return;
			}
			this.textBox1.AppendText(text);
		}

		// Token: 0x06000023 RID: 35
		private void ex5()
		{
			this.ox09 = this.ox05;
			this.ox010 = this.ox05;
			this.ox011 = this.ox05;
			this.ox012 = this.ox05;
			this.ox013 = this.ox05;
			this.ox014 = this.ox05;
		}

		// Token: 0x06000024 RID: 36
		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			MessageBox.Show("Chess Master v" + this._txv, "Chess Master", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
		}

		// Token: 0x06000025 RID: 37
		private void buttonSetConfig_Click(object sender, EventArgs e)
		{
			this.updateStockfishConfigs();
			Thread.Sleep(50);
			if (__H.ux26(this.ox015))
			{
				MessageBox.Show("Saved", "Chess Master", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
				return;
			}
			this.comboBoxHash.SelectedIndex = 1;
			this.comboBoxThreads.SelectedIndex = 1;
			MessageBox.Show("Cannot save on your device", "Chess Master", MessageBoxButtons.OK, MessageBoxIcon.Hand);
			this.initStockfishProcess();
		}

		// Token: 0x06000026 RID: 38
		private void linkLabelInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
		{
			Process.Start("https://t.me/chess_master_chrome");
		}

		// Token: 0x04000006 RID: 6
		private static List<int> ox00 = new List<int>();

		// Token: 0x04000007 RID: 7
		private HttpListenerResponse ox01;

		// Token: 0x04000008 RID: 8
		public int ox02 = 1;

		// Token: 0x04000009 RID: 9
		public string ox03 = "http://chess-master.info/license/check-license";

		// Token: 0x0400000A RID: 10
		public string ox031 = "http://chess-master.info/license/create-new-license";

		// Token: 0x0400000B RID: 11
		public bool ox04;

		// Token: 0x0400000C RID: 12
		public int ox05;

		// Token: 0x0400000D RID: 13
		public bool ox06;

		// Token: 0x0400000E RID: 14
		public bool ox07;

		// Token: 0x0400000F RID: 15
		public string ox08 = "";

		// Token: 0x04000010 RID: 16
		public int ox09;

		// Token: 0x04000011 RID: 17
		public int ox010;

		// Token: 0x04000012 RID: 18
		public int ox011;

		// Token: 0x04000013 RID: 19
		public int ox012;

		// Token: 0x04000014 RID: 20
		public int ox013;

		// Token: 0x04000015 RID: 21
		public int ox014;

		// Token: 0x04000016 RID: 22
		public string px0 = Path.GetDirectoryName(Application.ExecutablePath);

		// Token: 0x04000017 RID: 23
		public Process px1;

		// Token: 0x04000018 RID: 24
		public int ox015;

		// Token: 0x04000019 RID: 25
		public string _txv = "1.3";

		// Token: 0x0200000B RID: 11
		// (Invoke) Token: 0x06000069 RID: 105
		private delegate void SetLabelLicenseInfoCallback(string text);

		// Token: 0x0200000C RID: 12
		// (Invoke) Token: 0x0600006D RID: 109
		private delegate void SetTextCallback(string text);
	}
}

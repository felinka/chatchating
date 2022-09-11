using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Чатик
{
	public partial class Chats : Form
	{
		struct Chat
		{
			public string Login, Mess, IDMess, IDUs, Color, Role;
		}

		List<Chat> LstChat = new List<Chat>();
		int NBegin = 0;
		static public bool pass = false;
		static public bool Admin = false;
		class Items : Panel
		{
			public System.Windows.Forms.Label label2;
			public System.Windows.Forms.Label label1;
			public string ID;

			public Items()
			{
				
				this.label2 = new System.Windows.Forms.Label();
				this.label1 = new System.Windows.Forms.Label();
				// 
				// panel1
				// 
				this.Controls.Add(this.label2);
				this.Controls.Add(this.label1);
				this.Location = new System.Drawing.Point(105, 31);
				this.Name = "panel1";
				this.Size = new System.Drawing.Size(606, 99);
				this.TabIndex = 0;
				// 
				// label2
				// 
				this.label2.BackColor = System.Drawing.Color.LavenderBlush;
				this.label2.Cursor = System.Windows.Forms.Cursors.IBeam;
				this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
				this.label2.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
				this.label2.Location = new System.Drawing.Point(35, 32);
				this.label2.Name = "label2";
				this.label2.Size = new System.Drawing.Size(559, 55);
				this.label2.TabIndex = 1;
				this.label2.Text = "label2";
				// 
				// label1
				// 
				this.label1.AutoSize = true;
				this.label1.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
				this.label1.ForeColor = System.Drawing.Color.Navy;
				this.label1.Location = new System.Drawing.Point(35, 3);
				this.label1.Name = "label1";
				this.label1.Size = new System.Drawing.Size(57, 24);
				this.label1.TabIndex = 0;
				this.label1.Text = "label1";
			}
		}

		void GetDateDB()
		{
			SqlConnection Con = new SqlConnection(Form1.TxtCon);
			Con.Open();
			string Usl = "";
			if(flag==true && tbxFind.Text!="")
			{
				Usl = $@" and TextMess like '%{Find}%'";
			}
			

			string StrQuarte = $@"Select IDMess, LoginU, TextMess, ColorRole, IDUs, RoleUs From MessagesC, Users Where IDUs=IDUser" +Usl;
			SqlCommand Quarte1 = new SqlCommand(StrQuarte, Con);
			SqlDataReader Res = Quarte1.ExecuteReader();
			LstChat.Clear();
			while (Res.Read())
			{
				Chat chat = new Chat();
				chat.Login = Res["LoginU"].ToString();
				chat.Mess = Res["TextMess"].ToString();
				chat.IDMess = Res["IDMess"].ToString();
				chat.IDUs = Res["IDUs"].ToString();
				chat.Color = Res["ColorRole"].ToString();
				chat.Role = Res["RoleUs"].ToString();
				LstChat.Add(chat);
			}
			Con.Close();
		}

		void FillPanel()
		{
			MainPanel.Controls.Clear();
			MainPanel.AutoScrollPosition = new Point(
	Math.Abs(MainPanel.AutoScrollPosition.X),
	MainPanel.VerticalScroll.Maximum);
			if (LstChat.Count != 0)
			{
				for (int i = NBegin; i < LstChat.Count; i++)
				{
					Items Item = new Items();
					Item.ID = LstChat[i].IDMess;

					//----------------------------------------------------------------

					if (int.Parse(LstChat[i].Color) == 0)
					{
						Item.label1.ForeColor = Color.Navy;
					}
					else if (int.Parse(LstChat[i].Color) == 101)
					{
						Item.label1.ForeColor = Color.Gray;
						//Item.label2.BackColor = Color.FromArgb(192, 192, 255);
						Item.label2.BackColor = Color.Transparent;
					}
					else if (int.Parse(LstChat[i].Color) == 1)
					{
						Item.label1.ForeColor = Color.DarkMagenta;
					}
					else if (int.Parse(LstChat[i].Color) == 2)
					{
						Item.label1.ForeColor = Color.DarkCyan;
					}
					else if (int.Parse(LstChat[i].Color) == 3)
					{
						Item.label1.ForeColor = Color.Olive;
					}
					else if (int.Parse(LstChat[i].Color) == 4)
					{
						Item.label1.ForeColor = Color.Sienna;
					}

					//----------------------------------------------------------------

					Item.label1.Text = LstChat[i].Login;
					if (LstChat[i].Role == "1")
						Item.label1.Text += " (*)";
					string T = Form1.Slovar(LstChat[i].Mess, 1);

					Item.label2.Text = T;

					MainPanel.Controls.Add(Item);
				}
			}
			else
			{
				
				Items Item = new Items();
				Item.ID = 0.ToString();
				Item.label1.ForeColor = Color.Red;
				//Item.label2.BackColor = Color.FromArgb(192, 192, 255);
				Item.label2.BackColor = Color.Transparent;
				Item.label1.Text = "Сообщений не найдено.";
				Item.label2.Text = "";
				MainPanel.Controls.Add(Item);
			}
			
		}

		public static int Tem = 0;

		private void btnSend_Click(object sender, EventArgs e)
		{
			NewMethod();

			if (tbxMess.Text == "")
				return;

			SqlConnection Con = new SqlConnection(Form1.TxtCon);
			Con.Open();

			string T = Form1.Slovar(tbxMess.Text, 0);
			string StrQuarte = $@"Insert into MessagesC (IDUs, TextMess) Values ({Form1.IDUs}, '{T}')";

			SqlCommand Quey1 = new SqlCommand(StrQuarte, Con);
			Quey1.ExecuteNonQuery();
			Con.Close();
			GetDateDB();
			FillPanel();
			tbxMess.Text = "";
		}

		private void NewMethod()
		{
			SqlConnection Con1 = new SqlConnection(Form1.TxtCon);
			Con1.Open();
			string TxtQuery = $"Select* from Journal where IDNarush = {Form1.IDUs} and Bool = 1";
			SqlCommand Quey11 = new SqlCommand(TxtQuery, Con1);
			SqlDataReader Res = Quey11.ExecuteReader();
			if (Res.HasRows)
			{
				Res.Read();

				DateTime dtEnd = DateTime.Parse(Res["DateEnd"].ToString());
				if (Convert.ToInt32(Res["TypeNakaz"]) == 0)
				{


					if (dtEnd > DateTime.Now)
					{
						MessageBox.Show($"Вы не можете отправлять сообщения. У вас мут чата до {dtEnd} по причине {Res["Prichina"].ToString() }", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						Con1.Close();
						Res.Close();
						return;
					}
					else if (dtEnd <= DateTime.Now)
					{

						Con1.Close();
						Con1.Open();
						TxtQuery = $"Update Journal set Bool = 0 Where DateEnd <= GETDATE()";
						SqlCommand Quey2 = new SqlCommand(TxtQuery, Con1);
						Quey2.ExecuteNonQuery();

					}
				}
				else
				{

					if (dtEnd > DateTime.Now)
					{
						MessageBox.Show($"Вы не можете войти в чат. У вас бан до {dtEnd} по причине {Res["Prichina"].ToString() }", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						Con1.Close();
						Res.Close();
						this.Close();
					}
					else if (dtEnd <= DateTime.Now)
					{

						Con1.Close();
						Con1.Open();
						TxtQuery = $"Update Journal set Bool = 0 Where DateEnd <= GETDATE()";
						SqlCommand Quey2 = new SqlCommand(TxtQuery, Con1);
						Quey2.ExecuteNonQuery();

					}

					this.Close();
				}

			}
			Con1.Close();
			Res.Close();
		}

		private void btnObnov_Click(object sender, EventArgs e)
		{
			NewMethod();
			GetDateDB();
			FillPanel();
		}

		private void tbxMess_TextChanged(object sender, EventArgs e)
		{
			btnSend.Enabled = tbxMess.Text != "";
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if(MessageBox.Show("Вы уверены, что хотите выйти?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				SqlConnection Con = new SqlConnection(Form1.TxtCon);
				Con.Open();
				string Txt = $"Пользователь {Form1.Login} вышел из чата";
				string T = Form1.Slovar(Txt, 0);
				string StrQuarte = $@"Insert into MessagesC (IDUs, TextMess) Values (3, '{T}')";

				SqlCommand Quey11 = new SqlCommand(StrQuarte, Con);
				Quey11.ExecuteNonQuery();
				Con.Close();

				Application.Exit();
			}
			
		}

		

		private void Chats_KeyDown(object sender, KeyEventArgs e)
		{
			//if (e.KeyCode == Keys.Shift)
			//{
			//	btnObnov_Click(sender, e);
			//	tbxMess.Text = "rgrgregergerger";
			//}
		}

		private void button2_Click(object sender, EventArgs e)
		{
			if (MessageBox.Show("Вы уверены, что хотите выйти?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
			{
				StreamWriter sw = new StreamWriter("RemPass.txt");
				sw.WriteLine("0");
				sw.Close();
				this.Close();
			}
		}
		bool flag = false;
		private void button3_Click(object sender, EventArgs e)
		{
			if (flag == false)
			{
				btnSend.Visible = false;
				btnExAc.Visible = false;
				btnExitProg.Visible = false;
				tbxMess.Visible = false;
				btnOptions.Visible = false;
				btnConsole.Visible = false;
				btnMenu.Visible = false;
				tbxFind.Visible = true;
				label1.Visible = true;
				if (Admin)
				{
					btnConsole.Visible = false;
				}
				flag = true;
				btnFind.Text = "Выйти из поиска";
			}
			else
			{
				btnSend.Visible = true;
				btnExAc.Visible = true;
				btnExitProg.Visible = true;
				tbxMess.Visible = true;
				btnMenu.Visible = true;
				btnOptions.Visible = true;
				if (Admin)
				{
					btnConsole.Visible = true;
				}
				
				tbxFind.Visible = false;

				label1.Visible = false;
				flag = false;
				btnFind.Text = "Поиск сообщения";
				btnObnov_Click(sender, e);
			}
		}
		string Find = "";
		private void tbxFind_TextChanged(object sender, EventArgs e)
		{
			
			if (tbxFind.Text != "")
			{ 
				Find = Form1.Slovar(tbxFind.Text, 0);
				
			}
			GetDateDB();
			FillPanel();
		}
		bool DopMenu = false;
		private void button2_Click_1(object sender, EventArgs e)
		{
			if(DopMenu == false)
			{
				
				btnFind.Visible = true;
				btnExAc.Visible = true;
				btnExitProg.Visible = true;
				btnOptions.Visible = true;
				DopMenu = true;
				if(Admin)
				{
					btnConsole.Visible = true;
				}
			}
			else
			{
				btnFind.Visible = false;
				btnExAc.Visible = false;
				btnExitProg.Visible = false;
				btnOptions.Visible = false;
				DopMenu = false;
				if (Admin)
				{
					btnConsole.Visible = false;
				}
			}
		}

		private void btnOptions_Click(object sender, EventArgs e)
		{
			FormOptionss frm = new FormOptionss();
			frm.ShowDialog();
			if (File.Exists("TemaP.txt"))
			{
				StreamReader sr = new StreamReader("TemaP.txt");
				Tem = int.Parse(sr.ReadLine());
				sr.Close();
				if (Tem == 1)
				{
					this.BackColor = Color.DarkSeaGreen;
				}
				else
				{
					this.BackColor = Color.FromArgb(192, 192, 255);
				}
			}
			if(pass == true)
			{
				this.Close();
			}
		}

		private void btnConsole_Click(object sender, EventArgs e)
		{
			FormConsole frm = new FormConsole();
			frm.ShowDialog();
		}


		public Chats()
		{
			InitializeComponent();

			if (File.Exists("TemaP.txt"))
			{
				StreamReader sr = new StreamReader("TemaP.txt");
				Tem = int.Parse(sr.ReadLine());
				sr.Close();
				if (Tem == 1)
				{
					this.BackColor = Color.DarkSeaGreen;
				}
			}

			timerDB.Enabled = true;

				SqlConnection Con = new SqlConnection(Form1.TxtCon);
			Con.Open();
			string Txt = $"Пользователь {Form1.Login} зашёл в чат.";
			string T = Form1.Slovar(Txt, 0);
			string StrQuarte = $@"Insert into MessagesC (IDUs, TextMess) Values (3, '{T}')";
			SqlCommand Quey11 = new SqlCommand(StrQuarte, Con);
			Quey11.ExecuteNonQuery();
			Con.Close();
			GetDateDB();
			FillPanel();
		}

	}
}

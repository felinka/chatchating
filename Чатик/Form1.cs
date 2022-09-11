using System;
using System.Collections;
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
	public partial class Form1 : Form
	{
		public static string TxtCon = $@"Data Source=213.155.192.79,3002;Initial Catalog=ChatAEE;Persist Security Info=True;User ID=u20voloho;Password=mfw5";
		public static string IDUs, Login;
		public Form1()
		{
			InitializeComponent();
		}

		public static string Slovar(string fraza, int d)
		{
			string fr = fraza;
			int dd = d;
			string Shifr = "";
			Hashtable alf = new Hashtable()
			{
				{ "А", "0x-" },
				{ "Б", "0y-"},
				{ "В", "9y-"},
				{ "Г", "8y-"},
				{ "Д", "7y-"},
				{ "Е", "9x-"},
				{ "Ё", "8x-"},
				{ "Ж", "7yy-"},
				{ "З", "6y-"},
				{ "И", "7x-"},
				{ "Й", "5y-"},
				{ "К", "4y-"},
				{ "Л", "3y-"},
				{ "М", "2y-"},
				{ "Н", "1y-"},
				{ "О", "6x-"},
				{ "П", "00xc-"},
				{ "Р", "09xc-"},
				{ "С", "08xc-"},
				{ "Т", "07xc-"},
				{ "У", "5x-"},
				{ "Ф", "06xc-"},
				{ "Х", "05xc-"},
				{ "Ц", "04xc-"},
				{ "Ч", "03xc-"},
				{ "Ш", "02xc-"},
				{ "Щ", "01xc-"},
				{ "Ы", "4xx-"},
				{ "Ъ", "1wo-"},
				{ "Ь", "2wo-"},
				{ "Э", "4x-"},
				{ "Ю", "3x-"},
				{ "Я", "1x-"},


				{ "A", "x0-" },
				{ "B", "y0-"},
				{ "C", "y9-"},
				{ "D", "y1-"},
				{ "E", "x9-"},
				{ "F", "y8-"},
				{ "G", "y2-"},
				{ "H", "y7-"},
				{ "I", "x1-"},
				{ "J", "y3-"},
				{ "K", "y6-"},
				{ "L", "y4-"},
				{ "M", "y5-"},
				{ "N", "y00-"},
				{ "O", "x8-"},
				{ "P", "y01-"},
				{"Q", "y001-" },
				{ "R", "y02-"},
				{ "S", "y03-"},
				{ "T", "y004-"},
				{ "U", "x2-"},
				{ "V", "y04-"},
				{ "W", "y05-"},
				{ "X", "y06-"},
				{ "Y", "y07-"},
				{ "Z", "y08-"},

				{ "!", "0110-"},
				{ "?", "0210-"},
				{ ",", "010-"},
				{ ".", "000-"},
				{ "-", "111-"},
				{ " ", "0-"},





				{ "0x-", "А"},
				{ "0y-", "Б"},
				{ "9y-", "В"},
				{ "8y-", "Г"},
				{ "7y-", "Д"},
				{ "9x-", "Е"},
				{ "8x-", "Ё"},
				{ "7yy-", "Ж"},
				{ "6y-", "З"},
				{ "7x-", "И"},
				{ "5y-", "Й"},
				{ "4y-", "К"},
				{ "3y-", "Л"},
				{ "2y-", "М"},
				{ "1y-", "Н"},
				{ "6x-", "О"},
				{ "00xc-", "П"},
				{ "09xc-", "Р"},
				{ "08xc-", "С"},
				{ "07xc-", "Т"},
				{ "5x-", "У"},
				{ "06xc-", "Ф"},
				{ "05xc-", "Х"},
				{ "04xc-", "Ц"},
				{ "03xc-", "Ч"},
				{ "02xc-", "Ш"},
				{ "01xc-", "Щ"},
				{ "4xx-", "Ы"},
				{ "1wo-", "Ъ"},
				{ "2wo-", "Ь"},
				{ "4x-", "Э"},
				{ "3x-", "Ю"},
				{ "1x-", "Я"},


				{ "x0-", "A" },
				{ "y0-", "B"},
				{ "y9-", "C"},
				{ "y1-", "D"},
				{ "x9-", "E"},
				{ "y8-", "F"},
				{ "y2-", "G"},
				{ "y7-", "H"},
				{ "x1-", "I"},
				{ "y3-", "J"},
				{ "y6-", "K"},
				{ "y4-", "L"},
				{ "y5-", "M"},
				{ "y00-", "N"},
				{ "x8-", "O"},
				{ "y01-", "P"},
				{"y001-", "Q" },
				{ "y02-", "R"},
				{ "y03-", "S"},
				{ "y004-", "T"},
				{ "x2-", "U"},
				{ "y04-", "V"},
				{ "y05-", "W"},
				{ "y06-", "X"},
				{ "y07-", "Y"},
				{ "y08-", "Z"},

				{ "0110-", "!"},
				{ "0210-", "?"},
				{ "010-", ","},
				{ "000-", "."},
				{ "111-", "-"},
				{ "0-", " "},

				{"1", "1-" },
				{ "2", "2-"},
				{ "3", "3-"},
				{ "4", "4-"},
				{ "5", "5-"},
				{ "6", "6-"},
				{ "7", "7-"},
				{ "8", "8-"},
				{ "9", "9-"},
				{ "0", "00-"},

				{"1-", "1"},
				{ "2-", "2"},
				{ "3-", "3"},
				{ "4-", "4"},
				{ "5-", "5"},
				{ "6-", "6"},
				{ "7-", "7"},
				{ "8-", "8"},
				{ "9-", "9"},
				{ "00-", "0"}



			};

			string Let;
			if (dd == 0)
			{

				for (int i = 0; i < fr.Length; i++)
				{

					//try
					//{
					if (alf.ContainsKey(fr[i].ToString().ToUpper()))
					{


						Let = alf[fr[i].ToString().ToUpper()].ToString();
						if (fr[i].ToString() == fr[i].ToString().ToUpper())
						{
							Shifr += Let.ToLower();
						}
						else
						{
							Shifr += Let.ToUpper();
						}
					}
					else
					{
						Shifr += fr[i].ToString() + '-';
					}
					//}
					//catch
					//{
					//	Shifr = fr[i].ToString() + '-';
					//}
				}
			}
			else if (dd == 1)
			{
				string B = "";
				string[] mas = fr.Split('-');
				for (int i = 0; i < mas.Length - 1; i++)

				{
					B = mas[i].ToString() + '-';
					//try
					//{
					if (alf.ContainsKey(B.ToLower()))
					{

						Let = alf[B.ToLower()].ToString();
						if (B.ToString() == B.ToString().ToLower())
						{
							Shifr += Let.ToUpper();
						}
						else
						{
							Shifr += Let.ToLower();
						}
					}
					else
					{
						Shifr += mas[i];
					}
					//	}
					//	catch
					//	{
					//		Shifr += B.ToString();
					//	}
				}

			}

			return Shifr;
		}

		private void checkBox1_CheckedChanged(object sender, EventArgs e)
		{
			//if (checkBox1.Checked == true)
			//{
			//	StreamWriter sr = new StreamWriter("RemPass.txt");
			//	sr.WriteLine("1");
			//	sr.WriteLine("");
			//	sr.Close();
			//}
			//else
			//{
			//	StreamWriter sr = new StreamWriter("RemPass.txt");
			//	sr.Write("0");
			//	sr.Close();
			//}

		}
		public static int Tem = 0;
		private void Form1_Load(object sender, EventArgs e)
		{

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

			if (File.Exists("RemPass.txt"))
			{
				StreamReader sr = new StreamReader("RemPass.txt");
				string str = sr.ReadLine();
				if (str == "1")
				{
					SqlConnection Con = new SqlConnection(TxtCon);
					Con.Open();
					str = sr.ReadLine();
					string TxtQuery = $"Select* from Users where IDUser = {str}";
					SqlCommand Quey1 = new SqlCommand(TxtQuery, Con);
					SqlDataReader Res = Quey1.ExecuteReader();
					if (Res.HasRows)
					{
						Res.Read();
						tbxLogin.Text = Res["LoginU"].ToString();
						tbxPassw.Text = Res["Passw"].ToString();
						Con.Close();
						sr.Close();
						btnEnter_Click(sender, e);

					}
				}
				else
				{
					tbxLogin.Text = "";
					tbxPassw.Text = "";
					sr.Close();
				}
				sr.Close();
			}	
		}

		private void label1_Click(object sender, EventArgs e)
		{
			FormReg frm = new FormReg();
			this.Hide();
			frm.ShowDialog();
			
			this.Show();
		}

		private void btnEnter_Click(object sender, EventArgs e)
		{
			//SqlConnection Con1 = new SqlConnection(Form1.TxtCon);
			//Con1.Open();
			//string TxtQuery1 = $"Select* from Journal where IDNarush = {Form1.IDUs} and Bool = 1 ";
			//SqlCommand Quey11 = new SqlCommand(TxtQuery1, Con1);
			//SqlDataReader Res1 = Quey11.ExecuteReader();
			//if (Res1.HasRows)
			//{
			//	Res1.Read();
			//	if (Convert.ToBoolean(Res1["Bool"].ToString()) == true)
			//	{


			//		DateTime dtEnd = DateTime.Parse(Res1["DateEnd"].ToString());
			//		if (dtEnd > DateTime.Now)
			//		{
			//			MessageBox.Show($"Вы не можете отправлять сообщения. У вас бан до {dtEnd} по причине {Res1["Prichina"].ToString() }", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
			//			Con1.Close();
			//			Res1.Close();
			//			return;
			//		}
			//		else if (dtEnd <= DateTime.Now)
			//		{

			//			Con1.Close();
			//			Con1.Open();
			//			TxtQuery1 = $"Update Journal set Bool = 0 Where DateEnd <= GETDATE()";
			//			SqlCommand Quey2 = new SqlCommand(TxtQuery1, Con1);
			//			Quey2.ExecuteNonQuery();

			//		}
			//	}

			//}
			//Con1.Close();
			//Res1.Close();
			string TxtQuery = $"Select* from Users where LoginU = '{tbxLogin.Text}' and Passw = '{tbxPassw.Text}'";
			SqlConnection Con = new SqlConnection(TxtCon); ;
			SqlCommand Quey1 = new SqlCommand(TxtQuery, Con);
			SqlDataReader Res = null;
			try
			{
				Con.Open();
				Quey1 = new SqlCommand(TxtQuery, Con);
				Res = Quey1.ExecuteReader();
			}
			catch
			{
				MessageBox.Show("Нестабильное подключение к интернету. Для использования программы подключитесь к стабильному источнику Интернета.", "Подключение...", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Con.Close();
				return;
			}
			


				if (Res.HasRows)
				{
				Res.Read();
				SqlConnection Con1 = new SqlConnection(Form1.TxtCon);
				Con1.Open();
				string TxtQuery1 = $"Select* from Journal where IDNarush = {Res["IDUser"]} and TypeNakaz = 1 and Bool = 1 ";
				SqlCommand Quey11 = new SqlCommand(TxtQuery1, Con1);
				SqlDataReader Res1 = Quey11.ExecuteReader();
				if (Res1.HasRows)
				{
					Res1.Read();
					if (Convert.ToBoolean(Res1["Bool"].ToString()) == true)
					{


						DateTime dtEnd = DateTime.Parse(Res1["DateEnd"].ToString());
						if (dtEnd > DateTime.Now)
						{
							MessageBox.Show($"Вы не можете войти в чат.  У вас бан до {dtEnd} по причине {Res1["Prichina"].ToString() }", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
							Con1.Close();
							Res1.Close();
							return;
						}
						else if (dtEnd <= DateTime.Now)
						{

							Con1.Close();
							Con1.Open();
							TxtQuery1 = $"Update Journal set Bool = 0 Where DateEnd <= GETDATE()";
							SqlCommand Quey2 = new SqlCommand(TxtQuery1, Con1);
							Quey2.ExecuteNonQuery();

						}
					}

				}
				Con1.Close();
				Res1.Close();

					IDUs = Res["IDUser"].ToString();
					Login = Res["LoginU"].ToString();
					int Role = int.Parse(Res["RoleUS"].ToString());

					Chats frm = new Chats();
					if (Role == 1)
					{
						Chats.Admin = true;
					}
					else
				{
					Chats.Admin = false;
				}

					if (checkBox1.Checked)
					{
						StreamWriter sr = new StreamWriter("RemPass.txt");
						sr.WriteLine("1");
						sr.WriteLine(IDUs);
						sr.Close();
					}
					else
					{
						StreamWriter sr = new StreamWriter("RemPass.txt");
						sr.Write("0");
						sr.Close();
					}

					tbxLogin.Clear();
					tbxPassw.Clear();
					this.Hide();
					frm.ShowDialog();
					try
					{
						this.Show();
					}
					catch
					{

					}

				}
				else
					MessageBox.Show("Проверьте правильность данных или зарегистрируйтесь.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Con.Close();
			

		}
	}
}

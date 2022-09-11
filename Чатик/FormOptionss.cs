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
	public partial class FormOptionss : Form
	{
		string Log="", Col="";
		public FormOptionss()
		{
			InitializeComponent();
			SqlConnection Con = new SqlConnection(Form1.TxtCon);
			Con.Open();
			string StrQuarte = $@"Select* From Users Where IDUser={Form1.IDUs}";
			SqlCommand Quarte1 = new SqlCommand(StrQuarte, Con);
			SqlDataReader Res = Quarte1.ExecuteReader();
			while (Res.Read())
			{
				tbxLog.Text = Res["LoginU"].ToString();
				Log = tbxLog.Text;
				cbxColor.SelectedIndex = int.Parse(Res["ColorRole"].ToString());
				Col = cbxColor.SelectedIndex.ToString();
			}
			lblNick.Text = tbxLog.Text;
			ColorNick();
			Con.Close();
			btnSave.Visible = false;

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
			cbxTema.SelectedIndex = Tem;
		}

		private void ColorNick()
		{
			if (cbxColor.SelectedIndex == 0)
			{
				lblNick.ForeColor = Color.Navy;
			}
			else if (cbxColor.SelectedIndex == 1)
			{
				lblNick.ForeColor = Color.DarkMagenta;
			}
			else if (cbxColor.SelectedIndex == 2)
			{
				lblNick.ForeColor = Color.DarkCyan;
			}
			else if (cbxColor.SelectedIndex == 3)
			{
				lblNick.ForeColor = Color.Olive;
			}
			else if (cbxColor.SelectedIndex == 4)
			{
				lblNick.ForeColor = Color.Sienna;
			}
		}

		private void button3_Click(object sender, EventArgs e)
		{
			tbxLog.ReadOnly = false;
			tbxPass.Visible = true;
			lblP.Visible = true;
			SaveBtn();

		}

		private void SaveBtn()
		{
			if (tbxLog.Text != Log || cbxColor.SelectedIndex.ToString() != Col)
			{
				btnSave.Visible = true;
			}
			else
			{
				btnSave.Visible = false;
			}
		}

		private void tbxLog_TextChanged(object sender, EventArgs e)
		{
			SaveBtn();
			lblNick.Text = tbxLog.Text;
		}

		private void button1_Click(object sender, EventArgs e)
		{
			label1.Visible = false;
			tbxLog.Visible = false;
			lblNick.Visible = false;
			tbxPass.Visible = false;
			label4.Visible = false;
			button3.Visible = false;

			lblUs.Visible = false;
			lblP.Visible = false;
			lblPass.Visible = false;
			lblPredvPro.Visible = false;
			lblTema.Visible = true;
			cbxTema.Visible = true;
			cbxColor.Visible = false;

			lblPsw.Visible = false;
			lblNew.Visible = false;
			lblNP.Visible = false;
			tbxPassOld.Visible = false;
			tbxPass.Visible = false;
			tbxPassNew.Visible = false;
			tbxPassNew2.Visible = false;
			btnSavePass.Visible = false;
		}
		public static int Tem = 0;
		private void cbxTema_SelectedIndexChanged(object sender, EventArgs e)
		{
			
			StreamWriter sr = new StreamWriter("TemaP.txt");
			sr.WriteLine(cbxTema.SelectedIndex.ToString());
			sr.Close();
			if(cbxTema.SelectedIndex == 0)
			{
				this.BackColor = Color.FromArgb(192, 192, 255);
			}
			else
				if(cbxTema.SelectedIndex == 1)
			{
				this.BackColor = Color.DarkSeaGreen;
			}
		}

		private void btnFind_Click(object sender, EventArgs e)
		{
			label1.Visible = true;
			tbxLog.Visible = true;
			lblNick.Visible = true;
			lblUs.Visible = false;
			tbxPass.Visible = false;
			label4.Visible = true;
			button3.Visible = true;
			lblP.Visible = false;
			lblPass.Visible = false;
			lblPredvPro.Visible = true;
			lblTema.Visible = false;
			cbxTema.Visible = false;
			cbxColor.Visible = true;

			lblPsw.Visible = false;
			lblNew.Visible = false;
			lblNP.Visible = false;
			tbxPass.Visible = false;
			tbxPassOld.Visible = false;
			tbxPassNew.Visible = false;
			tbxPassNew2.Visible = false;
			btnSavePass.Visible = false;
		}

		private void button2_Click(object sender, EventArgs e)
		{
			label1.Visible = false;
			tbxLog.Visible = false;
			lblNick.Visible = false;
			lblUs.Visible = false;
			tbxPass.Visible = false;
			label4.Visible = false;
			button3.Visible = false;
			lblP.Visible = false;
			lblPass.Visible = false;
			lblPredvPro.Visible = false;
			lblTema.Visible = false;
			cbxTema.Visible = false;
			cbxColor.Visible = false;

			lblPsw.Visible = true;
			lblNew.Visible = true;
			lblNP.Visible = true;
			tbxPassOld.Visible = true;
			tbxPassNew.Visible = true;
			tbxPassNew2.Visible = true;
			btnSavePass.Visible = true;
		}

		private void btnSavePass_Click(object sender, EventArgs e)
		{
			if(tbxPassNew.Text != tbxPassNew2.Text || tbxPassNew.Text=="")
			{
				MessageBox.Show("Проверьте правильность заполненных полей и не оставляйте поля пустыми.", "Внимание!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			DialogResult res = MessageBox.Show("Вы уверены, что хотите сменить пароль?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if(res == DialogResult.No)
			{
				return;
			}
			SqlConnection Con = new SqlConnection(Form1.TxtCon);
			Con.Open();
			string TxtQuery = $"Select* from Users where IDUser = '{Form1.IDUs}' and Passw = '{tbxPassOld.Text}'";
			SqlCommand Quey1 = new SqlCommand(TxtQuery, Con);
			SqlDataReader Res = Quey1.ExecuteReader();
			if (Res.HasRows)
			{
				Res.Close();
				Con.Close();
				Con.Open();
				TxtQuery = $"Update Users set Passw = '{tbxPassNew2.Text}' Where IDUser = '{Form1.IDUs}'";
				SqlCommand Quey2 = new SqlCommand(TxtQuery, Con);
				Quey2.ExecuteNonQuery();
				MessageBox.Show("Пароль успешно сменён. Вам придётся снова авторизоваться.", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
				Chats.pass = true;
			}
			else
			{
				MessageBox.Show("Неправильно введён пароль.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			SqlConnection Con = new SqlConnection(Form1.TxtCon);
			Con.Open();
			string TxtQuery =$"Update Users set ColorRole = {cbxColor.SelectedIndex} , LoginU = '{lblNick.Text}' Where IDUser = '{Form1.IDUs}'";
			SqlCommand Quey2 = new SqlCommand(TxtQuery, Con);
			Quey2.ExecuteNonQuery();
			MessageBox.Show("Логин/цвет сменен успешно. Обновите чат/отправьте сообщение, чтобы изменения применились в программе.", "Успех!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			Con.Close();
			this.Close();
		}

		private void cbxColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			ColorNick();
			SaveBtn();
		}
	}
}

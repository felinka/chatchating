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
	public partial class FormReg : Form
	{
		public FormReg()
		{
			InitializeComponent();
			int Tem = 0;
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
			cbxColor.SelectedIndex = 0;
		}
		bool Log = true, Pass = true;
		private void textBox1_TextChanged(object sender, EventArgs e)
		{

			SqlConnection Con = new SqlConnection(Form1.TxtCon);
			Con.Open();
			string TxtQuery1 = $"Select* from Users where LoginU = '{tbxLog.Text.Trim()}'";

			SqlCommand Quey11 = new SqlCommand(TxtQuery1, Con);
			SqlDataReader Res = Quey11.ExecuteReader();
			if (Res.HasRows)
			{
				lblUs.Visible = true;
				Log = false;
				return;
			}
			else
			{
				lblUs.Visible = false;
				Log = true;
			}
			Con.Close();

			if (tbxLog.Text!="")
			{
				
				lblNick.Visible = true;
				lblNick.Text = tbxLog.Text;
				lblPredvPro.Visible = true;
				cbxColor_SelectedIndexChanged(sender, e);
			}
			else
			{
				lblNick.Visible = false;
				lblPredvPro.Visible = false;
			}
		}

		private void cbxColor_SelectedIndexChanged(object sender, EventArgs e)
		{
			if(tbxLog.Text!="")
			{
				if(cbxColor.SelectedIndex == 0)
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
		}

		private void btnReg_Click(object sender, EventArgs e)
		{
			if(tbxPass.Text != tbxPovPass.Text)
			{
				MessageBox.Show("Пароли не совпадают!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			SqlConnection Con = new SqlConnection(Form1.TxtCon);
			Con.Open();
			int Av = int.Parse(cbxColor.SelectedIndex.ToString());

			string TxtQuery = $@"Insert into Users (LoginU, Passw, ColorRole) Values ('{tbxLog.Text}', '{tbxPass.Text}', {Av})";
			SqlCommand Quey1 = new SqlCommand(TxtQuery, Con);
			Quey1.ExecuteNonQuery();
			Con.Close();

			MessageBox.Show("Вы успешно зарегистрировались! Перейдите в форму авторизации.", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
			this.Close();
		}

		private void tbxPass_TextChanged(object sender, EventArgs e)
		{
			if (tbxPass.Text != tbxPovPass.Text)
			{
				if(tbxPovPass.Text!="" && tbxPass.Text!="")
				{
					lblPass.Visible = true;
					Pass = false;
				}
			}	
			else
			{
				lblPass.Visible = false;
				Pass = true;
			}
		}


		private void tbxPovPass_TextChanged(object sender, EventArgs e)
		{
			if (tbxPass.Text != tbxPovPass.Text)
			{
				if (tbxPovPass.Text != "" && tbxPass.Text != "")
				{
					lblPass.Visible = true;
					Pass = false;
				}
			}
			else
			{
				lblPass.Visible = false;
				Pass = true;
			}

			btnReg.Enabled = Log == true && tbxPass.Text != "" && tbxLog.Text != "" && tbxPovPass.Text != "" && Pass==true;
		}
	}
}

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
	public partial class FormConsole : Form
	{
		int Tem;
		public FormConsole()
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

			InitializeComponent();
		}

		private void FormConsole_Load(object sender, EventArgs e)
		{
			// TODO: данная строка кода позволяет загрузить данные в таблицу "chatAEEDataSet1.Users1". При необходимости она может быть перемещена или удалена.
			this.users1TableAdapter.Fill(this.chatAEEDataSet1.Users1);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "chatAEEDataSet1.Users". При необходимости она может быть перемещена или удалена.
			this.usersTableAdapter.Fill(this.chatAEEDataSet1.Users);
			// TODO: данная строка кода позволяет загрузить данные в таблицу "chatAEEDataSet.Users". При необходимости она может быть перемещена или удалена.
			bsUser.Filter = $"RoleUs = 0";
		}

		private void btnOptions_Click(object sender, EventArgs e)
		{
			DialogResult res = MessageBox.Show($"Вы уверены, что хотите выдать МУТ пользователю {lblLog.Text} на {tbxHours.Text} час(а/ов)?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (res == DialogResult.No)
				return;
			SqlConnection Con = new SqlConnection(Form1.TxtCon);
			Con.Open();
			DateTime dt = DateTime.Now;
			dt = dt.AddHours(int.Parse(tbxHours.Text));
			string[] masT = dt.ToString().Split(' ');
			string[] mas = masT[0].Split('.');
			string date = mas[2] + '-' + mas[1] + '-' + mas[0] + " " + masT[1];
			string StrQuarte = $@"Insert into Journal (IDNarush, IDAdm, DateEnd, Prichina, TypeNakaz, Bool) Values ({lblIDUsN.Text}, {Form1.IDUs}, '{date}', '{tbxPrichina.Text}', 0, 1)";

			SqlCommand Quey11 = new SqlCommand(StrQuarte, Con);
			Quey11.ExecuteNonQuery();
			Con.Close();
			MessageBox.Show($"Пользователю {lblLog.Text} выдан МУТ на {tbxHours.Text} час(а/ов)?", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void tbxPrichina_TextChanged(object sender, EventArgs e)
		{
			btnBan.Visible = tbxPrichina.Text != "" && tbxHours.Text != "";
			btnMute.Visible = tbxPrichina.Text != "" && tbxHours.Text != "";
		}

		private void btnBan_Click(object sender, EventArgs e)
		{
			//
			DialogResult res = MessageBox.Show($"Вы уверены, что хотите выдать БАН пользователю {lblLog.Text} на {tbxHours.Text} час(а/ов)?", "Внимание!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
			if (res == DialogResult.No)
				return;
			SqlConnection Con = new SqlConnection(Form1.TxtCon);
			Con.Open();
			DateTime dt = DateTime.Now;
			dt = dt.AddHours(int.Parse(tbxHours.Text));
			string[] masT = dt.ToString().Split(' ');
			string[] mas = masT[0].Split('.');
			string date = mas[2] + '-' + mas[1] + '-' + mas[0] + " " + masT[1];
			string StrQuarte = $@"Insert into Journal (IDNarush, IDAdm, DateEnd, Prichina, TypeNakaz, Bool) Values ({lblIDUsN.Text}, {Form1.IDUs}, '{date}', '{tbxPrichina.Text}', 1, 1)";

			SqlCommand Quey11 = new SqlCommand(StrQuarte, Con);
			Quey11.ExecuteNonQuery();
			Con.Close();

			MessageBox.Show($"Пользователю {lblLog.Text} выдан БАН на {tbxHours.Text} час(а/ов)?", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void tbxLog_TextChanged(object sender, EventArgs e)
		{
			bindingSource1.Filter = $"LoginU like '%{tbxLog.Text}%'";
		}
	}
}

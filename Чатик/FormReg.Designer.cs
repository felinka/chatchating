
namespace Чатик
{
	partial class FormReg
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReg));
			this.btnReg = new System.Windows.Forms.Button();
			this.tbxLog = new System.Windows.Forms.TextBox();
			this.tbxPass = new System.Windows.Forms.TextBox();
			this.tbxPovPass = new System.Windows.Forms.TextBox();
			this.cbxColor = new System.Windows.Forms.ComboBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblPredvPro = new System.Windows.Forms.Label();
			this.lblNick = new System.Windows.Forms.Label();
			this.lblPass = new System.Windows.Forms.Label();
			this.lblUs = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// btnReg
			// 
			this.btnReg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnReg.Enabled = false;
			this.btnReg.Location = new System.Drawing.Point(132, 411);
			this.btnReg.Name = "btnReg";
			this.btnReg.Size = new System.Drawing.Size(172, 38);
			this.btnReg.TabIndex = 0;
			this.btnReg.Text = "Зарегистрироваться";
			this.btnReg.UseVisualStyleBackColor = false;
			this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
			// 
			// tbxLog
			// 
			this.tbxLog.Location = new System.Drawing.Point(88, 57);
			this.tbxLog.Name = "tbxLog";
			this.tbxLog.Size = new System.Drawing.Size(257, 26);
			this.tbxLog.TabIndex = 1;
			this.tbxLog.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
			// 
			// tbxPass
			// 
			this.tbxPass.Location = new System.Drawing.Point(88, 136);
			this.tbxPass.Name = "tbxPass";
			this.tbxPass.PasswordChar = '*';
			this.tbxPass.Size = new System.Drawing.Size(257, 26);
			this.tbxPass.TabIndex = 2;
			this.tbxPass.TextChanged += new System.EventHandler(this.tbxPass_TextChanged);
			// 
			// tbxPovPass
			// 
			this.tbxPovPass.Location = new System.Drawing.Point(88, 196);
			this.tbxPovPass.Name = "tbxPovPass";
			this.tbxPovPass.PasswordChar = '*';
			this.tbxPovPass.Size = new System.Drawing.Size(257, 26);
			this.tbxPovPass.TabIndex = 3;
			this.tbxPovPass.TextChanged += new System.EventHandler(this.tbxPovPass_TextChanged);
			// 
			// cbxColor
			// 
			this.cbxColor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxColor.FormattingEnabled = true;
			this.cbxColor.Items.AddRange(new object[] {
            "Стандартный синий",
            "Темно-пурпурный",
            "Темно-голубой",
            "Оливковое",
            "Охра"});
			this.cbxColor.Location = new System.Drawing.Point(127, 274);
			this.cbxColor.Name = "cbxColor";
			this.cbxColor.Size = new System.Drawing.Size(196, 26);
			this.cbxColor.TabIndex = 4;
			this.cbxColor.SelectedIndexChanged += new System.EventHandler(this.cbxColor_SelectedIndexChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(88, 34);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 20);
			this.label1.TabIndex = 5;
			this.label1.Text = "Логин:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(88, 114);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(69, 20);
			this.label2.TabIndex = 6;
			this.label2.Text = "Пароль:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(88, 169);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(186, 20);
			this.label3.TabIndex = 7;
			this.label3.Text = "Подтверждение пароля:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(123, 251);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(151, 20);
			this.label4.TabIndex = 8;
			this.label4.Text = "Цвет логина в чате:";
			// 
			// lblPredvPro
			// 
			this.lblPredvPro.AutoSize = true;
			this.lblPredvPro.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPredvPro.Location = new System.Drawing.Point(84, 311);
			this.lblPredvPro.Name = "lblPredvPro";
			this.lblPredvPro.Size = new System.Drawing.Size(278, 20);
			this.lblPredvPro.TabIndex = 9;
			this.lblPredvPro.Text = "Предварительный просмотр логина:";
			this.lblPredvPro.Visible = false;
			// 
			// lblNick
			// 
			this.lblNick.AutoSize = true;
			this.lblNick.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
			this.lblNick.Location = new System.Drawing.Point(194, 352);
			this.lblNick.Name = "lblNick";
			this.lblNick.Size = new System.Drawing.Size(39, 24);
			this.lblNick.TabIndex = 10;
			this.lblNick.Text = "ник";
			this.lblNick.Visible = false;
			// 
			// lblPass
			// 
			this.lblPass.AutoSize = true;
			this.lblPass.ForeColor = System.Drawing.Color.Red;
			this.lblPass.Location = new System.Drawing.Point(133, 225);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new System.Drawing.Size(162, 19);
			this.lblPass.TabIndex = 11;
			this.lblPass.Text = "Пароли не совпадают.";
			this.lblPass.Visible = false;
			// 
			// lblUs
			// 
			this.lblUs.AutoSize = true;
			this.lblUs.ForeColor = System.Drawing.Color.Red;
			this.lblUs.Location = new System.Drawing.Point(84, 86);
			this.lblUs.Name = "lblUs";
			this.lblUs.Size = new System.Drawing.Size(306, 19);
			this.lblUs.TabIndex = 12;
			this.lblUs.Text = "Пользователь с таким логином существует.";
			this.lblUs.Visible = false;
			// 
			// FormReg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(432, 524);
			this.Controls.Add(this.lblUs);
			this.Controls.Add(this.lblPass);
			this.Controls.Add(this.lblNick);
			this.Controls.Add(this.lblPredvPro);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbxColor);
			this.Controls.Add(this.tbxPovPass);
			this.Controls.Add(this.tbxPass);
			this.Controls.Add(this.tbxLog);
			this.Controls.Add(this.btnReg);
			this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormReg";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Регистрация";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnReg;
		private System.Windows.Forms.TextBox tbxLog;
		private System.Windows.Forms.TextBox tbxPass;
		private System.Windows.Forms.TextBox tbxPovPass;
		private System.Windows.Forms.ComboBox cbxColor;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblPredvPro;
		private System.Windows.Forms.Label lblNick;
		private System.Windows.Forms.Label lblPass;
		private System.Windows.Forms.Label lblUs;
	}
}
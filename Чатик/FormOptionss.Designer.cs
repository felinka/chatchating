
namespace Чатик
{
	partial class FormOptionss
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormOptionss));
			this.lblUs = new System.Windows.Forms.Label();
			this.lblNick = new System.Windows.Forms.Label();
			this.lblPredvPro = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.lblP = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.cbxColor = new System.Windows.Forms.ComboBox();
			this.tbxPass = new System.Windows.Forms.TextBox();
			this.tbxLog = new System.Windows.Forms.TextBox();
			this.btnFind = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.button2 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.lblPass = new System.Windows.Forms.Label();
			this.btnSave = new System.Windows.Forms.Button();
			this.cbxTema = new System.Windows.Forms.ComboBox();
			this.lblTema = new System.Windows.Forms.Label();
			this.tbxPassOld = new System.Windows.Forms.TextBox();
			this.tbxPassNew = new System.Windows.Forms.TextBox();
			this.tbxPassNew2 = new System.Windows.Forms.TextBox();
			this.lblPsw = new System.Windows.Forms.Label();
			this.lblNew = new System.Windows.Forms.Label();
			this.lblNP = new System.Windows.Forms.Label();
			this.btnSavePass = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lblUs
			// 
			this.lblUs.AutoSize = true;
			this.lblUs.ForeColor = System.Drawing.Color.Red;
			this.lblUs.Location = new System.Drawing.Point(156, 161);
			this.lblUs.Name = "lblUs";
			this.lblUs.Size = new System.Drawing.Size(297, 17);
			this.lblUs.TabIndex = 24;
			this.lblUs.Text = "Пользователь с таким логином существует.";
			this.lblUs.Visible = false;
			// 
			// lblNick
			// 
			this.lblNick.AutoSize = true;
			this.lblNick.Font = new System.Drawing.Font("Comic Sans MS", 10.2F);
			this.lblNick.Location = new System.Drawing.Point(267, 364);
			this.lblNick.Name = "lblNick";
			this.lblNick.Size = new System.Drawing.Size(39, 24);
			this.lblNick.TabIndex = 22;
			this.lblNick.Text = "ник";
			// 
			// lblPredvPro
			// 
			this.lblPredvPro.AutoSize = true;
			this.lblPredvPro.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblPredvPro.Location = new System.Drawing.Point(157, 323);
			this.lblPredvPro.Name = "lblPredvPro";
			this.lblPredvPro.Size = new System.Drawing.Size(278, 20);
			this.lblPredvPro.TabIndex = 21;
			this.lblPredvPro.Text = "Предварительный просмотр логина:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(186, 267);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(151, 20);
			this.label4.TabIndex = 20;
			this.label4.Text = "Цвет логина в чате:";
			// 
			// lblP
			// 
			this.lblP.AutoSize = true;
			this.lblP.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblP.Location = new System.Drawing.Point(160, 189);
			this.lblP.Name = "lblP";
			this.lblP.Size = new System.Drawing.Size(275, 20);
			this.lblP.TabIndex = 18;
			this.lblP.Text = "Введите пароль для подтверждения:";
			this.lblP.Visible = false;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(160, 109);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(58, 20);
			this.label1.TabIndex = 17;
			this.label1.Text = "Логин:";
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
			this.cbxColor.Location = new System.Drawing.Point(190, 290);
			this.cbxColor.Name = "cbxColor";
			this.cbxColor.Size = new System.Drawing.Size(196, 24);
			this.cbxColor.TabIndex = 16;
			this.cbxColor.SelectedIndexChanged += new System.EventHandler(this.cbxColor_SelectedIndexChanged);
			// 
			// tbxPass
			// 
			this.tbxPass.Location = new System.Drawing.Point(160, 211);
			this.tbxPass.Name = "tbxPass";
			this.tbxPass.PasswordChar = '*';
			this.tbxPass.Size = new System.Drawing.Size(257, 22);
			this.tbxPass.TabIndex = 14;
			this.tbxPass.Visible = false;
			// 
			// tbxLog
			// 
			this.tbxLog.Location = new System.Drawing.Point(160, 132);
			this.tbxLog.Name = "tbxLog";
			this.tbxLog.ReadOnly = true;
			this.tbxLog.Size = new System.Drawing.Size(257, 22);
			this.tbxLog.TabIndex = 13;
			this.tbxLog.TextChanged += new System.EventHandler(this.tbxLog_TextChanged);
			// 
			// btnFind
			// 
			this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnFind.Location = new System.Drawing.Point(25, 12);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(107, 37);
			this.btnFind.TabIndex = 1;
			this.btnFind.Text = "Профиль";
			this.btnFind.UseVisualStyleBackColor = false;
			this.btnFind.Click += new System.EventHandler(this.btnFind_Click);
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button1.Location = new System.Drawing.Point(239, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(107, 37);
			this.button1.TabIndex = 26;
			this.button1.Text = "Приложение";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button2.Location = new System.Drawing.Point(461, 12);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(107, 37);
			this.button2.TabIndex = 27;
			this.button2.Text = "Пароль";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.button3.Location = new System.Drawing.Point(414, 131);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(55, 24);
			this.button3.TabIndex = 28;
			this.button3.Text = "ред.";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// lblPass
			// 
			this.lblPass.AutoSize = true;
			this.lblPass.ForeColor = System.Drawing.Color.Red;
			this.lblPass.Location = new System.Drawing.Point(211, 236);
			this.lblPass.Name = "lblPass";
			this.lblPass.Size = new System.Drawing.Size(130, 17);
			this.lblPass.TabIndex = 23;
			this.lblPass.Text = "Неверный пароль.";
			this.lblPass.Visible = false;
			// 
			// btnSave
			// 
			this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnSave.Location = new System.Drawing.Point(201, 422);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(171, 30);
			this.btnSave.TabIndex = 29;
			this.btnSave.Text = "Сохранить изменения";
			this.btnSave.UseVisualStyleBackColor = false;
			this.btnSave.Visible = false;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// cbxTema
			// 
			this.cbxTema.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxTema.FormattingEnabled = true;
			this.cbxTema.Items.AddRange(new object[] {
            "Сиреневая",
            "Зёленая"});
			this.cbxTema.Location = new System.Drawing.Point(181, 189);
			this.cbxTema.Name = "cbxTema";
			this.cbxTema.Size = new System.Drawing.Size(234, 24);
			this.cbxTema.TabIndex = 30;
			this.cbxTema.Visible = false;
			this.cbxTema.SelectedIndexChanged += new System.EventHandler(this.cbxTema_SelectedIndexChanged);
			// 
			// lblTema
			// 
			this.lblTema.AutoSize = true;
			this.lblTema.BackColor = System.Drawing.Color.Transparent;
			this.lblTema.Location = new System.Drawing.Point(178, 144);
			this.lblTema.Name = "lblTema";
			this.lblTema.Size = new System.Drawing.Size(257, 17);
			this.lblTema.TabIndex = 31;
			this.lblTema.Text = "Выберите желаемую тему программы";
			this.lblTema.Visible = false;
			// 
			// tbxPassOld
			// 
			this.tbxPassOld.Location = new System.Drawing.Point(164, 153);
			this.tbxPassOld.Name = "tbxPassOld";
			this.tbxPassOld.PasswordChar = '*';
			this.tbxPassOld.Size = new System.Drawing.Size(258, 22);
			this.tbxPassOld.TabIndex = 32;
			this.tbxPassOld.Visible = false;
			// 
			// tbxPassNew
			// 
			this.tbxPassNew.Location = new System.Drawing.Point(164, 211);
			this.tbxPassNew.Name = "tbxPassNew";
			this.tbxPassNew.PasswordChar = '*';
			this.tbxPassNew.Size = new System.Drawing.Size(258, 22);
			this.tbxPassNew.TabIndex = 33;
			this.tbxPassNew.Visible = false;
			// 
			// tbxPassNew2
			// 
			this.tbxPassNew2.Location = new System.Drawing.Point(161, 265);
			this.tbxPassNew2.Name = "tbxPassNew2";
			this.tbxPassNew2.PasswordChar = '*';
			this.tbxPassNew2.Size = new System.Drawing.Size(258, 22);
			this.tbxPassNew2.TabIndex = 34;
			this.tbxPassNew2.Visible = false;
			// 
			// lblPsw
			// 
			this.lblPsw.AutoSize = true;
			this.lblPsw.Location = new System.Drawing.Point(161, 127);
			this.lblPsw.Name = "lblPsw";
			this.lblPsw.Size = new System.Drawing.Size(170, 17);
			this.lblPsw.TabIndex = 35;
			this.lblPsw.Text = "Введите старый пароль:";
			this.lblPsw.Visible = false;
			// 
			// lblNew
			// 
			this.lblNew.AutoSize = true;
			this.lblNew.Location = new System.Drawing.Point(161, 184);
			this.lblNew.Name = "lblNew";
			this.lblNew.Size = new System.Drawing.Size(163, 17);
			this.lblNew.TabIndex = 36;
			this.lblNew.Text = "Введите новый пароль:";
			this.lblNew.Visible = false;
			// 
			// lblNP
			// 
			this.lblNP.AutoSize = true;
			this.lblNP.Location = new System.Drawing.Point(161, 245);
			this.lblNP.Name = "lblNP";
			this.lblNP.Size = new System.Drawing.Size(179, 17);
			this.lblNP.TabIndex = 37;
			this.lblNP.Text = "Повторите новый пароль:";
			this.lblNP.Visible = false;
			// 
			// btnSavePass
			// 
			this.btnSavePass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnSavePass.Location = new System.Drawing.Point(201, 346);
			this.btnSavePass.Name = "btnSavePass";
			this.btnSavePass.Size = new System.Drawing.Size(171, 30);
			this.btnSavePass.TabIndex = 38;
			this.btnSavePass.Text = "Сохранить изменения";
			this.btnSavePass.UseVisualStyleBackColor = false;
			this.btnSavePass.Visible = false;
			this.btnSavePass.Click += new System.EventHandler(this.btnSavePass_Click);
			// 
			// FormOptionss
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(606, 496);
			this.Controls.Add(this.btnSavePass);
			this.Controls.Add(this.lblNP);
			this.Controls.Add(this.lblNew);
			this.Controls.Add(this.lblPsw);
			this.Controls.Add(this.tbxPassNew2);
			this.Controls.Add(this.tbxPassNew);
			this.Controls.Add(this.tbxPassOld);
			this.Controls.Add(this.lblTema);
			this.Controls.Add(this.cbxTema);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.lblUs);
			this.Controls.Add(this.lblPass);
			this.Controls.Add(this.lblNick);
			this.Controls.Add(this.lblPredvPro);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lblP);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.cbxColor);
			this.Controls.Add(this.tbxPass);
			this.Controls.Add(this.tbxLog);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormOptionss";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Настройки";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lblUs;
		private System.Windows.Forms.Label lblNick;
		private System.Windows.Forms.Label lblPredvPro;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lblP;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cbxColor;
		private System.Windows.Forms.TextBox tbxPass;
		private System.Windows.Forms.TextBox tbxLog;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label lblPass;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.ComboBox cbxTema;
		private System.Windows.Forms.Label lblTema;
		private System.Windows.Forms.TextBox tbxPassOld;
		private System.Windows.Forms.TextBox tbxPassNew;
		private System.Windows.Forms.TextBox tbxPassNew2;
		private System.Windows.Forms.Label lblPsw;
		private System.Windows.Forms.Label lblNew;
		private System.Windows.Forms.Label lblNP;
		private System.Windows.Forms.Button btnSavePass;
	}
}
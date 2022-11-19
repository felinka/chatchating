
namespace Чатик
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.Label passwLabel;
			System.Windows.Forms.Label loginLabel;
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.tbxPassw = new System.Windows.Forms.TextBox();
			this.tbxLogin = new System.Windows.Forms.TextBox();
			this.btnEnter = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			passwLabel = new System.Windows.Forms.Label();
			loginLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// passwLabel
			// 
			passwLabel.AutoSize = true;
			passwLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			passwLabel.Location = new System.Drawing.Point(68, 113);
			passwLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			passwLabel.Name = "passwLabel";
			passwLabel.Size = new System.Drawing.Size(69, 20);
			passwLabel.TabIndex = 11;
			passwLabel.Text = "Пароль:";
			// 
			// loginLabel
			// 
			loginLabel.AutoSize = true;
			loginLabel.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			loginLabel.Location = new System.Drawing.Point(79, 65);
			loginLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			loginLabel.Name = "loginLabel";
			loginLabel.Size = new System.Drawing.Size(58, 20);
			loginLabel.TabIndex = 10;
			loginLabel.Text = "Логин:";
			// 
			// tbxPassw
			// 
			this.tbxPassw.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbxPassw.Location = new System.Drawing.Point(151, 107);
			this.tbxPassw.Margin = new System.Windows.Forms.Padding(4);
			this.tbxPassw.Multiline = true;
			this.tbxPassw.Name = "tbxPassw";
			this.tbxPassw.PasswordChar = '*';
			this.tbxPassw.Size = new System.Drawing.Size(140, 30);
			this.tbxPassw.TabIndex = 13;
			// 
			// tbxLogin
			// 
			this.tbxLogin.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.tbxLogin.Location = new System.Drawing.Point(151, 59);
			this.tbxLogin.Margin = new System.Windows.Forms.Padding(4);
			this.tbxLogin.Multiline = true;
			this.tbxLogin.Name = "tbxLogin";
			this.tbxLogin.Size = new System.Drawing.Size(140, 30);
			this.tbxLogin.TabIndex = 12;
			// 
			// btnEnter
			// 
			this.btnEnter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnEnter.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnEnter.Location = new System.Drawing.Point(122, 222);
			this.btnEnter.Margin = new System.Windows.Forms.Padding(4);
			this.btnEnter.Name = "btnEnter";
			this.btnEnter.Size = new System.Drawing.Size(157, 35);
			this.btnEnter.TabIndex = 9;
			this.btnEnter.Text = "Вход";
			this.btnEnter.UseVisualStyleBackColor = false;
			this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.DarkSlateBlue;
			this.label1.Location = new System.Drawing.Point(159, 273);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 20);
			this.label1.TabIndex = 14;
			this.label1.Text = "Регистрация";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(136, 169);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(155, 23);
			this.checkBox1.TabIndex = 15;
			this.checkBox1.Text = "Запомнить пароль";
			this.checkBox1.UseVisualStyleBackColor = true;
			this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
			// 
			// Form1
			// 
			this.AcceptButton = this.btnEnter;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(404, 343);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbxPassw);
			this.Controls.Add(this.tbxLogin);
			this.Controls.Add(passwLabel);
			this.Controls.Add(loginLabel);
			this.Controls.Add(this.btnEnter);
			this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Авторизация";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		public System.Windows.Forms.TextBox tbxPassw;
		public System.Windows.Forms.TextBox tbxLogin;
		public System.Windows.Forms.Button btnEnter;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.CheckBox checkBox1;
	}
}


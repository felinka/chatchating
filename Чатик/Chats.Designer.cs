
namespace Чатик
{
	partial class Chats
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chats));
			this.MainPanel = new System.Windows.Forms.TableLayoutPanel();
			this.tbxMess = new System.Windows.Forms.TextBox();
			this.btnSend = new System.Windows.Forms.Button();
			this.btnObnov = new System.Windows.Forms.Button();
			this.btnExitProg = new System.Windows.Forms.Button();
			this.btnExAc = new System.Windows.Forms.Button();
			this.btnFind = new System.Windows.Forms.Button();
			this.tbxFind = new System.Windows.Forms.TextBox();
			this.btnOptions = new System.Windows.Forms.Button();
			this.btnMenu = new System.Windows.Forms.Button();
			this.btnConsole = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.timerDB = new System.Windows.Forms.Timer(this.components);
			this.panel1 = new System.Windows.Forms.Panel();
			this.label2 = new System.Windows.Forms.Label();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.SuspendLayout();
			// 
			// MainPanel
			// 
			this.MainPanel.AutoScroll = true;
			this.MainPanel.ColumnCount = 1;
			this.MainPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.MainPanel.Location = new System.Drawing.Point(118, 86);
			this.MainPanel.Name = "MainPanel";
			this.MainPanel.RowCount = 1;
			this.MainPanel.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.MainPanel.Size = new System.Drawing.Size(1004, 513);
			this.MainPanel.TabIndex = 0;
			// 
			// tbxMess
			// 
			this.tbxMess.Location = new System.Drawing.Point(118, 619);
			this.tbxMess.Multiline = true;
			this.tbxMess.Name = "tbxMess";
			this.tbxMess.Size = new System.Drawing.Size(888, 40);
			this.tbxMess.TabIndex = 1;
			this.tbxMess.TextChanged += new System.EventHandler(this.tbxMess_TextChanged);
			// 
			// btnSend
			// 
			this.btnSend.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnSend.Enabled = false;
			this.btnSend.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnSend.Location = new System.Drawing.Point(1012, 622);
			this.btnSend.Name = "btnSend";
			this.btnSend.Size = new System.Drawing.Size(110, 37);
			this.btnSend.TabIndex = 0;
			this.btnSend.Text = "Отправить";
			this.btnSend.UseVisualStyleBackColor = false;
			this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
			// 
			// btnObnov
			// 
			this.btnObnov.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnObnov.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.btnObnov.Location = new System.Drawing.Point(29, 622);
			this.btnObnov.Name = "btnObnov";
			this.btnObnov.Size = new System.Drawing.Size(83, 35);
			this.btnObnov.TabIndex = 2;
			this.btnObnov.Text = "обновить";
			this.btnObnov.UseVisualStyleBackColor = false;
			this.btnObnov.Click += new System.EventHandler(this.btnObnov_Click);
			// 
			// btnExitProg
			// 
			this.btnExitProg.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnExitProg.Location = new System.Drawing.Point(2, 212);
			this.btnExitProg.Name = "btnExitProg";
			this.btnExitProg.Size = new System.Drawing.Size(110, 49);
			this.btnExitProg.TabIndex = 3;
			this.btnExitProg.Text = "Выйти из\r\nпрограммы\r\n";
			this.btnExitProg.UseVisualStyleBackColor = false;
			this.btnExitProg.Visible = false;
			this.btnExitProg.Click += new System.EventHandler(this.button1_Click);
			// 
			// btnExAc
			// 
			this.btnExAc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnExAc.Location = new System.Drawing.Point(2, 277);
			this.btnExAc.Name = "btnExAc";
			this.btnExAc.Size = new System.Drawing.Size(110, 49);
			this.btnExAc.TabIndex = 4;
			this.btnExAc.Text = "Выйти из \r\nаккаунта";
			this.btnExAc.UseVisualStyleBackColor = false;
			this.btnExAc.Visible = false;
			this.btnExAc.Click += new System.EventHandler(this.button2_Click);
			// 
			// btnFind
			// 
			this.btnFind.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnFind.Location = new System.Drawing.Point(2, 144);
			this.btnFind.Name = "btnFind";
			this.btnFind.Size = new System.Drawing.Size(110, 48);
			this.btnFind.TabIndex = 5;
			this.btnFind.Text = "Поиск сообщения";
			this.btnFind.UseVisualStyleBackColor = false;
			this.btnFind.Visible = false;
			this.btnFind.Click += new System.EventHandler(this.button3_Click);
			// 
			// tbxFind
			// 
			this.tbxFind.Location = new System.Drawing.Point(118, 619);
			this.tbxFind.Multiline = true;
			this.tbxFind.Name = "tbxFind";
			this.tbxFind.Size = new System.Drawing.Size(888, 38);
			this.tbxFind.TabIndex = 0;
			this.tbxFind.Visible = false;
			this.tbxFind.TextChanged += new System.EventHandler(this.tbxFind_TextChanged);
			// 
			// btnOptions
			// 
			this.btnOptions.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnOptions.Location = new System.Drawing.Point(2, 340);
			this.btnOptions.Name = "btnOptions";
			this.btnOptions.Size = new System.Drawing.Size(110, 34);
			this.btnOptions.TabIndex = 6;
			this.btnOptions.Text = "Настройки";
			this.btnOptions.UseVisualStyleBackColor = false;
			this.btnOptions.Visible = false;
			this.btnOptions.Click += new System.EventHandler(this.btnOptions_Click);
			// 
			// btnMenu
			// 
			this.btnMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnMenu.Location = new System.Drawing.Point(12, 86);
			this.btnMenu.Name = "btnMenu";
			this.btnMenu.Size = new System.Drawing.Size(76, 40);
			this.btnMenu.TabIndex = 7;
			this.btnMenu.Text = " Меню";
			this.btnMenu.UseVisualStyleBackColor = false;
			this.btnMenu.Click += new System.EventHandler(this.button2_Click_1);
			// 
			// btnConsole
			// 
			this.btnConsole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.btnConsole.Location = new System.Drawing.Point(2, 426);
			this.btnConsole.Name = "btnConsole";
			this.btnConsole.Size = new System.Drawing.Size(110, 34);
			this.btnConsole.TabIndex = 8;
			this.btnConsole.Text = "Консоль";
			this.btnConsole.UseVisualStyleBackColor = false;
			this.btnConsole.Visible = false;
			this.btnConsole.Click += new System.EventHandler(this.btnConsole_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.ForeColor = System.Drawing.Color.Maroon;
			this.label1.Location = new System.Drawing.Point(247, 678);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(693, 19);
			this.label1.TabIndex = 9;
			this.label1.Text = "Поиск работает посимвольно. Если сообщений нет, попробуйте пролистнуть поле сообщ" +
    "ений вверх.";
			this.label1.Visible = false;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.pictureBox1);
			this.panel1.Location = new System.Drawing.Point(12, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1110, 76);
			this.panel1.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AccessibleRole = System.Windows.Forms.AccessibleRole.TitleBar;
			this.label2.AutoSize = true;
			this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.label2.Location = new System.Drawing.Point(483, 19);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(162, 39);
			this.label2.TabIndex = 1;
			this.label2.Text = "Общий чат";
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
			this.pictureBox1.Image = global::Чатик.Properties.Resources.iconChat;
			this.pictureBox1.Location = new System.Drawing.Point(1040, 0);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(67, 58);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// Chats
			// 
			this.AcceptButton = this.btnSend;
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
			this.ClientSize = new System.Drawing.Size(1134, 730);
			this.ControlBox = false;
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.btnConsole);
			this.Controls.Add(this.btnMenu);
			this.Controls.Add(this.btnOptions);
			this.Controls.Add(this.tbxFind);
			this.Controls.Add(this.btnFind);
			this.Controls.Add(this.btnExAc);
			this.Controls.Add(this.btnExitProg);
			this.Controls.Add(this.btnObnov);
			this.Controls.Add(this.btnSend);
			this.Controls.Add(this.tbxMess);
			this.Controls.Add(this.MainPanel);
			this.DoubleBuffered = true;
			this.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "Chats";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Общий чатик";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Chats_KeyDown);
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel MainPanel;
		private System.Windows.Forms.TextBox tbxMess;
		private System.Windows.Forms.Button btnSend;
		private System.Windows.Forms.Button btnObnov;
		private System.Windows.Forms.Button btnExitProg;
		private System.Windows.Forms.Button btnExAc;
		private System.Windows.Forms.Button btnFind;
		private System.Windows.Forms.TextBox tbxFind;
		private System.Windows.Forms.Button btnOptions;
		private System.Windows.Forms.Button btnMenu;
		private System.Windows.Forms.Button btnConsole;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timerDB;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Label label2;
	}
}

namespace Чатик
{
	partial class FormConsole
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormConsole));
			this.btnMute = new System.Windows.Forms.Button();
			this.cbxLogs = new System.Windows.Forms.ComboBox();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.chatAEEDataSet1 = new Чатик.ChatAEEDataSet();
			this.bsUser = new System.Windows.Forms.BindingSource(this.components);
			this.tbxLog = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.tbxHours = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnBan = new System.Windows.Forms.Button();
			this.usersTableAdapter = new Чатик.ChatAEEDataSetTableAdapters.UsersTableAdapter();
			this.lblIDUsN = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.tbxPrichina = new System.Windows.Forms.TextBox();
			this.lblLog = new System.Windows.Forms.Label();
			this.users1TableAdapter = new Чатик.ChatAEEDataSetTableAdapters.Users1TableAdapter();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.chatAEEDataSet1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bsUser)).BeginInit();
			this.SuspendLayout();
			// 
			// btnMute
			// 
			this.btnMute.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnMute.Location = new System.Drawing.Point(96, 258);
			this.btnMute.Name = "btnMute";
			this.btnMute.Size = new System.Drawing.Size(110, 34);
			this.btnMute.TabIndex = 7;
			this.btnMute.Text = "Выдать мут";
			this.btnMute.UseVisualStyleBackColor = false;
			this.btnMute.Visible = false;
			this.btnMute.Click += new System.EventHandler(this.btnOptions_Click);
			// 
			// cbxLogs
			// 
			this.cbxLogs.DataSource = this.bindingSource1;
			this.cbxLogs.DisplayMember = "LoginU";
			this.cbxLogs.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbxLogs.FormattingEnabled = true;
			this.cbxLogs.Location = new System.Drawing.Point(200, 93);
			this.cbxLogs.Name = "cbxLogs";
			this.cbxLogs.Size = new System.Drawing.Size(193, 24);
			this.cbxLogs.TabIndex = 8;
			// 
			// bindingSource1
			// 
			this.bindingSource1.DataMember = "Users1";
			this.bindingSource1.DataSource = this.chatAEEDataSet1;
			// 
			// chatAEEDataSet1
			// 
			this.chatAEEDataSet1.DataSetName = "ChatAEEDataSet";
			this.chatAEEDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// bsUser
			// 
			this.bsUser.DataMember = "Users";
			this.bsUser.DataSource = this.chatAEEDataSet1;
			// 
			// tbxLog
			// 
			this.tbxLog.Location = new System.Drawing.Point(299, 24);
			this.tbxLog.Name = "tbxLog";
			this.tbxLog.Size = new System.Drawing.Size(194, 22);
			this.tbxLog.TabIndex = 9;
			this.tbxLog.TextChanged += new System.EventHandler(this.tbxLog_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(77, 93);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "Пользователь:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(166, 24);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(117, 20);
			this.label2.TabIndex = 11;
			this.label2.Text = "Поиск логина:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(411, 93);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(25, 20);
			this.label3.TabIndex = 12;
			this.label3.Text = "на";
			// 
			// tbxHours
			// 
			this.tbxHours.Location = new System.Drawing.Point(442, 93);
			this.tbxHours.Name = "tbxHours";
			this.tbxHours.Size = new System.Drawing.Size(80, 22);
			this.tbxHours.TabIndex = 13;
			this.tbxHours.TextChanged += new System.EventHandler(this.tbxPrichina_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(528, 93);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(53, 20);
			this.label4.TabIndex = 14;
			this.label4.Text = "часов.";
			// 
			// btnBan
			// 
			this.btnBan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
			this.btnBan.Location = new System.Drawing.Point(558, 258);
			this.btnBan.Name = "btnBan";
			this.btnBan.Size = new System.Drawing.Size(110, 34);
			this.btnBan.TabIndex = 15;
			this.btnBan.Text = "Выдать бан";
			this.btnBan.UseVisualStyleBackColor = false;
			this.btnBan.Visible = false;
			this.btnBan.Click += new System.EventHandler(this.btnBan_Click);
			// 
			// usersTableAdapter
			// 
			this.usersTableAdapter.ClearBeforeFill = true;
			// 
			// lblIDUsN
			// 
			this.lblIDUsN.AutoSize = true;
			this.lblIDUsN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "IDUser", true));
			this.lblIDUsN.Location = new System.Drawing.Point(833, 144);
			this.lblIDUsN.Name = "lblIDUsN";
			this.lblIDUsN.Size = new System.Drawing.Size(46, 17);
			this.lblIDUsN.TabIndex = 16;
			this.lblIDUsN.Text = "label5";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Comic Sans MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.Location = new System.Drawing.Point(115, 155);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(79, 20);
			this.label5.TabIndex = 18;
			this.label5.Text = "Причина:";
			// 
			// tbxPrichina
			// 
			this.tbxPrichina.Location = new System.Drawing.Point(200, 153);
			this.tbxPrichina.Multiline = true;
			this.tbxPrichina.Name = "tbxPrichina";
			this.tbxPrichina.Size = new System.Drawing.Size(381, 44);
			this.tbxPrichina.TabIndex = 17;
			this.tbxPrichina.TextChanged += new System.EventHandler(this.tbxPrichina_TextChanged);
			// 
			// lblLog
			// 
			this.lblLog.AutoSize = true;
			this.lblLog.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.bindingSource1, "LoginU", true));
			this.lblLog.Location = new System.Drawing.Point(836, 179);
			this.lblLog.Name = "lblLog";
			this.lblLog.Size = new System.Drawing.Size(46, 17);
			this.lblLog.TabIndex = 19;
			this.lblLog.Text = "label6";
			// 
			// users1TableAdapter
			// 
			this.users1TableAdapter.ClearBeforeFill = true;
			// 
			// FormConsole
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Silver;
			this.ClientSize = new System.Drawing.Size(773, 331);
			this.Controls.Add(this.lblLog);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbxPrichina);
			this.Controls.Add(this.lblIDUsN);
			this.Controls.Add(this.btnBan);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.tbxHours);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.tbxLog);
			this.Controls.Add(this.cbxLogs);
			this.Controls.Add(this.btnMute);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MaximizeBox = false;
			this.Name = "FormConsole";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "Консоль для модерирования";
			this.Load += new System.EventHandler(this.FormConsole_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.chatAEEDataSet1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bsUser)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btnMute;
		private System.Windows.Forms.ComboBox cbxLogs;
		private System.Windows.Forms.TextBox tbxLog;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox tbxHours;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Button btnBan;
		private System.Windows.Forms.BindingSource bsUser;
		private ChatAEEDataSet chatAEEDataSet1;
		private ChatAEEDataSetTableAdapters.UsersTableAdapter usersTableAdapter;
		private System.Windows.Forms.Label lblIDUsN;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox tbxPrichina;
		private System.Windows.Forms.Label lblLog;
		private System.Windows.Forms.BindingSource bindingSource1;
		private ChatAEEDataSetTableAdapters.Users1TableAdapter users1TableAdapter;
	}
}
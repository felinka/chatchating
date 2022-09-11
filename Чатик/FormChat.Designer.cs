
namespace Чатик
{
	partial class FormChat
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.lblText = new System.Windows.Forms.Label();
			this.lblFIO = new System.Windows.Forms.Label();
			this.lblDate = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lblDate);
			this.panel1.Controls.Add(this.lblText);
			this.panel1.Controls.Add(this.lblFIO);
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(805, 174);
			this.panel1.TabIndex = 0;
			this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
			// 
			// lblText
			// 
			this.lblText.BackColor = System.Drawing.Color.LemonChiffon;
			this.lblText.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.lblText.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.lblText.Font = new System.Drawing.Font("Comic Sans MS", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblText.Location = new System.Drawing.Point(35, 32);
			this.lblText.Name = "lblText";
			this.lblText.Size = new System.Drawing.Size(734, 110);
			this.lblText.TabIndex = 1;
			this.lblText.Text = "label2";
			// 
			// lblFIO
			// 
			this.lblFIO.AutoSize = true;
			this.lblFIO.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblFIO.ForeColor = System.Drawing.Color.Green;
			this.lblFIO.Location = new System.Drawing.Point(35, 3);
			this.lblFIO.Name = "lblFIO";
			this.lblFIO.Size = new System.Drawing.Size(57, 24);
			this.lblFIO.TabIndex = 0;
			this.lblFIO.Text = "label1";
			// 
			// lblDate
			// 
			this.lblDate.AutoSize = true;
			this.lblDate.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.lblDate.ForeColor = System.Drawing.Color.Green;
			this.lblDate.Location = new System.Drawing.Point(565, 3);
			this.lblDate.Name = "lblDate";
			this.lblDate.Size = new System.Drawing.Size(59, 24);
			this.lblDate.TabIndex = 2;
			this.lblDate.Text = "label3";
			// 
			// FormChat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.ClientSize = new System.Drawing.Size(829, 498);
			this.Controls.Add(this.panel1);
			this.Name = "FormChat";
			this.Text = "FormChat";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		public System.Windows.Forms.Label lblDate;
		public System.Windows.Forms.Panel panel1;
		public System.Windows.Forms.Label lblText;
		public System.Windows.Forms.Label lblFIO;
	}
}
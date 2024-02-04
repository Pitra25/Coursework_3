using System.Windows.Forms;

namespace Coursework_3
{
	partial class NewBooks
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewBooks));
            this.DeliteImgBtn = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.NameTb = new System.Windows.Forms.TextBox();
            this.AvtarTb = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.AboutAuthorTb = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.AboutBookTb = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AdditionBtn = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.ControlName = new System.Windows.Forms.Label();
            this.ControlAvtar = new System.Windows.Forms.Label();
            this.ControlCheck = new System.Windows.Forms.Label();
            this.LocationTb = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // DeliteImgBtn
            // 
            this.DeliteImgBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.DeliteImgBtn.Location = new System.Drawing.Point(164, 475);
            this.DeliteImgBtn.Name = "DeliteImgBtn";
            this.DeliteImgBtn.Size = new System.Drawing.Size(149, 35);
            this.DeliteImgBtn.TabIndex = 1;
            this.DeliteImgBtn.Text = "Сброс картинки";
            this.DeliteImgBtn.UseVisualStyleBackColor = true;
            // 
            // pictureBox
            // 
            this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(301, 457);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox.TabIndex = 0;
            this.pictureBox.TabStop = false;
            this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(346, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Название";
            // 
            // NameTb
            // 
            this.NameTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NameTb.Location = new System.Drawing.Point(334, 78);
            this.NameTb.Name = "NameTb";
            this.NameTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.NameTb.Size = new System.Drawing.Size(435, 26);
            this.NameTb.TabIndex = 3;
            this.NameTb.TextChanged += new System.EventHandler(this.NameTb_TextChanged);
            // 
            // AvtarTb
            // 
            this.AvtarTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AvtarTb.Location = new System.Drawing.Point(334, 142);
            this.AvtarTb.Name = "AvtarTb";
            this.AvtarTb.Size = new System.Drawing.Size(435, 26);
            this.AvtarTb.TabIndex = 5;
            this.AvtarTb.TextChanged += new System.EventHandler(this.AvtarTb_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(346, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Автор (ы)";
            // 
            // AboutAuthorTb
            // 
            this.AboutAuthorTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutAuthorTb.Location = new System.Drawing.Point(334, 202);
            this.AboutAuthorTb.Multiline = true;
            this.AboutAuthorTb.Name = "AboutAuthorTb";
            this.AboutAuthorTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AboutAuthorTb.Size = new System.Drawing.Size(435, 105);
            this.AboutAuthorTb.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(346, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Об авторе";
            // 
            // AboutBookTb
            // 
            this.AboutBookTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AboutBookTb.Location = new System.Drawing.Point(334, 350);
            this.AboutBookTb.Multiline = true;
            this.AboutBookTb.Name = "AboutBookTb";
            this.AboutBookTb.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.AboutBookTb.Size = new System.Drawing.Size(435, 105);
            this.AboutBookTb.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(346, 327);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "О книге";
            // 
            // AdditionBtn
            // 
            this.AdditionBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.AdditionBtn.Location = new System.Drawing.Point(410, 527);
            this.AdditionBtn.Name = "AdditionBtn";
            this.AdditionBtn.Size = new System.Drawing.Size(199, 37);
            this.AdditionBtn.TabIndex = 10;
            this.AdditionBtn.Text = "Добавить";
            this.AdditionBtn.UseVisualStyleBackColor = true;
            this.AdditionBtn.Click += new System.EventHandler(this.AdditionBtn_Click);
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(484, 12);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 30);
            this.label6.TabIndex = 15;
            this.label6.Text = "Добавление";
            // 
            // ControlName
            // 
            this.ControlName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlName.ForeColor = System.Drawing.Color.Red;
            this.ControlName.Location = new System.Drawing.Point(425, 52);
            this.ControlName.Name = "ControlName";
            this.ControlName.Size = new System.Drawing.Size(16, 16);
            this.ControlName.TabIndex = 16;
            this.ControlName.Text = "*";
            // 
            // ControlAvtar
            // 
            this.ControlAvtar.BackColor = System.Drawing.Color.Transparent;
            this.ControlAvtar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlAvtar.ForeColor = System.Drawing.Color.Red;
            this.ControlAvtar.Location = new System.Drawing.Point(422, 115);
            this.ControlAvtar.Name = "ControlAvtar";
            this.ControlAvtar.Size = new System.Drawing.Size(16, 15);
            this.ControlAvtar.TabIndex = 17;
            this.ControlAvtar.Text = "*";
            // 
            // ControlCheck
            // 
            this.ControlCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ControlCheck.ForeColor = System.Drawing.Color.Red;
            this.ControlCheck.Location = new System.Drawing.Point(563, 458);
            this.ControlCheck.Name = "ControlCheck";
            this.ControlCheck.Size = new System.Drawing.Size(16, 16);
            this.ControlCheck.TabIndex = 18;
            this.ControlCheck.Text = "*";
            // 
            // LocationTb
            // 
            this.LocationTb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LocationTb.Location = new System.Drawing.Point(334, 484);
            this.LocationTb.Name = "LocationTb";
            this.LocationTb.Size = new System.Drawing.Size(435, 26);
            this.LocationTb.TabIndex = 19;
            this.LocationTb.TextChanged += new System.EventHandler(this.LocationTb_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(346, 461);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(222, 20);
            this.label5.TabIndex = 20;
            this.label5.Text = "Распололжение (полка/ряд)";
            // 
            // NewBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 576);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LocationTb);
            this.Controls.Add(this.ControlCheck);
            this.Controls.Add(this.ControlAvtar);
            this.Controls.Add(this.ControlName);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.AdditionBtn);
            this.Controls.Add(this.AboutBookTb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.AboutAuthorTb);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.AvtarTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NameTb);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DeliteImgBtn);
            this.Controls.Add(this.pictureBox);
            this.Name = "NewBooks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление книг/журналов";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewBooks_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		public PictureBox pictureBox;
		private Button DeliteImgBtn;
		private Label label1;
		private TextBox NameTb;
		private TextBox AvtarTb;
		private Label label2;
		private TextBox AboutAuthorTb;
		private Label label3;
		private TextBox AboutBookTb;
		private Label label4;
		private Button AdditionBtn;
		private Label label6;
		private Label ControlName;
		private Label ControlAvtar;
		private Label ControlCheck;
		private TextBox LocationTb;
		private Label label5;
	}
}
namespace Coursework_3
{
	partial class LogIn_Form
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
			this.label_Nameblock = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.LogIn_btn = new System.Windows.Forms.Button();
			this.label_Pass = new System.Windows.Forms.Label();
			this.Pass_Field = new System.Windows.Forms.TextBox();
			this.label_Login = new System.Windows.Forms.Label();
			this.Login_Field = new System.Windows.Forms.TextBox();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label_Nameblock
			// 
			this.label_Nameblock.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label_Nameblock.Font = new System.Drawing.Font("Corbel Light", 35F);
			this.label_Nameblock.Location = new System.Drawing.Point(0, 0);
			this.label_Nameblock.Name = "label_Nameblock";
			this.label_Nameblock.Size = new System.Drawing.Size(492, 113);
			this.label_Nameblock.TabIndex = 3;
			this.label_Nameblock.Text = "Вход";
			this.label_Nameblock.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.label_Nameblock);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(492, 113);
			this.panel1.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.LogIn_btn);
			this.panel2.Controls.Add(this.label_Pass);
			this.panel2.Controls.Add(this.Pass_Field);
			this.panel2.Controls.Add(this.label_Login);
			this.panel2.Controls.Add(this.Login_Field);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 113);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(492, 235);
			this.panel2.TabIndex = 5;
			// 
			// LogIn_btn
			// 
			this.LogIn_btn.Font = new System.Drawing.Font("Corbel Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LogIn_btn.ForeColor = System.Drawing.Color.Black;
			this.LogIn_btn.Location = new System.Drawing.Point(149, 170);
			this.LogIn_btn.Name = "LogIn_btn";
			this.LogIn_btn.Size = new System.Drawing.Size(180, 48);
			this.LogIn_btn.TabIndex = 13;
			this.LogIn_btn.Text = "Войти";
			this.LogIn_btn.UseVisualStyleBackColor = true;
			this.LogIn_btn.Click += new System.EventHandler(this.LogIn_btn_Click);
			// 
			// label_Pass
			// 
			this.label_Pass.AutoSize = true;
			this.label_Pass.Font = new System.Drawing.Font("Corbel Light", 14F);
			this.label_Pass.Location = new System.Drawing.Point(117, 89);
			this.label_Pass.Name = "label_Pass";
			this.label_Pass.Size = new System.Drawing.Size(70, 23);
			this.label_Pass.TabIndex = 10;
			this.label_Pass.Text = "Пароль";
			// 
			// Pass_Field
			// 
			this.Pass_Field.Font = new System.Drawing.Font("Candara Light", 14.25F);
			this.Pass_Field.Location = new System.Drawing.Point(119, 115);
			this.Pass_Field.Name = "Pass_Field";
			this.Pass_Field.Size = new System.Drawing.Size(254, 31);
			this.Pass_Field.TabIndex = 4;
			this.Pass_Field.UseSystemPasswordChar = true;
			// 
			// label_Login
			// 
			this.label_Login.AutoSize = true;
			this.label_Login.Font = new System.Drawing.Font("Corbel Light", 14F);
			this.label_Login.Location = new System.Drawing.Point(117, 20);
			this.label_Login.Name = "label_Login";
			this.label_Login.Size = new System.Drawing.Size(60, 23);
			this.label_Login.TabIndex = 9;
			this.label_Login.Text = "Логин";
			// 
			// Login_Field
			// 
			this.Login_Field.Font = new System.Drawing.Font("Candara Light", 14.25F);
			this.Login_Field.Location = new System.Drawing.Point(119, 46);
			this.Login_Field.Name = "Login_Field";
			this.Login_Field.Size = new System.Drawing.Size(254, 31);
			this.Login_Field.TabIndex = 3;
			// 
			// LogIn_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(492, 348);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "LogIn_Form";
			this.Text = "LogInForm";
			this.panel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label label_Nameblock;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label_Pass;
		private System.Windows.Forms.TextBox Pass_Field;
		private System.Windows.Forms.Label label_Login;
		private System.Windows.Forms.TextBox Login_Field;
		private System.Windows.Forms.Button LogIn_btn;
	}
}
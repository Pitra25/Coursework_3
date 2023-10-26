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
			this.label_Login_btn = new System.Windows.Forms.Label();
			this.label_registration = new System.Windows.Forms.Label();
			this.Registration_btn = new System.Windows.Forms.Button();
			this.LogIn_btn = new System.Windows.Forms.Button();
			this.checkBox_Conset = new System.Windows.Forms.CheckBox();
			this.label_Pass_repeat = new System.Windows.Forms.Label();
			this.Pass_repeat_Field = new System.Windows.Forms.TextBox();
			this.label_Pass = new System.Windows.Forms.Label();
			this.Pass_Field = new System.Windows.Forms.TextBox();
			this.label_Login = new System.Windows.Forms.Label();
			this.Login_Field = new System.Windows.Forms.TextBox();
			this.label_LastName = new System.Windows.Forms.Label();
			this.Last_Name_Field = new System.Windows.Forms.TextBox();
			this.label_Name = new System.Windows.Forms.Label();
			this.Name_Field = new System.Windows.Forms.TextBox();
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
			this.label_Nameblock.Size = new System.Drawing.Size(513, 113);
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
			this.panel1.Size = new System.Drawing.Size(513, 113);
			this.panel1.TabIndex = 4;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.label_Login_btn);
			this.panel2.Controls.Add(this.label_registration);
			this.panel2.Controls.Add(this.Registration_btn);
			this.panel2.Controls.Add(this.LogIn_btn);
			this.panel2.Controls.Add(this.checkBox_Conset);
			this.panel2.Controls.Add(this.label_Pass_repeat);
			this.panel2.Controls.Add(this.Pass_repeat_Field);
			this.panel2.Controls.Add(this.label_Pass);
			this.panel2.Controls.Add(this.Pass_Field);
			this.panel2.Controls.Add(this.label_Login);
			this.panel2.Controls.Add(this.Login_Field);
			this.panel2.Controls.Add(this.label_LastName);
			this.panel2.Controls.Add(this.Last_Name_Field);
			this.panel2.Controls.Add(this.label_Name);
			this.panel2.Controls.Add(this.Name_Field);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 113);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(513, 289);
			this.panel2.TabIndex = 5;
			// 
			// label_Login_btn
			// 
			this.label_Login_btn.AutoSize = true;
			this.label_Login_btn.Font = new System.Drawing.Font("Corbel Light", 12F);
			this.label_Login_btn.Location = new System.Drawing.Point(377, 265);
			this.label_Login_btn.Name = "label_Login_btn";
			this.label_Login_btn.Size = new System.Drawing.Size(51, 19);
			this.label_Login_btn.TabIndex = 16;
			this.label_Login_btn.Text = "Войти";
			this.label_Login_btn.Click += new System.EventHandler(this.label_Login_btn_Click);
			// 
			// label_registration
			// 
			this.label_registration.AutoSize = true;
			this.label_registration.Font = new System.Drawing.Font("Corbel Light", 12F);
			this.label_registration.Location = new System.Drawing.Point(330, 265);
			this.label_registration.Name = "label_registration";
			this.label_registration.Size = new System.Drawing.Size(149, 19);
			this.label_registration.TabIndex = 15;
			this.label_registration.Text = "Зарегестрироваться";
			this.label_registration.Click += new System.EventHandler(this.label_registration_btn_Click);
			// 
			// Registration_btn
			// 
			this.Registration_btn.Font = new System.Drawing.Font("Corbel Light", 20.25F);
			this.Registration_btn.ForeColor = System.Drawing.Color.Black;
			this.Registration_btn.Location = new System.Drawing.Point(300, 214);
			this.Registration_btn.Name = "Registration_btn";
			this.Registration_btn.Size = new System.Drawing.Size(180, 48);
			this.Registration_btn.TabIndex = 14;
			this.Registration_btn.Text = "Регистрация";
			this.Registration_btn.UseVisualStyleBackColor = true;
			this.Registration_btn.Visible = false;
			this.Registration_btn.Click += new System.EventHandler(this.Registration_btn_Click);
			// 
			// LogIn_btn
			// 
			this.LogIn_btn.Font = new System.Drawing.Font("Corbel Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LogIn_btn.ForeColor = System.Drawing.Color.Black;
			this.LogIn_btn.Location = new System.Drawing.Point(114, 214);
			this.LogIn_btn.Name = "LogIn_btn";
			this.LogIn_btn.Size = new System.Drawing.Size(180, 48);
			this.LogIn_btn.TabIndex = 13;
			this.LogIn_btn.Text = "Войти";
			this.LogIn_btn.UseVisualStyleBackColor = true;
			this.LogIn_btn.Click += new System.EventHandler(this.LogIn_btn_Click);
			// 
			// checkBox_Conset
			// 
			this.checkBox_Conset.AutoSize = true;
			this.checkBox_Conset.Font = new System.Drawing.Font("Corbel Light", 10F);
			this.checkBox_Conset.Location = new System.Drawing.Point(261, 170);
			this.checkBox_Conset.Name = "checkBox_Conset";
			this.checkBox_Conset.Size = new System.Drawing.Size(209, 21);
			this.checkBox_Conset.TabIndex = 6;
			this.checkBox_Conset.Text = "Согласие на обработку данных";
			this.checkBox_Conset.UseVisualStyleBackColor = true;
			this.checkBox_Conset.Visible = false;
			// 
			// label_Pass_repeat
			// 
			this.label_Pass_repeat.AutoEllipsis = true;
			this.label_Pass_repeat.AutoSize = true;
			this.label_Pass_repeat.Font = new System.Drawing.Font("Corbel Light", 14F);
			this.label_Pass_repeat.Location = new System.Drawing.Point(258, 78);
			this.label_Pass_repeat.Name = "label_Pass_repeat";
			this.label_Pass_repeat.Size = new System.Drawing.Size(158, 23);
			this.label_Pass_repeat.TabIndex = 11;
			this.label_Pass_repeat.Text = "Повторить пароль";
			this.label_Pass_repeat.Visible = false;
			// 
			// Pass_repeat_Field
			// 
			this.Pass_repeat_Field.Font = new System.Drawing.Font("Candara Light", 14.25F);
			this.Pass_repeat_Field.Location = new System.Drawing.Point(261, 104);
			this.Pass_repeat_Field.Name = "Pass_repeat_Field";
			this.Pass_repeat_Field.Size = new System.Drawing.Size(209, 31);
			this.Pass_repeat_Field.TabIndex = 5;
			this.Pass_repeat_Field.UseSystemPasswordChar = true;
			this.Pass_repeat_Field.Visible = false;
			// 
			// label_Pass
			// 
			this.label_Pass.AutoSize = true;
			this.label_Pass.Font = new System.Drawing.Font("Corbel Light", 14F);
			this.label_Pass.Location = new System.Drawing.Point(258, 19);
			this.label_Pass.Name = "label_Pass";
			this.label_Pass.Size = new System.Drawing.Size(70, 23);
			this.label_Pass.TabIndex = 10;
			this.label_Pass.Text = "Пароль";
			// 
			// Pass_Field
			// 
			this.Pass_Field.Font = new System.Drawing.Font("Candara Light", 14.25F);
			this.Pass_Field.Location = new System.Drawing.Point(261, 46);
			this.Pass_Field.Name = "Pass_Field";
			this.Pass_Field.Size = new System.Drawing.Size(209, 31);
			this.Pass_Field.TabIndex = 4;
			this.Pass_Field.UseSystemPasswordChar = true;
			// 
			// label_Login
			// 
			this.label_Login.AutoSize = true;
			this.label_Login.Font = new System.Drawing.Font("Corbel Light", 14F);
			this.label_Login.Location = new System.Drawing.Point(25, 137);
			this.label_Login.Name = "label_Login";
			this.label_Login.Size = new System.Drawing.Size(60, 23);
			this.label_Login.TabIndex = 9;
			this.label_Login.Text = "Логин";
			// 
			// Login_Field
			// 
			this.Login_Field.Font = new System.Drawing.Font("Candara Light", 14.25F);
			this.Login_Field.Location = new System.Drawing.Point(27, 163);
			this.Login_Field.Name = "Login_Field";
			this.Login_Field.Size = new System.Drawing.Size(209, 31);
			this.Login_Field.TabIndex = 3;
			this.Login_Field.Enter += new System.EventHandler(this.Login_Field_Enter);
			this.Login_Field.Leave += new System.EventHandler(this.Login_Field_Leave);
			// 
			// label_LastName
			// 
			this.label_LastName.AutoSize = true;
			this.label_LastName.Font = new System.Drawing.Font("Corbel Light", 14F);
			this.label_LastName.Location = new System.Drawing.Point(23, 78);
			this.label_LastName.Name = "label_LastName";
			this.label_LastName.Size = new System.Drawing.Size(84, 23);
			this.label_LastName.TabIndex = 8;
			this.label_LastName.Text = "Фамилия";
			this.label_LastName.Visible = false;
			// 
			// Last_Name_Field
			// 
			this.Last_Name_Field.Font = new System.Drawing.Font("Candara Light", 14.25F);
			this.Last_Name_Field.Location = new System.Drawing.Point(28, 104);
			this.Last_Name_Field.Name = "Last_Name_Field";
			this.Last_Name_Field.Size = new System.Drawing.Size(209, 31);
			this.Last_Name_Field.TabIndex = 2;
			this.Last_Name_Field.Enter += new System.EventHandler(this.Last_Name_Field_Enter);
			this.Last_Name_Field.Leave += new System.EventHandler(this.Last_Name_Field_Leave);
			// 
			// label_Name
			// 
			this.label_Name.AutoSize = true;
			this.label_Name.Font = new System.Drawing.Font("Corbel Light", 14F);
			this.label_Name.Location = new System.Drawing.Point(24, 19);
			this.label_Name.Name = "label_Name";
			this.label_Name.Size = new System.Drawing.Size(44, 23);
			this.label_Name.TabIndex = 7;
			this.label_Name.Text = "Имя";
			this.label_Name.Visible = false;
			// 
			// Name_Field
			// 
			this.Name_Field.Font = new System.Drawing.Font("Candara Light", 14.25F);
			this.Name_Field.Location = new System.Drawing.Point(27, 45);
			this.Name_Field.Name = "Name_Field";
			this.Name_Field.Size = new System.Drawing.Size(209, 31);
			this.Name_Field.TabIndex = 1;
			this.Name_Field.Enter += new System.EventHandler(this.Name_Field_Enter);
			this.Name_Field.Leave += new System.EventHandler(this.Name_Field_Leave);
			// 
			// LogIn_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(513, 402);
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
		private System.Windows.Forms.Label label_Pass_repeat;
		private System.Windows.Forms.TextBox Pass_repeat_Field;
		private System.Windows.Forms.Label label_Pass;
		private System.Windows.Forms.TextBox Pass_Field;
		private System.Windows.Forms.Label label_Login;
		private System.Windows.Forms.TextBox Login_Field;
		private System.Windows.Forms.Label label_LastName;
		private System.Windows.Forms.TextBox Last_Name_Field;
		private System.Windows.Forms.Label label_Name;
		private System.Windows.Forms.TextBox Name_Field;
		private System.Windows.Forms.Button Registration_btn;
		private System.Windows.Forms.Button LogIn_btn;
		private System.Windows.Forms.CheckBox checkBox_Conset;
		private System.Windows.Forms.Label label_registration;
		private System.Windows.Forms.Label label_Login_btn;
	}
}
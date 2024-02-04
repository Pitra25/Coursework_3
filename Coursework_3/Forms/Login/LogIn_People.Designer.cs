using System.Windows.Forms;

namespace Coursework_3
{
	partial class LogIn_People
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LogIn_People));
			this.Registration_btn = new System.Windows.Forms.Button();
			this.Name_Field = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.LastName_Field = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Patronymic_Field = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.Position_Field = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.Login_Field = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.Password_Field = new System.Windows.Forms.TextBox();
			this.panel4 = new System.Windows.Forms.Panel();
			this.pictureBoxPassword = new System.Windows.Forms.PictureBox();
			this.Repeat_Password_Field = new System.Windows.Forms.TextBox();
			this.label16 = new System.Windows.Forms.Label();
			this.panel5 = new System.Windows.Forms.Panel();
			this.EducatorCheckBox = new System.Windows.Forms.CheckBox();
			this.StudentCheckBox = new System.Windows.Forms.CheckBox();
			this.panel2 = new System.Windows.Forms.Panel();
			this.DeliteImgBtn = new System.Windows.Forms.Button();
			this.label12 = new System.Windows.Forms.Label();
			this.Email_Field = new System.Windows.Forms.TextBox();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.label8 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.Series_Field = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.Number_Field = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.Nationality_Field = new System.Windows.Forms.TextBox();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.dataGridView2 = new System.Windows.Forms.DataGridView();
			this.timer_UpdatePictureBox = new System.Windows.Forms.Timer(this.components);
			this.panel4.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).BeginInit();
			this.panel5.SuspendLayout();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
			this.SuspendLayout();
			// 
			// Registration_btn
			// 
			this.Registration_btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.Registration_btn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.Registration_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Registration_btn.Font = new System.Drawing.Font("Calibri Light", 16F, System.Drawing.FontStyle.Bold);
			this.Registration_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(173)))), ((int)(((byte)(79)))));
			this.Registration_btn.Location = new System.Drawing.Point(368, 307);
			this.Registration_btn.Name = "Registration_btn";
			this.Registration_btn.Size = new System.Drawing.Size(194, 46);
			this.Registration_btn.TabIndex = 13;
			this.Registration_btn.Text = "Зарегистрировать";
			this.Registration_btn.UseVisualStyleBackColor = true;
			this.Registration_btn.Click += new System.EventHandler(this.RegistrationBtn_Click);
			// 
			// Name_Field
			// 
			this.Name_Field.BackColor = System.Drawing.Color.Silver;
			this.Name_Field.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Name_Field.Location = new System.Drawing.Point(7, 27);
			this.Name_Field.Name = "Name_Field";
			this.Name_Field.Size = new System.Drawing.Size(141, 25);
			this.Name_Field.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(173)))), ((int)(((byte)(79)))));
			this.label1.Location = new System.Drawing.Point(4, 6);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(38, 18);
			this.label1.TabIndex = 24;
			this.label1.Text = "Имя";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(173)))), ((int)(((byte)(79)))));
			this.label2.Location = new System.Drawing.Point(3, 58);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(73, 18);
			this.label2.TabIndex = 26;
			this.label2.Text = "Фамилия";
			// 
			// LastName_Field
			// 
			this.LastName_Field.BackColor = System.Drawing.Color.Silver;
			this.LastName_Field.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.LastName_Field.Location = new System.Drawing.Point(6, 79);
			this.LastName_Field.Name = "LastName_Field";
			this.LastName_Field.Size = new System.Drawing.Size(141, 25);
			this.LastName_Field.TabIndex = 2;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(173)))), ((int)(((byte)(79)))));
			this.label3.Location = new System.Drawing.Point(3, 112);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(75, 18);
			this.label3.TabIndex = 28;
			this.label3.Text = "Отчество";
			// 
			// Patronymic_Field
			// 
			this.Patronymic_Field.BackColor = System.Drawing.Color.Silver;
			this.Patronymic_Field.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Patronymic_Field.Location = new System.Drawing.Point(6, 133);
			this.Patronymic_Field.Name = "Patronymic_Field";
			this.Patronymic_Field.Size = new System.Drawing.Size(141, 25);
			this.Patronymic_Field.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.ForeColor = System.Drawing.Color.Silver;
			this.label4.Location = new System.Drawing.Point(3, 167);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(89, 18);
			this.label4.TabIndex = 30;
			this.label4.Text = "Должность";
			// 
			// Position_Field
			// 
			this.Position_Field.BackColor = System.Drawing.Color.Silver;
			this.Position_Field.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Position_Field.Location = new System.Drawing.Point(6, 188);
			this.Position_Field.Name = "Position_Field";
			this.Position_Field.Size = new System.Drawing.Size(141, 25);
			this.Position_Field.TabIndex = 4;
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(173)))), ((int)(((byte)(79)))));
			this.label10.Location = new System.Drawing.Point(4, 6);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(50, 18);
			this.label10.TabIndex = 42;
			this.label10.Text = "Логин";
			// 
			// Login_Field
			// 
			this.Login_Field.BackColor = System.Drawing.Color.Silver;
			this.Login_Field.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Login_Field.Location = new System.Drawing.Point(7, 27);
			this.Login_Field.Name = "Login_Field";
			this.Login_Field.Size = new System.Drawing.Size(141, 25);
			this.Login_Field.TabIndex = 5;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(173)))), ((int)(((byte)(79)))));
			this.label11.Location = new System.Drawing.Point(156, 6);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(61, 18);
			this.label11.TabIndex = 44;
			this.label11.Text = "Пароль";
			// 
			// Password_Field
			// 
			this.Password_Field.BackColor = System.Drawing.Color.Silver;
			this.Password_Field.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Password_Field.Location = new System.Drawing.Point(159, 27);
			this.Password_Field.Name = "Password_Field";
			this.Password_Field.Size = new System.Drawing.Size(141, 25);
			this.Password_Field.TabIndex = 6;
			this.Password_Field.UseSystemPasswordChar = true;
			// 
			// panel4
			// 
			this.panel4.Controls.Add(this.pictureBoxPassword);
			this.panel4.Controls.Add(this.Repeat_Password_Field);
			this.panel4.Controls.Add(this.label16);
			this.panel4.Controls.Add(this.label10);
			this.panel4.Controls.Add(this.Login_Field);
			this.panel4.Controls.Add(this.Password_Field);
			this.panel4.Controls.Add(this.label11);
			this.panel4.Location = new System.Drawing.Point(12, 253);
			this.panel4.Name = "panel4";
			this.panel4.Size = new System.Drawing.Size(303, 110);
			this.panel4.TabIndex = 58;
			// 
			// pictureBoxPassword
			// 
			this.pictureBoxPassword.BackColor = System.Drawing.Color.White;
			this.pictureBoxPassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBoxPassword.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBoxPassword.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBoxPassword.Image = global::Coursework_3.Properties.Resources.free_icon_hide;
			this.pictureBoxPassword.Location = new System.Drawing.Point(118, 75);
			this.pictureBoxPassword.Name = "pictureBoxPassword";
			this.pictureBoxPassword.Size = new System.Drawing.Size(29, 25);
			this.pictureBoxPassword.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBoxPassword.TabIndex = 48;
			this.pictureBoxPassword.TabStop = false;
			this.pictureBoxPassword.Click += new System.EventHandler(this.pictureBoxPassword_Click);
			// 
			// Repeat_Password_Field
			// 
			this.Repeat_Password_Field.BackColor = System.Drawing.Color.Silver;
			this.Repeat_Password_Field.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Repeat_Password_Field.Location = new System.Drawing.Point(159, 75);
			this.Repeat_Password_Field.Name = "Repeat_Password_Field";
			this.Repeat_Password_Field.Size = new System.Drawing.Size(141, 25);
			this.Repeat_Password_Field.TabIndex = 7;
			this.Repeat_Password_Field.UseSystemPasswordChar = true;
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(173)))), ((int)(((byte)(79)))));
			this.label16.Location = new System.Drawing.Point(156, 54);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(137, 18);
			this.label16.TabIndex = 46;
			this.label16.Text = "Повторите пароль";
			// 
			// panel5
			// 
			this.panel5.Controls.Add(this.label1);
			this.panel5.Controls.Add(this.Name_Field);
			this.panel5.Controls.Add(this.LastName_Field);
			this.panel5.Controls.Add(this.label2);
			this.panel5.Controls.Add(this.Patronymic_Field);
			this.panel5.Controls.Add(this.label4);
			this.panel5.Controls.Add(this.label3);
			this.panel5.Controls.Add(this.Position_Field);
			this.panel5.Location = new System.Drawing.Point(12, 12);
			this.panel5.Name = "panel5";
			this.panel5.Size = new System.Drawing.Size(175, 221);
			this.panel5.TabIndex = 59;
			// 
			// EducatorCheckBox
			// 
			this.EducatorCheckBox.AutoSize = true;
			this.EducatorCheckBox.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14F, System.Drawing.FontStyle.Bold);
			this.EducatorCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(173)))), ((int)(((byte)(79)))));
			this.EducatorCheckBox.Location = new System.Drawing.Point(368, 239);
			this.EducatorCheckBox.Name = "EducatorCheckBox";
			this.EducatorCheckBox.Size = new System.Drawing.Size(139, 29);
			this.EducatorCheckBox.TabIndex = 11;
			this.EducatorCheckBox.Text = "Сотрудник";
			this.EducatorCheckBox.UseVisualStyleBackColor = true;
			this.EducatorCheckBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.EducatorCheckBox_MouseClick);
			// 
			// StudentCheckBox
			// 
			this.StudentCheckBox.AutoSize = true;
			this.StudentCheckBox.Font = new System.Drawing.Font("Cascadia Mono SemiLight", 14F, System.Drawing.FontStyle.Bold);
			this.StudentCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(198)))), ((int)(((byte)(173)))), ((int)(((byte)(79)))));
			this.StudentCheckBox.Location = new System.Drawing.Point(368, 272);
			this.StudentCheckBox.Name = "StudentCheckBox";
			this.StudentCheckBox.Size = new System.Drawing.Size(175, 29);
			this.StudentCheckBox.TabIndex = 12;
			this.StudentCheckBox.Text = "Пользователь";
			this.StudentCheckBox.UseVisualStyleBackColor = true;
			this.StudentCheckBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.StudentCheckBox_MouseClick);
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.DeliteImgBtn);
			this.panel2.Controls.Add(this.label12);
			this.panel2.Controls.Add(this.Email_Field);
			this.panel2.Controls.Add(this.pictureBox);
			this.panel2.Controls.Add(this.label8);
			this.panel2.Controls.Add(this.label7);
			this.panel2.Controls.Add(this.Series_Field);
			this.panel2.Controls.Add(this.label6);
			this.panel2.Controls.Add(this.Number_Field);
			this.panel2.Controls.Add(this.label5);
			this.panel2.Controls.Add(this.Nationality_Field);
			this.panel2.Location = new System.Drawing.Point(218, 12);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(381, 221);
			this.panel2.TabIndex = 56;
			// 
			// DeliteImgBtn
			// 
			this.DeliteImgBtn.Location = new System.Drawing.Point(232, 179);
			this.DeliteImgBtn.Name = "DeliteImgBtn";
			this.DeliteImgBtn.Size = new System.Drawing.Size(75, 23);
			this.DeliteImgBtn.TabIndex = 13;
			this.DeliteImgBtn.Text = "Сброс";
			this.DeliteImgBtn.UseVisualStyleBackColor = true;
			this.DeliteImgBtn.Click += new System.EventHandler(this.DeleteImgBtn_Click);
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label12.ForeColor = System.Drawing.Color.Silver;
			this.label12.Location = new System.Drawing.Point(13, 167);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(51, 18);
			this.label12.TabIndex = 36;
			this.label12.Text = "Почта";
			// 
			// Email_Field
			// 
			this.Email_Field.BackColor = System.Drawing.Color.Silver;
			this.Email_Field.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Email_Field.Location = new System.Drawing.Point(16, 188);
			this.Email_Field.Name = "Email_Field";
			this.Email_Field.Size = new System.Drawing.Size(141, 25);
			this.Email_Field.TabIndex = 10;
			// 
			// pictureBox
			// 
			this.pictureBox.BackColor = System.Drawing.Color.White;
			this.pictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox.Image")));
			this.pictureBox.Location = new System.Drawing.Point(174, 28);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(193, 136);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 34;
			this.pictureBox.TabStop = false;
			this.pictureBox.Click += new System.EventHandler(this.AttachImgBtn_Click);
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label8.ForeColor = System.Drawing.Color.Silver;
			this.label8.Location = new System.Drawing.Point(182, 6);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(46, 18);
			this.label8.TabIndex = 32;
			this.label8.Text = "Фото";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.ForeColor = System.Drawing.Color.Silver;
			this.label7.Location = new System.Drawing.Point(13, 112);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(51, 18);
			this.label7.TabIndex = 30;
			this.label7.Text = "Серия";
			// 
			// Series_Field
			// 
			this.Series_Field.BackColor = System.Drawing.Color.Silver;
			this.Series_Field.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Series_Field.Location = new System.Drawing.Point(16, 133);
			this.Series_Field.Name = "Series_Field";
			this.Series_Field.Size = new System.Drawing.Size(141, 25);
			this.Series_Field.TabIndex = 9;
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.ForeColor = System.Drawing.Color.Silver;
			this.label6.Location = new System.Drawing.Point(13, 58);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(55, 18);
			this.label6.TabIndex = 28;
			this.label6.Text = "Номер";
			// 
			// Number_Field
			// 
			this.Number_Field.BackColor = System.Drawing.Color.Silver;
			this.Number_Field.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Number_Field.Location = new System.Drawing.Point(16, 79);
			this.Number_Field.Name = "Number_Field";
			this.Number_Field.Size = new System.Drawing.Size(141, 25);
			this.Number_Field.TabIndex = 8;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label5.ForeColor = System.Drawing.Color.Silver;
			this.label5.Location = new System.Drawing.Point(13, 6);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(101, 18);
			this.label5.TabIndex = 26;
			this.label5.Text = "Гражданство";
			// 
			// Nationality_Field
			// 
			this.Nationality_Field.BackColor = System.Drawing.Color.Silver;
			this.Nationality_Field.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Nationality_Field.Location = new System.Drawing.Point(16, 27);
			this.Nationality_Field.Name = "Nationality_Field";
			this.Nationality_Field.Size = new System.Drawing.Size(141, 25);
			this.Nationality_Field.TabIndex = 7;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(322, 289);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(19, 25);
			this.dataGridView1.TabIndex = 62;
			this.dataGridView1.Visible = false;
			// 
			// dataGridView2
			// 
			this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView2.Location = new System.Drawing.Point(322, 320);
			this.dataGridView2.Name = "dataGridView2";
			this.dataGridView2.Size = new System.Drawing.Size(19, 21);
			this.dataGridView2.TabIndex = 63;
			this.dataGridView2.Visible = false;
			// 
			// LogIn_People
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(52)))), ((int)(((byte)(124)))));
			this.ClientSize = new System.Drawing.Size(611, 377);
			this.Controls.Add(this.dataGridView2);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.StudentCheckBox);
			this.Controls.Add(this.EducatorCheckBox);
			this.Controls.Add(this.panel5);
			this.Controls.Add(this.panel4);
			this.Controls.Add(this.Registration_btn);
			this.Name = "LogIn_People";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Добавление нового пользователя/сотрудника";
			this.panel4.ResumeLayout(false);
			this.panel4.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPassword)).EndInit();
			this.panel5.ResumeLayout(false);
			this.panel5.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button Registration_btn;
		private System.Windows.Forms.TextBox Name_Field;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox LastName_Field;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Patronymic_Field;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox Position_Field;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.TextBox Login_Field;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.TextBox Password_Field;
		private System.Windows.Forms.Panel panel4;
		private System.Windows.Forms.Panel panel5;
		private System.Windows.Forms.TextBox Repeat_Password_Field;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.CheckBox EducatorCheckBox;
		private System.Windows.Forms.CheckBox StudentCheckBox;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox Series_Field;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.TextBox Number_Field;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox Nationality_Field;
		public System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.TextBox Email_Field;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridView dataGridView2;
		private System.Windows.Forms.Timer timer_UpdatePictureBox;
		private System.Windows.Forms.Button DeliteImgBtn;
		public System.Windows.Forms.PictureBox pictureBoxPassword;
	}
}
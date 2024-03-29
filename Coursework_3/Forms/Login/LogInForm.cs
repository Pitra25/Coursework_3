﻿using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coursework_3
{
	public partial class LogIn_Form : Form
	{
		public LogIn_Form()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		static BD_Connection db = new BD_Connection();
		DataTable dataTable = new DataTable();
		SqlDataAdapter adapter = new SqlDataAdapter();
		//MySqlCommand command = new MySqlCommand(command_per, db.getConnection());
		SqlCommand command;
		/*
		 * Функция проверки на наличие пользователя в БД. 
		 */
		private void LogIn_btn_Click(object sender, EventArgs e)
		{
			string login = Login_Field.Text;
			string pass1 = Pass_Field.Text;


			if (login != " " && pass1 != " ")
			{
				//command_per = "SELECT * FROM `User` WHERE `Login` = @uL AND `Password` = @uP";
				db.OpenConnection();
					
					/*
					 * Запрос с проверкой данных из бд и из полей на форме.
					 */
					command = new SqlCommand("SELECT * FROM `Users` WHERE `Login` = @uL AND `Password` = @uP", db.getConnection());
					/* 
					 * Присвоение значений из полей на форме и передача их в запрос к бд 
					 */
					command.Parameters.Add("@uL", SqlDbType.VarChar).Value = login;
					command.Parameters.Add("@up", SqlDbType.VarChar).Value = pass1;
			
					adapter.SelectCommand = command;
					adapter.Fill(dataTable);
				db.CloseConnection();

				Console.WriteLine(adapter);

				/*
				 * Проверка если ли такой пользователь в бд
				 */
				if (dataTable.Rows.Count > 0)
				{
					HomForm hom = new HomForm();
					if(login == "ADMIN")
					{
						MessageBox.Show($"С возвращение if {login}.", $"{login}", 
							MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

						try{
							hom.menuStrip_Hom.Items[3].Visible = true;
							hom.menuStrip_Hom.Items[4].Visible = true;
						}
						catch{
							return;
						}
					}
					else
						MessageBox.Show($"С возвращение Else {login}.", $"{login}", 
							MessageBoxButtons.OK, MessageBoxIcon.Asterisk);

					this.Close();
				}
				else
					MessageBox.Show("Неправильный логин или пароль.", "Error", 
						MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
			}
			else
				MessageBox.Show("Пароли не совпадает.", "Error", 
					MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
		}

		static bool IsUpper_string(string login_upper)
		{
			foreach (char bukva in login_upper.Where(char.IsUpper))
				return true;

			return false;
		}

		/*private Boolean IsUserExist()
		{
			command_per = "SELECT * FROM `User` WHERE `Login` = @uL";

			command = new MySqlCommand("SELECT * FROM `User` WHERE `Login` = @uL", db.getConnection());
			command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Login_Field.Text;

			adapter.SelectCommand = command;
			adapter.Fill(dataTable);

			Console.WriteLine(dataTable);

			if (dataTable.Rows.Count > 0)
			{
				MessageBox.Show("Этот логин занят");
				return true;
			}
			else
				return false;
		}

		private void Name_Field_Leave(object sender, EventArgs e)
		{
			if (Name_Field.Text == "")
			{
				Name_Field.Text = "Ваше имя";
				Name_Field.ForeColor = Color.Gray;
			}
		}
		private void Last_Name_Field_Leave(object sender, EventArgs e)
		{
			if (Last_Name_Field.Text == "")
			{
				Last_Name_Field.Text = "Ваша фамилию";
				Last_Name_Field.ForeColor = Color.Gray;
			}
		}
		private void Login_Field_Leave(object sender, EventArgs e)
		{
			if (Login_Field.Text == "")
			{
				Login_Field.Text = "Ваш логин";
				Login_Field.ForeColor = Color.Gray;
			}
		}
		private void Name_Field_Enter(object sender, EventArgs e)
		{
			if (Name_Field.Text != "")
			{
				Name_Field.Text = "";
				Name_Field.ForeColor = Color.Gray;
			}
		}
		private void Last_Name_Field_Enter(object sender, EventArgs e)
		{
			if (Last_Name_Field.Text != "")
			{
				Last_Name_Field.Text = "";
				Last_Name_Field.ForeColor = Color.Gray;
			}
		}
		private void Login_Field_Enter(object sender, EventArgs e)
		{
			if (Login_Field.Text != "")
			{
				Login_Field.Text = "";
				Login_Field.ForeColor = Color.Gray;
			}
		}
		private void label_registration_btn_Click(object sender, EventArgs e)
		{
			label_Nameblock.Text = "Регистрация";
			label_Name.Visible = true;
			Name_Field.Visible = true;
			Last_Name_Field.Visible = true;
			label_LastName.Visible = true; *

			label_Login.Visible = true;
			label_Login.Location = new Point(26, 137);
			Login_Field.Visible = true;
			Login_Field.Location = new Point(28, 163);
			Login_Field.Size = new Size(209, 31);

			label_Pass.Visible = true;
			label_Pass.Location = new Point(258, 19);
			Pass_Field.Location = new Point(261, 46);
			Pass_Field.Size = new Size(209, 31);

			label_Pass_repeat.Visible = true;
			Pass_repeat_Field.Visible = true;
			checkBox_Conset.Visible = true;
			checkedListBox.Visible = true;

			Registration_btn.Visible = true;
			Registration_btn.Location = new Point(148, 214);
			LogIn_btn.Visible = false;
			label_registration.Visible = false;
			label_Login_btn.Visible = true;

			Login_Field.Text = "Ваш логин";
			Pass_Field.Text = "";
		}
		private void Registration_btn_Click(object sender, EventArgs e)
		{
			string name = Name_Field.Text;
			string lastname = Last_Name_Field.Text;
			string login = Login_Field.Text;
			string pass1 = Pass_Field.Text;
			string pass2 = Pass_repeat_Field.Text;
			string license = checkedListBox.Text;

			if (Name_Field.Text == "Ваше имя")
			{
				MessageBox.Show("Введите имя");
				return;
			}
			if (Last_Name_Field.Text == "Ваша фамилию")
			{
				MessageBox.Show("Введите фамилию");
				return;
			}
			if (Login_Field.Text == "Ваш логин")
			{
				MessageBox.Show("Введите логин");
				return;
			}
			if (panel1.Text != "")
			{
				MessageBox.Show("Введите ");
				MessageBox.Show("Введите пароль");
				return;
			}

			if (checkedListBox.CheckOnClick)
			{
				MessageBox.Show("Невыбрана поле", "Error");
				return;
			}

			if (pass1 == "" || pass2 == "")
			{
				MessageBox.Show("Введите пароль.", "Error");
				return;
			}
			if (pass1 != pass2)
			{
				MessageBox.Show("Пароль не совпадает.", "Error");
				return;
			}

			if (IsUserExist())
				return;

			command = new MySqlCommand("INSERT INTO `User` (`Name`, `Last_name`, `Login`, `Password`, `License`) VALUES (@Name, @LastName, @Login, @pass, @license)", db.getConnection());

			command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = name;
			command.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = lastname;
			command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = login;
			command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass1;
			command.Parameters.Add("@license", MySqlDbType.VarChar).Value = license;

			db.OpenConnection();

			if (command.ExecuteNonQuery() == 1)
				MessageBox.Show("Аккаунт был создан.");
			else
				MessageBox.Show("Аккаунт не был создан.");

				db.CloseConnection();
			}
			else
				MessageBox.Show("Error", "Пароль не совпадает.");
		}
			else
				MessageBox.Show("Error", "Пароль не совпадает.");
		}
			else
				MessageBox.Show("Error", "Пароль не совпадает.");
		}*/
	}
}

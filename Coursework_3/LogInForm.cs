using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Coursework_3
{
	public partial class LogIn_Form : Form
	{
		public LogIn_Form()
		{
			InitializeComponent();
			Login_Start();
		}

		static BD_Connection db = new BD_Connection();
		DataTable dataTable = new DataTable();
		MySqlDataAdapter adapter = new MySqlDataAdapter();
		//MySqlCommand command = new MySqlCommand(command_per, db.getConnection());
		MySqlCommand command = new MySqlCommand();

		//static private string command_per;

		/* //все textbox в 1
		 * private string name_tb;
		private void Click_tb(object sender, EventArgs e)
		{
			name_tb = (sender as Button).Name;
		}
		*/

		private void LogIn_btn_Click(object sender, EventArgs e)
		{
			string login = Login_Field.Text;
			string pass1 = Pass_Field.Text;
			
			if (login != " " && pass1 != " ")
			{
				//command_per = "SELECT * FROM `User` WHERE `Login` = @uL AND `Password` = @uP";
				command = new MySqlCommand("SELECT * FROM `User` WHERE `Login` = @uL AND `Password` = @uP", db.getConnection());
				command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = login;
				command.Parameters.Add("@up", MySqlDbType.VarChar).Value = pass1;

				adapter.SelectCommand = command;
				adapter.Fill(dataTable);

				if (dataTable.Rows.Count > 0)
					MessageBox.Show("Yes");
				else
					MessageBox.Show("Неправильный логин или пароль.", "Error");
			}
			else
				MessageBox.Show("Пароли несовпадает.", "Error");
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
			label_LastName.Visible = true;

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

			Registration_btn.Visible = true;
			Registration_btn.Location = new Point(148, 214);
			LogIn_btn.Visible = false;
			label_registration.Visible = false;
			label_Login_btn.Visible = true;

			Login_Field.Text = "Ваш логин";
			Pass_Field.Text = "";
		}
		private void label_Login_btn_Click(object sender, EventArgs e)
		{
			Login_Start();
		}

		private void Login_Start() 
		{
			label_Nameblock.Text = "Вход";
			label_Name.Visible = false;
			Name_Field.Visible = false;
			label_LastName.Visible = false;
			Last_Name_Field.Visible = false;
			label_Pass_repeat.Visible = false;
			Pass_repeat_Field.Visible = false;
			checkBox_Conset.Visible = false;

			Registration_btn.Visible = false;
			LogIn_btn.Visible = true;
			LogIn_btn.Location = new Point(148, 214);
			label_Login_btn.Visible = false;
			label_registration.Visible = true;

			label_Login.Location = new Point(117, 20);
			Login_Field.Location = new Point(119, 56);
			Login_Field.Size = new Size(254, 31);
			label_Pass.Location = new Point(117, 100);
			Pass_Field.Location = new Point(119, 133);
			Pass_Field.Size = new Size(254, 31);

			Name_Field.Text = "Ваше имя";
			Last_Name_Field.Text = "Ваша фамилию";
			Login_Field.Text = "Ваш логин";

			Name_Field.ForeColor = Color.Gray;
			Last_Name_Field.ForeColor = Color.Gray;
			Login_Field.ForeColor = Color.Gray;
		}

		private void Registration_btn_Click(object sender, EventArgs e)
		{
			string name = Name_Field.Text;
			string lastname = Last_Name_Field.Text;
			string login = Login_Field.Text;
			string pass1 = Pass_Field.Text;
			string pass2 = Pass_repeat_Field.Text;

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
			if (checkBox_Conset.Checked == false)
			{
				MessageBox.Show("Необходимо согласие на обработкой личных данных.", "Error");
				return;
			}
			if (IsUserExist())
				return;

			if (pass1 != "" && pass2 != "")
			{
				command = new MySqlCommand("INSERT INTO `User` (`Name`, `Last_name`, `Login`, `Password`) VALUES (@Name, @LastName, @Login, @pass)", db.getConnection());

				command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = name;
				command.Parameters.Add("@LastName", MySqlDbType.VarChar).Value = lastname;
				command.Parameters.Add("@Login", MySqlDbType.VarChar).Value = login;
				command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass1;

				db.OpenConnection();

				if (command.ExecuteNonQuery() == 1)
					MessageBox.Show("Аккаунт был создвн.");
				else
					MessageBox.Show("Аккаунт не был создан.");

				db.CloseConnection();
			}
			else
				MessageBox.Show("Error", "Пароль не совпадает.");
		}

		private Boolean IsUserExist()
		{
			/*command_per = "SELECT * FROM `User` WHERE `Login` = @uL";*/
			command = new MySqlCommand("SELECT * FROM `User` WHERE `Login` = @uL", db.getConnection());

			command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = Login_Field.Text;

			adapter.SelectCommand = command;
			adapter.Fill(dataTable);

			if (dataTable.Rows.Count > 0)
			{
				MessageBox.Show("Этот логин занят");
				return true;
			}
			else
				return false;
		}
	}
}

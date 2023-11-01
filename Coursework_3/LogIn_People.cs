using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_3
{
	public partial class LogIn_People : Form
	{
		public LogIn_People()
		{
			InitializeComponent();
		}

		static BD_Connection db = new BD_Connection();
		DataTable dataTable = new DataTable();
		MySqlDataAdapter adapter = new MySqlDataAdapter();
		//MySqlCommand command = new MySqlCommand(command_per, db.getConnection());
		MySqlCommand command = new MySqlCommand();

		private void Registration_btn_Click(object sender, EventArgs e)
		{
			if (Educator_CheckBox.Checked)
			{
				Console.WriteLine("Educator_CheckBox");
				LogIn_Educator();
			}
			else if (Student_CheckBox.Checked)
			{
				Console.WriteLine("Student_CheckBox");
				LogIn_Student();
			}
			else
			{
				MessageBox.Show("Выберете кого хотите добавить", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}

		private void LogIn_Educator()
		{
			string name = Name_Field.Text;
			string lastname = LastName_Field.Text;
			string productName = Patronymic_Field.Text;
			string position = Position_Field.Text;
			string login = Login_Field.Text;
			string pass = Password_Field.Text;
			string repeat_pass = Repeat_Password_Field.Text;
			string money_field = Money_Field.Text;
			string cabinet = Cabinet_FIeld.Text;
			string namtional = Nationality_Field.Text;
			string paassport_series = Passport_Series.Text;
			string passport_number = Passport_Number.Text;
			string passpot_img = Img_Field.Text;
			string email = Email_FIeld.Text;

			if (name == "")
			{
				MessageBox.Show("Введите имя.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (lastname  == "")
			{
				MessageBox.Show("Введите фамилию.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (login == "")
			{
				MessageBox.Show("Введите логин.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (email == "")
			{
				MessageBox.Show("Введите почту.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (pass == "" || repeat_pass == "" || pass != repeat_pass)
			{
				MessageBox.Show("Пароль не совпадает", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (namtional == "" || paassport_series == "" || passport_number == "" || passpot_img == "")
			{
				MessageBox.Show("Заполните поля паспорта.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (IsUserExist())
				return;

			command = new MySqlCommand("", db.getConnection());

			command.Parameters.Add("", MySqlDbType.VarChar).Value = name;
			command.Parameters.Add("", MySqlDbType.VarChar).Value = lastname;
			command.Parameters.Add("", MySqlDbType.VarChar).Value = productName;
			command.Parameters.Add("", MySqlDbType.VarChar).Value = position;
			command.Parameters.Add("", MySqlDbType.VarChar).Value = login;
			command.Parameters.Add("", MySqlDbType.VarChar).Value = pass;
			command.Parameters.Add("", MySqlDbType.VarChar).Value = money_field;
			command.Parameters.Add("", MySqlDbType.VarChar).Value = cabinet;
			command.Parameters.Add("", MySqlDbType.VarChar).Value = namtional;
			command.Parameters.Add("", MySqlDbType.VarChar).Value = paassport_series;
			command.Parameters.Add("", MySqlDbType.VarChar).Value = passport_number;
			command.Parameters.Add("", MySqlDbType.VarChar).Value = passpot_img;
			command.Parameters.Add("", MySqlDbType.VarChar).Value = email;

			db.OpenConnection();

			if (command.ExecuteNonQuery() == 1)
				MessageBox.Show("Аккаунт был создан.");
			else
				MessageBox.Show("Аккаунт не был создан.");

			db.CloseConnection();

		}
		private void LogIn_Student()
		{
			string name = Name_Field.Text;
			string lastname = LastName_Field.Text;
			string productName = Patronymic_Field.Text;
			string login = Login_Field.Text;
			string pass = Password_Field.Text;
			string repeat_pass = Repeat_Password_Field.Text;
			string group = Group_Field.Text;
			string cours = Course_FIeld.Text;

			if (name == "")
			{
				MessageBox.Show("Введите имя.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (lastname == "")
			{
				MessageBox.Show("Введите фамилию.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (login == "")
			{
				MessageBox.Show("Введите логин.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (pass == "" || repeat_pass == "" || pass != repeat_pass)
			{
				MessageBox.Show("Пароль не совпадает", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (IsUserExist())
				return;

			command = new MySqlCommand("", db.getConnection());

			command.Parameters.Add("", MySqlDbType.VarChar).Value = name;
			command.Parameters.Add("", MySqlDbType.VarChar).Value = lastname;
			command.Parameters.Add("", MySqlDbType.VarChar).Value = productName;
			command.Parameters.Add("", MySqlDbType.VarChar).Value = login;
			command.Parameters.Add("", MySqlDbType.VarChar).Value = pass;
			command.Parameters.Add("", MySqlDbType.VarChar).Value = group;
			command.Parameters.Add("", MySqlDbType.VarChar).Value = cours;

			db.OpenConnection();

			if (command.ExecuteNonQuery() == 1)
				MessageBox.Show("Аккаунт был создан.");
			else
				MessageBox.Show("Аккаунт не был создан.");

			db.CloseConnection();
		}

		private Boolean IsUserExist()
		{
			/*command_per = "SELECT * FROM `User` WHERE `Login` = @uL";*/

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

		private void Student_CheckBox_MouseClick(object sender, MouseEventArgs e)
		{
			Educator_CheckBox.Checked = false;
		}

		private void Educator_CheckBox_MouseClick(object sender, MouseEventArgs e)
		{
			Student_CheckBox.Checked = false;
		}
	}
}

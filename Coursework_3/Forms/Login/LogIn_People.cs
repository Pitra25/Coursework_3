using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Data.SqlClient;
using Coursework_3.Classes;
using Coursework_3.Properties;

namespace Coursework_3
{
	public partial class LogIn_People : Form
	{
		public LogIn_People()
        {
			InitializeComponent();
        }

		static Mail mail = new Mail();
        static JournalRecordsHistory history = new JournalRecordsHistory();
        readonly static BD_Connection db = new BD_Connection();
		static DataTable dataTable;
		static SqlDataAdapter adapter;
		//MySqlCommand command = new MySqlCommand(command_per, db.getConnection());
		static SqlCommand command;
		static DataSet dataSet = new DataSet();

		private string code = "";

		private void RegistrationBtn_Click(object sender, EventArgs e)
		{
            if (EducatorCheckBox.Checked)
				LogInEmployee();
			else if (StudentCheckBox.Checked)
				LogInUsers();
			else
				MessageBox.Show("Выберете кого хотите добавить", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void LogInEmployee()
		{
			string name = Name_Field.Text,
				lastNamed = LastName_Field.Text,
				productName = Patronymic_Field.Text,
				position = Position_Field.Text,
				email = Email_Field.Text,
				login = Login_Field.Text,
				pass = Password_Field.Text,
				repeat_pass = Repeat_Password_Field.Text,
				Nationality = Nationality_Field.Text,
				Number = Number_Field.Text,
				Series = Series_Field.Text,
				FormatImage = Convert.ToString(pictureBox.Image);

			//var passport_img = pictureBox1.Image;

			/*
			 * Проверка на заполненность полей.
			 */
			if (name == "")
			{
				MessageBox.Show("Введите имя.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (lastNamed == "")
			{
				MessageBox.Show("Введите фамилию.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (login == "")
			{
				MessageBox.Show("Введите логин.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (Number == "" | Series == "" )
			{
				MessageBox.Show("Поля паспорта пусты.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (pass == "" | repeat_pass == "" | pass != repeat_pass)
			{
				MessageBox.Show("Пароль не совпадает", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

            if (IsUserExist("Employee", login))
				return;

            try
            {
				byte[] photo_array;
				using (MemoryStream memory = new MemoryStream())
				{
					pictureBox.Image.Save(memory, ImageFormat.Jpeg);
					photo_array = new byte[memory.Length];
					memory.Position = 0;
					memory.Read(photo_array, 0, photo_array.Length);
				}

				command = new SqlCommand("" +
					"INSERT INTO Employee (Name, Surname, Patronymic, Position, Nationality, Passport_number, Passport_series, Email, Image, Login, Password, license) " +
						"VALUES (NULL, @name, @lastNamed, @productName, @position, @nat, @number, @Series, @email, @img, @login, @pass, @license);",
					db.getConnection());
								
				command.Parameters.Add("@name",		   SqlDbType.VarChar).Value = name;
				command.Parameters.Add("@lastNamed",   SqlDbType.VarChar).Value = lastNamed;
				command.Parameters.Add("@productName", SqlDbType.VarChar).Value = productName;
				command.Parameters.Add("@position",	   SqlDbType.VarChar).Value = position;
				command.Parameters.Add("@nat",		   SqlDbType.VarChar).Value = Nationality;
				command.Parameters.Add("@number",      SqlDbType.VarChar).Value = Number;
				command.Parameters.Add("@Series",      SqlDbType.VarChar).Value = Series;
				command.Parameters.Add("@email",       SqlDbType.VarChar).Value = email;
				command.Parameters.Add("@login",       SqlDbType.VarChar).Value = login;
				command.Parameters.Add("@pass",        SqlDbType.VarChar).Value = pass;
				command.Parameters.Add("@img",		   SqlDbType.Image).Value	= photo_array;
				command.Parameters.Add("@license",     SqlDbType.VarChar).Value = "Сотрудник";

				code = "";
				code = GenerateSim();
				mail.SendMail(email, "Регистрация", code);
                history.LogWriter($"{DateTime.UtcNow.AddHours(3)} | РЕГИСТРАЦИЯ СОТРУДНИКА - {name}| СГЕНЕРИРОВАННЫЙ КОД - {code} | УДАЧНО \n");

                db.OpenConnection(); 
				if (command.ExecuteNonQuery() == 2)
					MessageBox.Show("Аккаунт был создан.");
				else
					MessageBox.Show("Не удалось создать аккаунт.");
				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
                history.LogWriter($"{DateTime.UtcNow.AddHours(3)} | ПОПЫТКА РЕГИСТРАЦИИ СОТРУДНИКА - {name} | {ex.Message} | НЕУДАЧА \n");
            }
			finally { db.CloseConnection(); }
		}

		private void LogInUsers()
		{
			string name = Name_Field.Text,
				lastNamed = LastName_Field.Text,
				Patronymic = Patronymic_Field.Text,
				Login = Login_Field.Text,
				pass = Password_Field.Text,
				passR = Repeat_Password_Field.Text,
				email = Email_Field.Text;

			/*
			 * Проверка на заполненность полей.
			 */
			if (name == "")
			{
				MessageBox.Show("Введите имя.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (lastNamed == "")
			{
				MessageBox.Show("Введите фамилию.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (pass != passR)
			{
				MessageBox.Show("Пароли не совпадают", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}
			if (IsUserExist("User", Login))
				return;
			try
			{
				byte[] photo_array;
				using (MemoryStream memory = new MemoryStream())
				{
					pictureBox.Image.Save(memory, ImageFormat.Jpeg);
					photo_array = new byte[memory.Length];
					memory.Position = 0;
					memory.Read(photo_array, 0, photo_array.Length);
				}

				command = new SqlCommand("" +
					"INSERT INTO User (Login, Password, Name, Last_name, Patronymic, License, Image) " +
						"VALUES (@login, @pass, @name, @lastNamed, @Patronymic, @user, @image);",
					db.getConnection());

				command.Parameters.Add("@login", SqlDbType.NVarChar).Value = Login;
				command.Parameters.Add("@pass", SqlDbType.NVarChar).Value = pass;
				command.Parameters.Add("@name", SqlDbType.NVarChar).Value = name;
				command.Parameters.Add("@lastNamed", SqlDbType.NVarChar).Value = lastNamed;
				command.Parameters.Add("@Patronymic", SqlDbType.NVarChar).Value = Patronymic;
				command.Parameters.Add("@user", SqlDbType.NVarChar).Value = "Клиент";
				command.Parameters.Add("@image", SqlDbType.Image).Value = photo_array;

				code = "";
				code = GenerateSim();
				mail.SendMail(email, "Регистрация", code);
				history.LogWriter($"{DateTime.UtcNow.AddHours(3)} | РЕГИСТРАЦИЯ КЛИЕНТА - {name}| СГЕНЕРИРОВАННЫЙ КОД - {code} | УДАЧНО \n");

				db.OpenConnection();
				if (command.ExecuteNonQuery() == 1)
					MessageBox.Show("Аккаунт был создан.");
				else
					MessageBox.Show("Не удалось создать аккаунт.");

				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
				history.LogWriter($"{DateTime.UtcNow.AddHours(3)} | ПОПЫТКА РЕГИСТРАЦИИ ПОЛЬЗОВАТЕЛЯ - {name} | {ex.Message} | НЕУДАЧА \n");
			}
			finally { db.CloseConnection(); }
		}

		/*
		 * Проверка есть ли в бд пользователь с таким же ником // возмоно улучшить проверяя в основном запросе
		 */
		private Boolean IsUserExist(string user, string nameF)
		{
			try
			{
				db.OpenConnection();
				if (user == "User")
				{
					command = new SqlCommand("SELECT * FROM User WHERE Name = @name",
						db.getConnection());
					command.Parameters.Add("@name", SqlDbType.NVarChar).Value = nameF;
				}
				else if (user == "Employee")
				{
					command = new SqlCommand("SELECT * FROM Employee WHERE Name = @name",
							db.getConnection());
					command.Parameters.Add("@name", SqlDbType.NVarChar).Value = nameF;
				}

				adapter.SelectCommand = command;
				adapter.Fill(dataTable);
				db.CloseConnection();

				Console.WriteLine(dataTable);
				if (command.ExecuteNonQuery() > 0)
				{
					MessageBox.Show("Этот логин занят");
					return true;
				}
				else
					return false;
			}
			catch(Exception ex)
			{
				MessageBox.Show($"Этот логин занят \n {ex.Message}");
				return false;
			}
		}

		private void StudentCheckBox_MouseClick(object sender, MouseEventArgs e) => EducatorCheckBox.Checked = false;
		private void EducatorCheckBox_MouseClick(object sender, MouseEventArgs e) => StudentCheckBox.Checked = false;

		private void AttachImgBtn_Click(object sender, EventArgs e)
		{
			LoadIImg load_Img = new LoadIImg() { key = 1 };
			load_Img.Show();
			this.Close();
		}

		private void DeleteImgBtn_Click(object sender, EventArgs e) => pictureBox.Image = Image.FromFile("..\\..\\Resources\\Image_none.png");
        private void pictureBoxPassword_Click(object sender, EventArgs e)
		{
			try{
				if (Password_Field.UseSystemPasswordChar == false)
				{
					pictureBoxPassword.Image = Image.FromFile("..\\..\\Resources\\free_icon_hide.png");
					Password_Field.UseSystemPasswordChar = true;
					Repeat_Password_Field.UseSystemPasswordChar = true;
				}
				else
				{
					pictureBoxPassword.Image = Image.FromFile("..\\..\\Resources\\free_icon_eye.png");
					Password_Field.UseSystemPasswordChar = false;
					Repeat_Password_Field.UseSystemPasswordChar = false;
				}
			}catch(Exception ex){
				history.LogWriter($"{DateTime.UtcNow.AddHours(3)} | НЕУДАЛСЬ ЗАГРУЗИТЬ ИЗОБРАЖЕНИЕ НА ФОРМЕ - {Form.ActiveForm} | ОШИБКА - {ex.Message} ;\n");
			}
		}

		private string GenerateSim()
		{
			int symbol;
			string sim = "";
            var rand = new Random();
            while ( sim.Length <= 5){
				symbol = rand.Next(0, 10);
				sim += Convert.ToString(symbol);
			}
            return sim;
		}

		/*	private void ImgLoader()
	{
		try
		{
			byte[] photo_array;
			using (MemoryStream memory = new MemoryStream())
			{
				pictureBox.Image.Save(memory, ImageFormat.Jpeg);
				photo_array = new byte[memory.Length];
				memory.Position = 0;
				memory.Read(photo_array, 0, photo_array.Length);
			}
		}
		catch(Exception ex)
		{
			MessageBox.Show(ex.Message);
			history.LogWriter($"{DateTime.UtcNow.AddHours(3)} | FORM - {Form.ActiveForm} | ПОПЫТКА ЗАГРУЗИТЬ ИЗОБРАЖЕНИЕ - {ex.Message} | \n");
		}
	}*/
	}
}

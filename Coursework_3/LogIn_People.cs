using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System.Collections;
using System.Data.OleDb;

namespace Coursework_3
{
	public partial class LogIn_People : Form
	{
		public LogIn_People()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		readonly static BD_Connection db = new BD_Connection();
		DataTable dataTable;
		MySqlDataAdapter adapter;
		//MySqlCommand command = new MySqlCommand(command_per, db.getConnection());
		MySqlCommand command;
		DataSet dataSet = new DataSet();

		private void ImgLoader()
		{
			try
			{
				db.OpenConnection();

				command = new MySqlCommand("SELECT `imgid`, `imagepath` FROM `SaveImg` ORDER BY `imgid`", db.getConnection());

				command.ExecuteNonQuery();
				dataTable = new DataTable();

				adapter.Fill(dataSet, "imagepath");
				int c = dataSet.Tables["BLOBTest"].Rows.Count;

				if (c > 0)
				{
					//BLOB is read into Byte array, then used to construct MemoryStream,
					//then passed to PictureBox.

					Byte[] byteBLOBData = new Byte[0];
					byteBLOBData = (Byte[])(dataSet.Tables["SaveImg"].Rows[c - 1]["SaveImg"]);
					MemoryStream stmBLOBData = new MemoryStream(byteBLOBData);
					pictureBox.Image = Image.FromStream(stmBLOBData);
				}

				db.CloseConnection();
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}
		private void RegistrationBtn_Click(object sender, EventArgs e)
		{
			if (EducatorCheckBox.Checked)
				LogInEmployee();
			else if (StudentCheckBox.Checked)
				LogInUsers();
			else
				MessageBox.Show("Выберете кого хотите добавить", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
		}

		private void LogInEmployee()
		{
			string name = Name_Field.Text;
			string lastNamed = LastName_Field.Text;
			string productName = Patronymic_Field.Text;
			string position = Position_Field.Text;
			string email = Email_Field.Text;
			string login = Login_Field.Text;
			string pass = Password_Field.Text;
			string repeat_pass = Repeat_Password_Field.Text;
			string Nationality = Nationality_Field.Text;
			string Number = Number_Field.Text;
			string Series = Series_Field.Text;

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

			//string imagename = Path.GetFileName(pictureBox1.ProductName);
			//var imagepath = pictureBox1.Image;

			/*try
			{
				command = new MySqlCommand("INSERT INTO BLOBTest (BLOBData) VALUES (@BLOBData)", db.getConnection());

				//Save image from PictureBox into MemoryStream object.
				MemoryStream ms = new MemoryStream();
				pictureBox1.Image.Save(ms, ImageFormat.Jpeg);

				//Read from MemoryStream into Byte array.
				Byte[] bytBLOBData = new Byte[ms.Length];
				ms.Position = 0;
				ms.Read(bytBLOBData, 0, Convert.ToInt32(ms.Length));

				//Create parameter for insert statement that contains image.
				SqlParameter prm = new SqlParameter("@BLOBData", SqlDbType.VarBinary, bytBLOBData.Length, ParameterDirection.Input, false,
				0, 0, null, DataRowVersion.Current, bytBLOBData);
				command.Parameters.Add(prm);

				db.OpenConnection();
				command.ExecuteNonQuery();
				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}*/

			//Console.WriteLine("imagepath: ", imagepath);
			
			try
			{
				command = new MySqlCommand("" +
				"INSERT INTO `Employee` " +
					"(`id`, `Name`, `Surname`, `Patronymic`, `Position`, `Nationality`, `Passport_number`, `Passport_series`, `Email`, `Login`, `Password`, `Employee`) " +
					"VALUES (NULL, @name, @lastNamed, @productName, @position, @nat, @number, @Series, @email, @login, @pass, @employee);" +
				"INSERT INTO `SaveImg` (`id`, `imagename`, `iamgetype`, `imagepath`) " +
					"VALUES (NULL, @imgname, @imagetype, @BLOBData);",
				db.getConnection());
								
				command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
				command.Parameters.Add("@lastNamed", MySqlDbType.VarChar).Value = lastNamed;
				command.Parameters.Add("@productName", MySqlDbType.VarChar).Value = productName;
				command.Parameters.Add("@position", MySqlDbType.VarChar).Value = position;
				command.Parameters.Add("@nat", MySqlDbType.VarChar).Value = Nationality;
				command.Parameters.Add("@number", MySqlDbType.VarChar).Value = Number;
				command.Parameters.Add("@Series", MySqlDbType.VarChar).Value = Series;
				command.Parameters.Add("@email", MySqlDbType.VarChar).Value = email;
				command.Parameters.Add("@login", MySqlDbType.VarChar).Value = login;
				command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;
				command.Parameters.Add("@employee", MySqlDbType.VarChar).Value = "Сотрудник";

				command.Parameters.Add("@imgname", MySqlDbType.VarChar).Value = name + ". Сотрудник.";
				command.Parameters.Add("@imagetype", MySqlDbType.VarChar).Value = "Jpeg";

				MemoryStream memory = new MemoryStream();
				pictureBox.Image.Save(memory, ImageFormat.Jpeg);

				//Сохраните изображение из PictureBox в объект MemoryStream.
				Byte[] bytBLOBData = new Byte[memory.Length];
				memory.Position = 0;
				memory.Read(bytBLOBData, 0, Convert.ToInt32(memory.Length));

				//Создайте параметр для оператора вставки, содержащий изображение.
				MySqlParameter Parameter = new MySqlParameter("@BLOBData", MySqlDbType.LongBlob, bytBLOBData.Length, ParameterDirection.Input, false,
					0, 0, null, DataRowVersion.Current, bytBLOBData);
				
				command.Parameters.Add(Parameter);

				db.OpenConnection(); 

				if (command.ExecuteNonQuery() == 2)
					MessageBox.Show("Аккаунт был создан.");
				else
					MessageBox.Show("Аккаунт не был создан.");

				db.CloseConnection();
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}

		}

		private void LogInUsers()
		{
			string name = Name_Field.Text;
			string lastNamed = LastName_Field.Text;
			string Patronymic = Patronymic_Field.Text;
			string Login = Login_Field.Text;
			string pass = Password_Field.Text;
			string passR = Repeat_Password_Field.Text;
			
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
			if (IsUserExist("User", name))
				return;

			db.OpenConnection();
			command = new MySqlCommand("INSERT INTO `User` " +
				"(`id`, `Login`, `Password`, `License`, `Name`, `Last_name`, `Patronymic`) " +
					"VALUES (NULL, @login, @pass,@user ,@name, @lastNamed, @Patronymic);" +
				"INSERT INTO `SaveImg` (`id`, `imagename`, `iamgetype`, `imagepath`) " +
					"VALUES (NULL, @imgname, @imagetype, @BLOBData);",
				db.getConnection());

			command.Parameters.Add("@login", MySqlDbType.VarChar).Value = Login;
			command.Parameters.Add("@pass", MySqlDbType.VarChar).Value = pass;
			command.Parameters.Add("@name", MySqlDbType.VarChar).Value = name;
			command.Parameters.Add("@lastNamed", MySqlDbType.VarChar).Value = lastNamed;
			command.Parameters.Add("@Patronymic", MySqlDbType.VarChar).Value = Patronymic;
			command.Parameters.Add("@user", MySqlDbType.VarChar).Value = "Клиент";

			command.Parameters.Add("@imgname", MySqlDbType.VarChar).Value = name + ". Клиент.";
			command.Parameters.Add("@imagetype", MySqlDbType.VarChar).Value = "Jpeg";

			MemoryStream memory = new MemoryStream();
			pictureBox.Image.Save(memory, ImageFormat.Jpeg);

			//Сохраните изображение из PictureBox в объект MemoryStream.
			Byte[] bytBLOBData = new Byte[memory.Length];
			memory.Position = 0;
			memory.Read(bytBLOBData, 0, Convert.ToInt32(memory.Length));

			//Создайте параметр для оператора вставки, содержащий изображение.
			MySqlParameter Parameter = new MySqlParameter("@BLOBData", MySqlDbType.LongBlob, bytBLOBData.Length, ParameterDirection.Input, false,
				0, 0, null, DataRowVersion.Current, bytBLOBData);

			command.Parameters.Add(Parameter);

			if (command.ExecuteNonQuery() == 2)
				MessageBox.Show("Аккаунт был создан.");
			else
				MessageBox.Show("Аккаунт не был создан.");

			db.CloseConnection();
		}

		/*
		 * Проверка есть ли в бд пользователь с таким же ником
		 */
		private Boolean IsUserExist(string user, string nameF)
		{
			/*BD_Connection db = new BD_Connection();
			DataTable dataTable = new DataTable();
			MySqlDataAdapter adapter_loc = new MySqlDataAdapter();
			//MySqlCommand command = new MySqlCommand(command_per, db.getConnection());
			MySqlCommand command_loc;*/
			try
			{
				db.OpenConnection();
				if (user == "User")
				{
					command = new MySqlCommand("SELECT * FROM `User` WHERE `Login` = @log",
						db.getConnection());
					command.Parameters.Add("@log", MySqlDbType.VarChar).Value = nameF;
				}
				else if (user == "Employee")
				{
					
					command = new MySqlCommand("SELECT * FROM `Employee` WHERE `Name` = @name",
							db.getConnection());
					command.Parameters.Add("@name", MySqlDbType.VarChar).Value = nameF;
				}

				adapter.SelectCommand = command;
				adapter.Fill(dataTable);
				db.CloseConnection();

				Console.WriteLine(dataTable);
				if (dataTable.Rows.Count > 0)
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

		private void StudentCheckBox_MouseClick(object sender, MouseEventArgs e)
		{
			EducatorCheckBox.Checked = false;
		}
		private void EducatorCheckBox_MouseClick(object sender, MouseEventArgs e)
		{
			StudentCheckBox.Checked = false;
		}

		private void AttachImgBtn_Click(object sender, EventArgs e)
		{
			LoadIImg load_Img = new LoadIImg();
			load_Img.Show();
			this.Close();
		}
	}
}

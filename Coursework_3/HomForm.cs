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
using System.Timers;
using System.IO;
using System.Collections;


namespace Coursework_3
{
	public partial class HomForm : Form
	{
		public HomForm()
		{
			InitializeComponent();
			this.Size = new Size(969, 825);
			Function_Loading_Cart();
		}

		static BD_Connection db = new BD_Connection();
		DataTable dataTable = new DataTable();
		MySqlDataAdapter adapter;
		//MySqlCommand command = new MySqlCommand(command_per, db.getConnection());
		MySqlCommand command;
        DataSet dataSet = new DataSet();

		public static string id_card1;
		public static string id_card2;
		public static string id_card3;

		private void ImgLoader()
		{
			try
			{
				db.OpenConnection();

				command = new MySqlCommand("SELECT `imagename`,`iamgetype`,`imagepath` FROM `Books` ORDER BY id DESC LIMIT 3", db.getConnection());
				
				adapter = new MySqlDataAdapter(command);
				adapter.Fill(dataSet, "imagepath");
				int c = dataSet.Tables["imagepath"].Rows.Count;

				if (c > 0)
				{
					//BLOB считывается в массив байтов, затем используется для построения MemoryStream,
					//затем передается в PictureBox.

					Byte[] byteBLOBData = new Byte[0];
					var byteBLOBData1 = byteBLOBData = (Byte[])(dataSet.Tables["imagepath"].Rows[c - 1]["imagepath"]);
					var byteBLOBData2 = byteBLOBData = (Byte[])(dataSet.Tables["imagepath"].Rows[c - 2]["imagepath"]);
					var byteBLOBData3 = byteBLOBData = (Byte[])(dataSet.Tables["imagepath"].Rows[c - 3]["imagepath"]);
					
					MemoryStream stmBLOBData1 = new MemoryStream(byteBLOBData1);
					MemoryStream stmBLOBData2 = new MemoryStream(byteBLOBData2);
					MemoryStream stmBLOBData3 = new MemoryStream(byteBLOBData3);


					pictureBox1.Image = Image.FromStream(stmBLOBData1);
					pictureBox2.Image = Image.FromStream(stmBLOBData2);
					pictureBox3.Image = Image.FromStream(stmBLOBData3);
					/*
					//Отладка загрузки отображения картинок
					adapter.Fill(dataTable);
					dataGridView2.DataSource = dataTable;*/
				}

				db.CloseConnection();

			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message);
			}
		}

		/*
		 *	Выборка из таблицы БД 3 последних записей
		 *	и запись их в карточки.
		 */
		private void Function_Loading_Cart() {
			//dataGridView1.Rows.Clear();
			try{

				ImgLoader();

				db.OpenConnection();
				command = new MySqlCommand("SELECT `id`, `Name`,`Avtar` FROM `Books` ORDER BY id DESC LIMIT 3", db.getConnection());
		
				command.ExecuteNonQuery();
				dataTable = new DataTable();

				adapter = new MySqlDataAdapter(command);
				adapter.Fill(dataTable);
				db.CloseConnection();

				dataGridView1.DataSource = dataTable;

				id_card1 = dataGridView1[0, 2].Value.ToString();
				Label_name_book_1.Text = dataGridView1[1, 2].Value.ToString();
				Label_Author_1.Text = dataGridView1[2, 2].Value.ToString();
				label3.Text = dataGridView1[0, 2].Value.ToString();

				id_card2 = dataGridView1[0, 1].Value.ToString();
				Label_name_book_2.Text = dataGridView1[1, 1].Value.ToString();
				Label_Author_2.Text = dataGridView1[2, 1].Value.ToString();
				label4.Text = dataGridView1[0, 1].Value.ToString();
				
				id_card3 = dataGridView1[0, 0].Value.ToString();
				Label_name_book_3.Text = dataGridView1[1, 0].Value.ToString();
				Label_Author_3.Text = dataGridView1[2, 0].Value.ToString();
				label7.Text = dataGridView1[0, 0].Value.ToString();

				/*int index_bd = 1;

				if(index_bd <= 3) {
					while(index_bd >= 3) {
						reader.GetString(index_bd);
						Label_name_book_1.Text = reader.GetString(index_bd);
						Label_Author_1.Text = reader.GetString(index_bd);
						label4.Text = reader.GetString(index_bd);
						index_bd++;
					}
				}
				else{
					reader.Read();
					index_bd = 0;
					return;
				}*/

				/*reader = command.ExecuteReader();
	
				Label_name_book_1.Text = reader.GetString(1);
				Label_Author_1.Text = reader.GetString(2);
				label4.Text = reader.GetString(3);
					
				Label_name_book_2.Text = reader.GetString(1);
				Label_Author_2.Text = reader.GetString(2);
				label2.Text = reader.GetString(3);
					
				Label_name_book_3.Text = reader.GetString(1);
				Label_Author_3.Text = reader.GetString(2);
				label9.Text = reader.GetString(3);*/

			}
			catch(Exception ex) {
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void TFunction_Loading_Cart(object sender, EventArgs e)
		{
			Function_Loading_Cart();
		}

		private void HomForm_FormClosed(object sender, FormClosedEventArgs e)
		{
			System.Environment.Exit(0);
		}

		private void MoreBtn1Cart_Click(object sender, EventArgs e)
		{
			Books_Form books_Form = new Books_Form();
			books_Form.id_cards = short.Parse(id_card1);
			Console.WriteLine(id_card1);
			books_Form.Show();
		}
		private void MoreBtn2Cart_Click(object sender, EventArgs e)
		{
			Books_Form books_Form = new Books_Form();
			books_Form.id_cards = short.Parse(id_card2);
			Console.WriteLine(id_card2);
			books_Form.Show();
		}
		private void MoreBtn3Cart_Click(object sender, EventArgs e)
		{
			Books_Form books_Form = new Books_Form();
			books_Form.id_cards = short.Parse(id_card3);
			Console.WriteLine(id_card3);
			books_Form.Show();
		}

		private void ScheduleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Schedule schedule = new Schedule();
			schedule.Show();
			this.Hide();
		}
		private void CatalogToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Catalog catalog = new Catalog();
			catalog.Show();
			this.Hide();
		}
		private void NewBooksToolStripMenuItem_Click(object sender, EventArgs e)
		{
			NewBooks newBooks = new NewBooks();
			newBooks.Show();
			this.Hide();
		}
		private void User_ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			Users_Form users_Form = new Users_Form();
			users_Form.Show();
		}
		private void Login_ToolStrip_MenuItem_Click(object sender, EventArgs e)
		{
			LogIn_Form logInForm = new LogIn_Form();
			logInForm.ShowDialog();
		}
		private void NewUser_ToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			LogIn_People logIn_People = new LogIn_People();
			logIn_People.ShowDialog();
		}

		private void History_ToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}

		private void logToolStripMenuItem_Click(object sender, EventArgs e)
		{
			Logs logs = new Logs();
			logs.Show();
		}



		/*
		 * Проверка на наличие похожего логина
		 
		private Boolean IsUserExist() {
			db.OpenConnection();
			command = new MySqlCommand("SELECT * FROM `Users` WHERE `id_Login` = @uL", db.getConnection());
			command.Parameters.Add("@uL", MySqlDbType.VarChar).Value = command;

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
		}*/
	}
}

using System.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Coursework_3
{
	public partial class StartForm : Form
	{
		public StartForm()
		{
			InitializeComponent();
		}

		/*
		 *	Переписать !!!!
		 */
		private string GetConnectionString()
		{
			return "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Patrick\\Documents\\BDCoursework.mdf;" +
				"Integrated Security=True;Connect Timeout=30;Encrypt=False";

			/*return "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Patrick\\Documents\\Test.mdf;" +
				"Integrated Security=True;Connect Timeout=30;Encrypt=True";*/
		}

		private void OpenSqlConnection()
		{
			try{
				string connectionString = GetConnectionString();

				using (SqlConnection connection = new SqlConnection())
				{
					connection.ConnectionString = connectionString;

					if (connection.State == ConnectionState.Closed)
						connection.Open();

					Console.WriteLine("State: {0}", connection.State);
					Console.WriteLine("ConnectionString: {0}",
						connection.ConnectionString);

					connection.Close();

					HomForm hom = new HomForm();
					hom.Show();
					this.Hide();		
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Отсутствует подключение к БД." + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				Environment.Exit(0);
			}
		}
		private void Timer_Tick(object sender, EventArgs e)
		{
			Console.WriteLine("Stop timer");
			Timer.Stop();
			OpenSqlConnection();
		}


		//void StartForm_FormClosing(object sender, FormClosingEventArgs e)
		//{
		//	e.Cancel = Class1.fclose();
		//}
		//void StartForm_FormClosed(object sender, FormClosedEventArgs e)
		//{
		//	Application.Exit();
		//}
		//public static bool fclose()
		//{
		//	var result = MessageBox.Show("Вы действительно хотите закрыть программу?", "Подтверждение", MessageBoxButtons.OKCancel, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
		//	if (result == DialogResult.OK) return false;
		//	else return true;
		//}

		/*private bool ConnectionTest()
		{
			try{
				//MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;username=User;password=User;database=BDCoursework");
				MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;username=ADMIN_BD;password=123;database=BDCoursework");

				Console.WriteLine("Connection DB :{1}", Connection);

				if (Connection.State == ConnectionState.Closed)
					Connection.Open();
				Connection.Close();
				Connection.Open();
				Connection.Close();


				HomForm homForm = new HomForm();
				homForm.Show();
				this.Hide();
				return true;
			}
			catch{
				MessageBox.Show("Отсутствует подключение к БД.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				System.Environment.Exit(0);
				return false; 
			}
		}*/


	}
}

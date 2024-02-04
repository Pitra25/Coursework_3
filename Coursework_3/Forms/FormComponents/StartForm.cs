using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Coursework_3.Classes;
using System.Configuration;

namespace Coursework_3
{
	public partial class StartForm : Form
	{
		public StartForm()
		{
			InitializeComponent();
		}
		 //connection = new SqlConnection(ConfigurationManager.ConnectionStrings["StringBD"].ConnectionString)

		private static JournalRecordsHistory history = new JournalRecordsHistory();
		//private static string BDConnect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Prodgect\\CourseWork_3_courses\\Coursework_3\\Coursework_3\\bin\\Debug\\Databases\\BDCoursework.mdf;Integrated Security=True;Connect Timeout=30";
		private void OpenSqlConnection()
        {
			try {
				using (SqlConnection connection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnsectionString"].ConnectionString)) {
					//connection.ConnectionString = connectionString;

					if (connection.State == ConnectionState.Closed)
						connection.Open();

					history.LogWriter($"************** Загруженные сборки ************** \n" +
						$"{DateTime.UtcNow.AddHours(3)}\n" +
						$"\tСвойства подключения:  \n" +
						$"\t\tСтрока подключения: {connection.ConnectionString};\n" +
						$"\t\tБаза данных: {connection.Database};\n" +
						$"\t\tСервер: {connection.DataSource};\n" +
						$"\t\tВерсия сервера: {connection.ServerVersion};\n" +
						$"\t\tСостояние: {connection.State};\n" +
						$"\t\tWorkstationld: {connection.WorkstationId};\n" +
						$"-----------------------------------------------\n", "BD");
					connection.Close();
				}

				HomForm form = new HomForm();
				form.Show();
				this.Hide();		
			}
			catch (SqlException ex)
			{
				MessageBox.Show("Отсутствует подключение к БД.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				history.LogWriter($"{DateTime.UtcNow.AddHours(3)} | ПОПЫТКА ПОДКЛЮЧИТСЯ - {ex.Message} | " +
								   $" ConnectionString:  | НЕУДАЧНО. \n", "BD");
				Environment.Exit(0);
			}
		}

		private void Timer_Tick(object sender, EventArgs e)
		{
			Timer.Stop();
			Console.WriteLine("Stop timer");
            OpenSqlConnection();
        }


		//private static SqlConnection connection = null;


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

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
using static System.Net.Mime.MediaTypeNames;

namespace Coursework_3
{
	public partial class StartForm : Form
	{
		public StartForm()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
		}

			/*
			 *	Переписать !!!!
			 */

		private bool ConnectionTest()
		{
			try{
				MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;username=User;password=User;database=BDCoursework");

				if (Connection.State == ConnectionState.Closed)
					Connection.Open();
				Connection.Close();
				return StartProtect(true);
			}
			catch{
				return StartProtect(false);
			}
		}

		private bool StartProtect(bool text)
		{
			if (text == true)
			{
				HomForm homForm = new HomForm();
				homForm.Show();
				this.Hide();
				timer.Stop();
			}
			else if (text == false)
			{
				timer.Stop();
				MessageBox.Show("Отсутствует подключение к БД.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
				System.Environment.Exit(0);
			} 
			return false;
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			Console.WriteLine("Stop timer");
			ConnectionTest();
		}
	}
}

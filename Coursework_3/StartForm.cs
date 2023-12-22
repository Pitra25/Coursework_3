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
	public partial class StartForm : Form
	{
		public StartForm()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
			ConnectionTest();
			
		}

		private void ConnectionTest()
		{
			try
			{
				MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;username=User;password=User;database=BDCoursework");

				if (Connection.State == ConnectionState.Closed)
					Connection.Open();

			}
			catch
			{
				MessageBox.Show("Отсутствует подключение к БД.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			HomForm homForm = new HomForm();
			homForm.Show();
			this.Hide();
			timer.Stop();	
		}
	}
}

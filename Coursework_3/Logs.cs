using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coursework_3
{
	public partial class Logs : Form
	{
		public Logs()
		{
			InitializeComponent();
		}

		readonly static BD_Connection db = new BD_Connection();
		DataTable dataTable;
		SqlDataAdapter adapter;
		//MySqlCommand command = new MySqlCommand(command_per, db.getConnection());
		SqlCommand command;

		private void Logs_Load(object sender, EventArgs e)
		{
			Load_User_DataGridView();
			Load_Book_DataGridView();
		}

		private void Load_User_DataGridView()
		{
			db.OpenConnection();
			command = new SqlCommand("SELECT * FROM `Logs_User`", db.getConnection());

			command.ExecuteNonQuery();
			dataTable = new DataTable();

			adapter = new SqlDataAdapter(command);
			adapter.Fill(dataTable);

			db.CloseConnection();

			//dataTable.Columns.Add(new DataColumn("Delate", typeof(DataGridViewButtonColumn)));
			dataGridViewUser.DataSource = dataTable;
			/*
				Установка ширины 0 столба в 25 единиц.
				И установка содержимого в центр ячейки.
			*/
			this.dataGridViewUser.Columns[0].Width = 25;
			this.dataGridViewUser.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			db.CloseConnection();
		}

		private void Load_Book_DataGridView()
		{
			db.OpenConnection();
			command = new SqlCommand("SELECT * FROM `Logs_Book`", db.getConnection());

			command.ExecuteNonQuery();
			dataTable = new DataTable();

			adapter = new SqlDataAdapter(command);
			adapter.Fill(dataTable);

			db.CloseConnection();

			//dataTable.Columns.Add(new DataColumn("Delate", typeof(DataGridViewButtonColumn)));
			dataGridViewBooks.DataSource = dataTable;
			/*
				Установка ширины 0 столба в 25 единиц.
				И установка содержимого в центр ячейки.
			*/
			this.dataGridViewBooks.Columns[0].Width = 25;
			this.dataGridViewBooks.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			db.CloseConnection();
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			dataGridViewBooks = null;
			dataGridViewUser = null;
			Load_User_DataGridView();
			Load_Book_DataGridView();
		}
	}
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Graph;
using Microsoft.Graph.Models;
using MySql.Data.MySqlClient;

namespace Coursework_3
{
	public partial class Users_Form : Form
	{

		public Users_Form()
		{
			InitializeComponent();
			Function_Loading_Database_Employee();
			Function_Loading_Database_User();
		}

		static BD_Connection db = new BD_Connection();
		DataTable dataTable;
		MySqlDataAdapter adapter;
		MySqlCommand command;

		private void Function_Loading_Database_Employee()
		{
			try
			{
				//dataGridViewEmployee.Rows.Clear();
				db.OpenConnection();
					command = new MySqlCommand("Select * From `Employee`", db.getConnection());
					command.ExecuteNonQuery();
					dataTable = new DataTable();
		
					adapter = new MySqlDataAdapter(command);
					adapter.Fill(dataTable);

				db.CloseConnection();
				
				//dataTable.Columns.Add(new DataColumn("Delate", typeof(DataGridViewButtonColumn)));
				dataGridViewEmployee.DataSource = dataTable;
				/*
					Установка ширины 0 столба в 30 единиц.
					И установка содержимого в центр ячейки.
				*/
				this.dataGridViewEmployee.Columns[0].Width = 30;
				this.dataGridViewEmployee.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

				if (dataGridViewEmployee.Columns.Count <= 4)
				{
					dataGridViewEmployee.Columns.Add(new DataGridViewButtonColumn()
					{
						Text = "Say Hi",
						UseColumnTextForButtonValue = true,
						AutoSizeMode = DataGridViewAutoSizeColumnMode.None
					});
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Function_Loading_Database_User()
		{
			try
			{
				//dataGridViewUsers.Rows.Clear();
				db.OpenConnection();
				command = new MySqlCommand("Select * From `User`", db.getConnection());
				command.ExecuteNonQuery();
				dataTable = new DataTable();

				adapter = new MySqlDataAdapter(command);
				adapter.Fill(dataTable);

				db.CloseConnection();

				//dataTable.Columns.Add(new DataColumn("Delate", typeof(DataGridViewButtonColumn)));
				dataGridViewUsers.DataSource = dataTable;
				/*
					Установка ширины 0 столба в 25 единиц.
					И установка содержимого в центр ячейки.
				*/
				this.dataGridViewUsers.Columns[0].Width = 25;
				this.dataGridViewUsers.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

				if (dataGridViewUsers.Columns.Count <= 4)
				{
					dataGridViewUsers.Columns.Add(new DataGridViewButtonColumn()
					{
						Text = "Say Hi",
						UseColumnTextForButtonValue = true,
						AutoSizeMode = DataGridViewAutoSizeColumnMode.None
					});
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//Добавляете метод, который будет заполнять элементы управления
		// данными из reader
		public void ClickHandler(int RowIndex)
		{
			int id = Convert.ToInt32(dataGridViewEmployee[1, RowIndex].Value.ToString());
			
			Console.WriteLine($"ClickHandler {id}");

			db.OpenConnection();
				command.Parameters.Add("@id", MySqlDbType.Int32).Value = id;
				command = new MySqlCommand("DELETE FROM `Users` WHERE `id` = @id", db.getConnection());
			db.CloseConnection();

			Function_Loading_Database_Employee();
			Function_Loading_Database_User();
		}
		private void Update_btn_Click(object sender, EventArgs e)
		{
			Function_Loading_Database_Employee();
			Function_Loading_Database_User();
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 0)
				ClickHandler(e.RowIndex);
		}

		private void Locate_btnEmployee_Click(object sender, EventArgs e)
		{
			if (textBoxLoginEmployee.Text != "")
			{
				db.OpenConnection();
				//Console.WriteLine("TextBoxLogin NULL");
				command = new MySqlCommand("SELECT * FROM `Employee` WHERE `Login` = @LoginUser", db.getConnection());
				command.Parameters.Add("@LoginUser", MySqlDbType.VarChar).Value = textBoxLoginEmployee.Text;
				command.ExecuteNonQuery();
				db.CloseConnection();

				dataTable = new DataTable();
				adapter = new MySqlDataAdapter(command);
				adapter.Fill(dataTable);

				/*dataGridViewEmployee.DataSource = dataTable;
				
				this.dataGridViewEmployee.Columns[0].Width = 30;
				this.dataGridViewEmployee.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

				if (dataGridViewEmployee.Columns.Count <= 4)
				{
					dataGridViewEmployee.Columns.Add(new DataGridViewButtonColumn()
					{
						Text = "Say Hi",
						UseColumnTextForButtonValue = true,
						AutoSizeMode = DataGridViewAutoSizeColumnMode.None
					});
				}*/
			}
			else if(textBoxNameEmployee.Text != "")
			{

				db.OpenConnection();
				command = new MySqlCommand("SELECT * FROM `Employee` WHERE `Name` = @NameUser", db.getConnection());
				command.Parameters.Add("@NameUser", MySqlDbType.VarChar).Value = textBoxLoginEmployee.Text;
				command.ExecuteNonQuery();
				db.CloseConnection();

				dataTable = new DataTable();
				adapter = new MySqlDataAdapter(command);
				adapter.Fill(dataTable);

				/*dataGridViewEmployee.DataSource = dataTable;
				
				this.dataGridViewEmployee.Columns[0].Width = 30;
				this.dataGridViewEmployee.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

				if (dataGridViewEmployee.Columns.Count <= 4)
				{
					dataGridViewEmployee.Columns.Add(new DataGridViewButtonColumn()
					{
						Text = "Say Hi",
						UseColumnTextForButtonValue = true,
						AutoSizeMode = DataGridViewAutoSizeColumnMode.None
					});
				}*/
			}
			else
				Console.WriteLine("Заполните хотя бы 1 поле для поиска.");

			//dataGridViewEmployee.Rows.Clear();
			dataGridViewEmployee.DataSource = dataTable;

			this.dataGridViewEmployee.Columns[0].Width = 30;
			this.dataGridViewEmployee.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			if (dataGridViewEmployee.Columns.Count <= 4)
			{
				dataGridViewEmployee.Columns.Add(new DataGridViewButtonColumn()
				{
					Text = "Delete",
					UseColumnTextForButtonValue = true,
					AutoSizeMode = DataGridViewAutoSizeColumnMode.None
				});
			}
		}

		private void Locate_brn_User_Click(object sender, EventArgs e)
		{
			if (textBoxLoginEmployee.Text != "")
			{
				//Console.WriteLine("TextBoxLogin NULL");
				db.OpenConnection();
				command = new MySqlCommand("SELECT * FROM `User` WHERE `Login` = @LoginUser", db.getConnection());
				command.Parameters.Add("@LoginUser", MySqlDbType.VarChar).Value = textBoxLoginEmployee.Text;
				command.ExecuteNonQuery();
				db.CloseConnection();

				dataTable = new DataTable();
				adapter = new MySqlDataAdapter(command);
				adapter.Fill(dataTable);

				/*dataGridViewEmployee.DataSource = dataTable;
				
				this.dataGridViewEmployee.Columns[0].Width = 30;
				this.dataGridViewEmployee.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

				if (dataGridViewEmployee.Columns.Count <= 4)
				{
					dataGridViewEmployee.Columns.Add(new DataGridViewButtonColumn()
					{
						Text = "Say Hi",
						UseColumnTextForButtonValue = true,
						AutoSizeMode = DataGridViewAutoSizeColumnMode.None
					});
				}*/
			}
			else if (textBoxNameEmployee.Text != "")
			{
				//Console.WriteLine("TextBoxName NULL");

				db.OpenConnection();
				command = new MySqlCommand("SELECT * FROM `User` WHERE `Login` = @NameUser", db.getConnection());
				command.Parameters.Add("@NameUser", MySqlDbType.VarChar).Value = textBoxLoginEmployee.Text;
				command.ExecuteNonQuery();
				db.CloseConnection();

				dataTable = new DataTable();
				adapter = new MySqlDataAdapter(command);
				adapter.Fill(dataTable);

				/*dataGridViewEmployee.DataSource = dataTable;
			
				this.dataGridViewEmployee.Columns[0].Width = 30;
				this.dataGridViewEmployee.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

				if (dataGridViewEmployee.Columns.Count <= 4)
				{
					dataGridViewEmployee.Columns.Add(new DataGridViewButtonColumn()
					{
						Text = "Say Hi",
						UseColumnTextForButtonValue = true,
						AutoSizeMode = DataGridViewAutoSizeColumnMode.None
					});
				}*/
			}
			else
				Console.WriteLine("Заполните хотя бы 1 поле для поиска.");

			dataGridViewUsers.Rows.Clear();
			dataGridViewEmployee.DataSource = dataTable;
			/*
				Установка ширины 0 столба в 30 единиц.
				И установка содержимого в центр ячейки.
			*/
			this.dataGridViewEmployee.Columns[0].Width = 30;
			this.dataGridViewEmployee.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			if (dataGridViewEmployee.Columns.Count <= 4)
			{
				dataGridViewEmployee.Columns.Add(new DataGridViewButtonColumn()
				{
					Text = "Delete",
					UseColumnTextForButtonValue = true,
					AutoSizeMode = DataGridViewAutoSizeColumnMode.None
				});
			}
		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{
			Function_Loading_Database_User();
			Function_Loading_Database_Employee(); ;
		}


		/*private void DeletionBar()
		{
			dataGridView1.DataSource = dataTable;
			/*
				Установка ширины 0 столба в 30 единиц.
				И установка содержимого в центр ячейки.
			/*
			this.dataGridView1.Columns[0].Width = 30;
			this.dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			if (dataGridView1.Columns.Count <= 4)
			{
				dataGridView1.Columns.Add(new DataGridViewButtonColumn()
				{
					Text = "Say Hi",
					UseColumnTextForButtonValue = true,
					AutoSizeMode = DataGridViewAutoSizeColumnMode.None
				});
			}
		}*/

	}
}

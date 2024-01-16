using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_3
{
	public partial class Catalog : Form
	{
		public Catalog()
		{
			InitializeComponent();
			LoadTableBooks();
		}

		static BD_Connection db = new BD_Connection();
		DataTable dataTable = new DataTable();
		MySqlDataAdapter adapter;
		MySqlCommand command;
		DataSet dataSet = new DataSet();

		private void LoadTableBooks()
		{
			db.OpenConnection();

			command = new MySqlCommand("SELECT `id`, `Name`, `Avtar`, `About_author`, `About_book`, `availability` " +
				"FROM `Books`", db.getConnection());
			command.ExecuteNonQuery();
			dataTable = new DataTable();

			adapter = new MySqlDataAdapter(command);
			adapter.Fill(dataTable);

			db.CloseConnection();

			dataGridView_Tabl.DataSource = dataTable;
			/*
				Установка ширины 0 столба в 30 единиц.
				И установка содержимого в центр ячейки.
			*/
			Field_Parameters();
		}

		private void LoadTableImg(int id_card)
		{
			if (pictureBox.Image != null)
			{
				pictureBox.Image.Dispose();
				pictureBox.Image = null;
			}
			db.OpenConnection();

			command = new MySqlCommand("SELECT `id`, `imagepath` FROM `Books` WHERE `id` = @id", db.getConnection());
			command.Parameters.Add("@id", MySqlDbType.Int32).Value = id_card;
			command.ExecuteNonQuery();

			adapter = new MySqlDataAdapter(command);
			adapter.Fill(dataSet, "imagepath");
			int c = dataSet.Tables["imagepath"].Rows.Count;

			if (c > 0)
			{
				//BLOB считывается в массив байтов, затем используется для построения MemoryStream,
				//затем передается в PictureBox.
				Byte[] byteBLOBData = new Byte[0];
				var byteBLOBData1 = byteBLOBData = (Byte[])(dataSet.Tables["imagepath"].Rows[c - 1]["imagepath"]);
				
				MemoryStream stmBLOBData1 = new MemoryStream(byteBLOBData1);

				pictureBox.Image = Image.FromStream(stmBLOBData1);
				/*
				//Отладка загрузки отображения картинок
				adapter.Fill(dataTable);
				dataGridView_Img.DataSource = dataTable;
				*/
			}
			db.CloseConnection();
		}

		private void Catalog_FormClosed(object sender, FormClosedEventArgs e)
		{
			HomForm homForm = new HomForm();
			homForm.Show();
			this.Hide();
		}

		private void dataGridView_Tabl_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			byte index = Convert.ToByte(dataGridView_Tabl[0, e.RowIndex].Value.ToString());
			LoadTableImg(index);

			Console.WriteLine(index);
		}

		private void SearchBtn_Click(object sender, EventArgs e)
		{
			if (TB_Name.Text != "")
			{
				db.OpenConnection();
				//Console.WriteLine("TextBoxLogin NULL");
				command = new MySqlCommand("SELECT * FROM `Books` " +
					"WHERE `Name` = @Name", db.getConnection());
				command.Parameters.Add("@Name", MySqlDbType.VarChar).Value = TB_Name.Text;
				command.ExecuteNonQuery();
				db.CloseConnection();

				dataTable = new DataTable();
				adapter = new MySqlDataAdapter(command);
				adapter.Fill(dataTable);

			}
			else if (TB_Avtar.Text != "")
			{
				db.OpenConnection();
				command = new MySqlCommand("SELECT * FROM `Books` " +
					"WHERE `Avtar` = @Avtar", db.getConnection());
				command.Parameters.Add("@Avtar", MySqlDbType.VarChar).Value = TB_Avtar.Text;
				command.ExecuteNonQuery();
				db.CloseConnection();

				dataTable = new DataTable();
				adapter = new MySqlDataAdapter(command);
				adapter.Fill(dataTable);

			}
			else
				Console.WriteLine("Заполните хотя бы 1 поле для поиска.");

			//dataGridViewEmployee.Rows.Clear();
			dataGridView_Tabl.DataSource = dataTable;

			dataGridView_Tabl.Columns["imagename"].Visible = false;
			dataGridView_Tabl.Columns["iamgetype"].Visible = false;
			dataGridView_Tabl.Columns["imagepath"].Visible = false;

			Field_Parameters();
		}



		private void Field_Parameters()
		{
			this.dataGridView_Tabl.Columns[0].Width = 30;
			this.dataGridView_Tabl.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			this.dataGridView_Tabl.Columns[1].Width = 300;
			this.dataGridView_Tabl.Columns[2].Width = 300;
			this.dataGridView_Tabl.Columns[4].Width = 300;
		}

		private void TB_Name_TextChanged(object sender, EventArgs e)
		{
			LoadTableBooks();
		}
		private void TB_Avtar_TextChanged(object sender, EventArgs e)
		{
			LoadTableBooks();
		}
		private void textBox3_TextChanged(object sender, EventArgs e)
		{
			LoadTableBooks();
		}
	}
}

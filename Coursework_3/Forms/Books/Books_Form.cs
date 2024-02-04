using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using Coursework_3.Classes;

namespace Coursework_3
{
	public partial class Books_Form : Form
	{
		public Books_Form()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
		}
		//private static System.Timers.Timer aTimer;

		static BD_Connection db = new BD_Connection();
		static DataTable dataTable;
		static SqlDataAdapter adapter;
		static SqlCommand command;
		static DataSet dataSet = new DataSet();
        static JournalRecordsHistory history = new JournalRecordsHistory();

        public int id_cards;

		public string LabelText
		{
			get{
				return this.Name_Avtor_label.Text;
			}
			set
			{
				this.Name_Avtor_label.Text = value;
			}
		}

		private void timer_Tick(object sender, EventArgs e)
		{
			Console.WriteLine("Timer start");
			Function_Loading_Cart();
			timer.Stop();
		}

		private void Function_Loading_Cart()
		{
			try
			{
				Console.WriteLine("id_cards:  " + id_cards);
				if (id_cards == 0)
				{
					MessageBox.Show("Книга не обнаружена.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				db.OpenConnection();
				command = new SqlCommand("SELECT * FROM Books WHERE id =  @id", db.getConnection());
				command.Parameters.Add("@id", SqlDbType.Int).Value = id_cards;
				command.ExecuteNonQuery();
				dataTable = new DataTable();

				adapter = new SqlDataAdapter(command);
				adapter.Fill(dataTable);
				db.CloseConnection();

				Function_Loading_Cart2();
				ImgLoader();
			}
			catch(Exception ex)
			{
				MessageBox.Show("Не удалось загрузить карту", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                history.LogWriter($"{DateTime.UtcNow.AddHours(3)} | ПОПЫТКА ЗАГРУЗКИ КАРТУ - {Form.ActiveForm} | {ex.Message} | НЕУДАЧНО \n");
            }
		}

		private void ImgLoader()
		{
			try
			{
				db.OpenConnection();
				command = new SqlCommand("SELECT imagepath FROM Books WHERE id = @id_Img", db.getConnection());
				command.Parameters.Add("@id_Img", SqlDbType.VarChar).Value = id_cards;
				db.CloseConnection();

				adapter = new SqlDataAdapter(command);
				adapter.Fill(dataSet, "imagepath");
				int c = dataSet.Tables["imagepath"].Rows.Count;

				if (c > 0)
				{
					//BLOB считывается в массив байтов, затем используется для построения MemoryStream,
					//затем передается в PictureBox.

					Byte[] byteBLOBData = new Byte[0];
					var byteBLOBData1 = byteBLOBData = (Byte[])(dataSet.Tables["imagepath"].Rows[c - 1]["imagepath"]);

					MemoryStream stmBLOBData1 = new MemoryStream(byteBLOBData1);

					Img_Book.Image = Image.FromStream(stmBLOBData1);
					
					//Отладка загрузки отображения картинок
					adapter.Fill(dataTable);
					dataGridView1.DataSource = dataTable;
				}
			}
			catch (Exception ex)
			{
                MessageBox.Show("Не удалось загрузить карту", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                history.LogWriter($"{DateTime.UtcNow.AddHours(3)} | ПОПЫТКА ЗАГРУЗКИ ИЗОБРАЖЕНИЕ - {Form.ActiveForm} | {ex.Message} | НЕУДАЧНО \n");
            }
		}

		private void Function_Loading_Cart2()
		{
			try
			{
				db.OpenConnection();
				command = new SqlCommand("SELECT Name, Avtar, About_author,	About_book, availability " +
					"FROM Books WHERE id = @id_Img", db.getConnection());

				command.Parameters.Add("@id_Img", SqlDbType.VarChar).Value = id_cards;

				command.ExecuteNonQuery();
				dataTable = new DataTable();

				adapter = new SqlDataAdapter(command);
				adapter.Fill(dataTable);
				db.CloseConnection();

				dataGridView1.DataSource = dataTable;

				Name_book_label.Text = dataGridView1[0, 0].Value.ToString();
				Name_Avtor_label.Text = dataGridView1[1, 0].Value.ToString();
				About_author.Text = dataGridView1[2, 0].Value.ToString();
				About_book.Text = dataGridView1[3, 0].Value.ToString();
				label_number.Text = dataGridView1[4, 0].Value.ToString();
			}
			catch (Exception ex)
			{
                MessageBox.Show("Не удалось загрузить карту", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                history.LogWriter($"{DateTime.UtcNow.AddHours(3)} | ПОПЫТКА ЗАГРУЗКИ КАРТУ - {Form.ActiveForm} | {ex.Message} | НЕУДАЧНО \n");
            }
		}
	}
}

using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using System.Data.SqlClient;
using Coursework_3.Classes;
using System.Drawing.Imaging;
using System.Drawing;


namespace Coursework_3
{
	public partial class NewBooks : Form
	{
		public NewBooks()
		{
			InitializeComponent();
		}

		static BD_Connection db = new BD_Connection();
		static SqlCommand command;
		static JournalRecordsHistory history = new JournalRecordsHistory();
		//static MemoryStream memory = new MemoryStream();
		//static StreamReader stream = new StreamReader(memory);

		public string filePath;// Путь к файлу
		public string fileExtension;// Расширение файла

		static LoadIImg Load_Img = new LoadIImg();
		static DataTable dataTable = new DataTable();
		static SqlDataAdapter adapter;
		static DataSet dataSet = new DataSet();


		private void AdditionBtn_Click(object sender, EventArgs e)
		{
			string NameBook = NameTb.Text,
				Avtar = AvtarTb.Text,
				AboutAuthor = AboutAuthorTb.Text,
				AboutBook = AboutBookTb.Text,
				Location = LocationTb.Text,
				FormatImage = Convert.ToString(pictureBox.Image);
			//byte[] str_img = Load_Img.image_bytes;

		/*	if (NameTb.Text == "" && AvtarTb.Text == "" && LocationTb.Text == "") {
				MessageBox.Show("Не все важные поля заполнены.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}*/
			try {
				byte[] photo_array;
				using (MemoryStream memory = new MemoryStream()) {
					pictureBox.Image.Save(memory, ImageFormat.Jpeg);
					photo_array = new byte[memory.Length];
					memory.Position = 0;
					memory.Read(photo_array, 0, photo_array.Length);
				}

				command = new SqlCommand("INSERT INTO Books (Name, Avtar, About_author, About_book, Availability, Location, Imagename, Iamgetype, Imagepath) " +
                    "VALUES (@name, @avatar, @about_author, @about_book, @availability, @Location, @imagename, @iamgetype, @imagepath)", db.getConnection());

				command.Parameters.Add("@name",			SqlDbType.NVarChar).Value = NameBook;
				command.Parameters.Add("@avatar",		SqlDbType.NVarChar).Value = Avtar;
				command.Parameters.Add("@about_author", SqlDbType.NVarChar).Value = AboutAuthor;
				command.Parameters.Add("@about_book",	SqlDbType.NVarChar).Value = AboutBook;
				command.Parameters.Add("@availability", SqlDbType.NVarChar).Value = "Новое";
				command.Parameters.Add("@Location",		SqlDbType.NVarChar).Value = Location;
				command.Parameters.Add("@imagename",	SqlDbType.NVarChar).Value = NameBook;
				command.Parameters.Add("@iamgetype",	SqlDbType.NVarChar).Value = FormatImage;
				command.Parameters.Add("@imagepath",	SqlDbType.Image, 1000000).Value = photo_array;

				//MemoryStream memory = new MemoryStream();

				/*//Сохраните изображение из PictureBox в объект MemoryStream.
				pictureBox.Image.Save(memory, ImageFormat.Jpeg);
				Byte[] bytBLOBData = new Byte[memory.Length];
				memory.Position = 0;
				memory.Read(bytBLOBData, 0, Convert.ToInt32(memory.Length));

				//Создайте параметр для оператора вставки, содержащий изображение.
				SqlParameter Parameter = new SqlParameter("@imagepath", SqlDbType.VarBinary, bytBLOBData.Length,
					ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bytBLOBData);
				command.Parameters.Add(Parameter);*/

				/*
				MemoryStream memory = new MemoryStream();
				using (var memoryStream = new MemoryStream()) {
					pictureBox.Image.Save(memoryStream, pictureBox.Image.RawFormat);
					command.Parameters.Add("@img", SqlDbType.Binary).Value = memoryStream.ToArray();
				}*/

				db.OpenConnection();
				if (command.ExecuteNonQuery() == 1)
					MessageBox.Show("Книга добавлена.");
				else
					MessageBox.Show("Не удалось добавить.");
				db.CloseConnection();
				ResetField();

			}catch(Exception ex) {
				MessageBox.Show($"Не удалось добавить - {Avtar}");
				history.LogWriter($"{DateTime.UtcNow.AddHours(3)} | ПОПЫТКА ДОБАВЛЕНИЯ - {NameBook} | {ex.Message} | НЕУДАЧНО \n");
				//history.LogWriter($"{DateTime.UtcNow.AddHours(3)} | ПУТЬ К ФАЙЛУ - {filePath} | MEMORY - {memory} | \n");
			}
			finally { db.CloseConnection(); }
		}	

		private void ResetField()
		{
			pictureBox.Image = Image.FromFile("D:\\Prodgect\\CourseWork_3_courses\\Coursework_3\\Coursework_3\\Resources\\Image_none.png");
			NameTb.Text = null;
			AvtarTb.Text = null;
			AboutAuthorTb.Text = null;
			AboutBookTb.Text = null;
			LocationTb.Text = null;	
		}

		private void NewBooks_FormClosed(object sender, FormClosedEventArgs e)
		{
			HomForm homForm = new HomForm();
			homForm.Show();
			this.Hide();
		}

		private void pictureBox_Click(object sender, EventArgs e)
		{
			LoadIImg load_Img = new LoadIImg() { key = 2 };
			load_Img.Show();
			this.Hide();
		}
		private void NameTb_TextChanged(object sender, EventArgs e)
		{
			if (NameTb.Text == "")
				ControlName.Visible = true;
			else
				ControlName.Visible = false;
		}
		private void AvtarTb_TextChanged(object sender, EventArgs e)
		{
			if (AvtarTb.Text == "")
				ControlAvtar.Visible = true;
			else
				ControlAvtar.Visible = false;
		}
		private void LocationTb_TextChanged(object sender, EventArgs e)
		{
			if (LocationTb.Text == "")
				ControlCheck.Visible = true;
			else
				ControlCheck.Visible = false;
		}
    }
}

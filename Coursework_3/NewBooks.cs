using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_3
{
	public partial class NewBooks : Form
	{
		public NewBooks()
		{
			InitializeComponent();
		}

		static BD_Connection db = new BD_Connection();
		DataTable dataTable = new DataTable();
		MySqlDataAdapter adapter;
		MySqlCommand command;
		DataSet dataSet = new DataSet();

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

		private void DeleteImgBtn_Click(object sender, EventArgs e)
		{
			pictureBox.Image = Properties.Resources.Image;
		}

		private void AdditionBtn_Click(object sender, EventArgs e)
		{
			if (NameTb.Text == "" && AvtarTb.Text == "" && LocationTb.Text == "")
			{
				MessageBox.Show("Не все важные поля заполнены.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			command = new MySqlCommand("INSERT INTO `Books` (`id`, `Name`, `Avtar`, `About_author`, `About_book`, `availability`, `imagepath`) " +
				"VALUES (NULL, @name, @avatar, @about_author, @about_book, @Location,  @BLOBData)", db.getConnection());

			command.Parameters.Add("@name", MySqlDbType.VarChar).Value = NameTb.Text;
			command.Parameters.Add("@avatar", MySqlDbType.VarChar).Value = AvtarTb.Text;
			command.Parameters.Add("@about_author", MySqlDbType.VarChar).Value = AboutAuthorTb.Text;
			command.Parameters.Add("@about_book", MySqlDbType.VarChar).Value = AboutBookTb.Text;
			command.Parameters.Add("@Location", MySqlDbType.VarChar).Value = LocationTb.Text;

			MemoryStream memory = new MemoryStream();
			pictureBox.Image.Save(memory, ImageFormat.Jpeg);

			//Сохраните изображение из PictureBox в объект MemoryStream.
			Byte[] bytBLOBData = new Byte[memory.Length];
			memory.Position = 0;
			memory.Read(bytBLOBData, 0, Convert.ToInt32(memory.Length));

			//Создайте параметр для оператора вставки, содержащий изображение.
			MySqlParameter Parameter = new MySqlParameter("@BLOBData", MySqlDbType.LongBlob, bytBLOBData.Length, 
				ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, bytBLOBData);

			command.Parameters.Add(Parameter);

			db.OpenConnection();

			if (command.ExecuteNonQuery() == 2)
				MessageBox.Show("Аккаунт был создан.");
			else
				MessageBox.Show("Аккаунт не был создан.");

			db.CloseConnection();
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

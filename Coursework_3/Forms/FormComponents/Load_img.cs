using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using Coursework_3.Classes;

namespace Coursework_3
{
	public partial class LoadIImg : Form
	{
		public LoadIImg()
		{
			InitializeComponent();
		}

		public byte key;
		public byte[] image_bytes;
		string filePath_Load;// Путь к файлу
		string fileExtension_Load;// Расширение файла
		
		static JournalRecordsHistory history = new JournalRecordsHistory();

		static JpegBitmapEncoder encoder = new JpegBitmapEncoder();
		static Bitmap image;
		static FileStream stream;

		private void pictureBox_Click(object sender, EventArgs e)
		{
			OpenFileDialog open_dialog = new OpenFileDialog()
			{
				Filter = "JPED; PNG|*.jpg; *.png; *.jpeg",
				ValidateNames = true,
				Multiselect = false
			}; //создание диалогового окна для выбора файла
			   // Показать диалог открытия файла. Если пользователь нажимает кнопку OK, то загружается рисунок.
			   // рисунок, который выбрал пользователь.
			if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
			{
				try
				{
					pictureBox.Image = Image.FromFile(open_dialog.FileName);
					filePath_Load = open_dialog.FileName;
					fileExtension_Load = Path.GetExtension(filePath_Load);
					/*	
                    MemoryStream ms = new MemoryStream();
                    pictureBox.Image.Save(ms, ImageFormat.Jpeg);
                    byte[] photo_array = new byte[ms.Length];
                    ms.Position = 0;
                    ms.Read(photo_array, 0, photo_array.Length);

                    string path = Convert.ToString(pictureBox.Image);
                    FileStream stream = new FileStream(path, FileMode.Create);
                    JpegBitmapEncoder encoder = new JpegBitmapEncoder();
                    encoder.Frames.Add(BitmapFrame.Create(img));
                    encoder.Save(stream);
                    stream.Close();

                    image = new Bitmap(open_dialog.FileName);
					//вместо pictureBox1 укажите pictureBox, в который нужно загрузить изображение 
					this.pictureBox.Size = image.Size;
					pictureBox.Image = image;
					pictureBox.Invalidate();
                    
					stream = new FileStream(image, FileMode.Create);
                    encoder.FlipHorizontal = true;
                    encoder.FlipVertical = false;
                    encoder.QualityLevel = 30;
                    encoder.Rotation = Rotation.Rotate90;
                    //encoder.Frames.Add(BitmapFrame.Create(image));
                    encoder.Save(stream);
					*/
				}
				catch (Exception ex)
				{
					MessageBox.Show("Не удалось открыть изображение!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
					history.LogWriter($"{DateTime.UtcNow.AddHours(3)} | ПОПЫТКА ЗАГРУЗКИ ИЗОБРАЖЕНИЯ - {Form.ActiveForm} | {ex.Message} | НЕУДАЧНО \n");
				}
			}
		}

		private void close_Click()
		{
			if (key == 1)
			{
				LogIn_People logIn_People = new LogIn_People();
				if (pictureBox.Image != null)
					if (MessageBox.Show("Сохранить изображение?", "Сохранить?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
						logIn_People.pictureBox.Image = pictureBox.Image;
				history.LogWriter($"{DateTime.UtcNow.AddHours(3)} | ЗАГРУЗУККА КАРТИНКИ - /| | НА ФОРМУ - {logIn_People.Name} | \n");
				this.Hide();
				logIn_People.Show();
			}
			else if (key == 2)
			{
				NewBooks newBooks = new NewBooks() { filePath = filePath_Load, fileExtension = fileExtension_Load };
				if (pictureBox.Image != null)
					if (MessageBox.Show("Сохранить изображение?", "Сохранить?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
						newBooks.pictureBox.Image = pictureBox.Image;
				history.LogWriter($"{DateTime.UtcNow.AddHours(3)} | ЗАГРУЗУККА КАРТИНКИ - /| | НА ФОРМУ - {newBooks.Name} | \n");
				this.Hide();
				newBooks.Show();
			}
			else
				return;
		}

		private void LoadIImg_FormClosed(object sender, FormClosedEventArgs e)
		{
			close_Click();
		}
	}
}

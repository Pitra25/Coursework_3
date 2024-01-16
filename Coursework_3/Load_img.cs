using Microsoft.Graph.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Coursework_3
{
	public partial class LoadIImg : Form
	{
		public LoadIImg()
		{
			InitializeComponent();
			this.StartPosition = FormStartPosition.CenterScreen;
		}

		public byte key;

		private void pictureBox_Click(object sender, EventArgs e)
		{
			// Показать диалог открытия файла. Если пользователь нажимает кнопку OK, то загружается рисунок.
			// рисунок, который выбрал пользователь.
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
				pictureBox.Load(openFileDialog1.FileName);
		}

		private void close_Click()
		{
			if (key == 1)
			{
				LogIn_People logIn_People = new LogIn_People();
				if (pictureBox.Image != null)
					if (MessageBox.Show("Сохранить изображение?", "Сохранить?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
						logIn_People.pictureBox.Image = pictureBox.Image;
				this.Hide();
				logIn_People.Show();
			}
			else if (key == 2)
			{
				NewBooks newBooks = new NewBooks();
				if (pictureBox.Image != null)
					if (MessageBox.Show("Сохранить изображение?", "Сохранить?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
						newBooks.pictureBox.Image = pictureBox.Image;
				this.Hide();
				newBooks.Show();
			}
			else
				return;
		}

		private void LoadIImg_FormClosing(object sender, FormClosingEventArgs e)
		{
			close_Click();
		}
	}
}

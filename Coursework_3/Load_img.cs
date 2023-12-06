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

		private void pictureBox_Click(object sender, EventArgs e)
		{
			// Показать диалог открытия файла. Если пользователь нажимает кнопку OK, то загружается рисунок.
			// рисунок, который выбрал пользователь.
			if (openFileDialog1.ShowDialog() == DialogResult.OK)
				pictureBox.Load(openFileDialog1.FileName);
		}
		private void clearButton_Click(object sender, EventArgs e)
		{
			pictureBox.Image = null;
		}
		private void backgroundButton_Click(object sender, EventArgs e)
		{
			// Показать диалоговое окно выбора цвета. Если пользователь нажмет кнопку OK, то изменит
			// фон элемента управления PictureBox на цвет, который выбрал пользователь.
			if (colorDialog1.ShowDialog() == DialogResult.OK)
				pictureBox.BackColor = colorDialog1.Color;
		}
		private void closeButton_Click(object sender, EventArgs e)
		{
			close_Click();
		}

		private void close_Click()
		{
			LogIn_People logIn_People = new LogIn_People();
			if (pictureBox.Image != null)
				if (MessageBox.Show("Сохранить изображение?", "Сохранить?", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
					logIn_People.pictureBox1.Image = pictureBox.Image;
			this.Hide();
			logIn_People.Show();
		}

		/*PhotoSaving(1);
		private void PhotoSaving(sbyte inter)
		{
			LogIn_People logIn_People = new LogIn_People();
			if (inter == 2)
				logIn_People.pictureBox1.Image = pictureBox.Image;
			this.Hide();
			logIn_People.Show();
		}*/

		private void checkBox_Stretch_CheckedChanged(object sender, EventArgs e)
		{
			// Если пользователь установит флажок Stretch, 
			// измените свойство PictureBox
			// свойство SizeMode на "Stretch". Если пользователь снимает 
			// флажок, измените его на "Normal".
			if (checkBox_Stretch.Checked)
				pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			else
				pictureBox.SizeMode = PictureBoxSizeMode.Normal;
		}

		private void LoadIImg_FormClosing(object sender, FormClosingEventArgs e)
		{
			close_Click();
		}
	}
}

namespace Coursework_3
{
	partial class LoadIImg
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.pictureBox = new System.Windows.Forms.PictureBox();
			this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
			this.checkBox_Stretch = new System.Windows.Forms.CheckBox();
			this.clearButton = new System.Windows.Forms.Button();
			this.backgroundButton = new System.Windows.Forms.Button();
			this.closeButton = new System.Windows.Forms.Button();
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.tableLayoutPanel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
			this.flowLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Controls.Add(this.pictureBox, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 2, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 34F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 467);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// pictureBox
			// 
			this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
			this.tableLayoutPanel1.SetColumnSpan(this.pictureBox, 2);
			this.pictureBox.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pictureBox.Location = new System.Drawing.Point(3, 3);
			this.pictureBox.Name = "pictureBox";
			this.pictureBox.Size = new System.Drawing.Size(794, 427);
			this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox.TabIndex = 1;
			this.pictureBox.TabStop = false;
			this.pictureBox.Click += new System.EventHandler(this.pictureBox_Click);
			// 
			// flowLayoutPanel1
			// 
			this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
			this.flowLayoutPanel1.Controls.Add(this.checkBox_Stretch);
			this.flowLayoutPanel1.Controls.Add(this.clearButton);
			this.flowLayoutPanel1.Controls.Add(this.backgroundButton);
			this.flowLayoutPanel1.Controls.Add(this.closeButton);
			this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 436);
			this.flowLayoutPanel1.Name = "flowLayoutPanel1";
			this.flowLayoutPanel1.Size = new System.Drawing.Size(794, 28);
			this.flowLayoutPanel1.TabIndex = 2;
			// 
			// checkBox_Stretch
			// 
			this.checkBox_Stretch.AutoSize = true;
			this.checkBox_Stretch.Location = new System.Drawing.Point(3, 3);
			this.checkBox_Stretch.Name = "checkBox_Stretch";
			this.checkBox_Stretch.Size = new System.Drawing.Size(60, 17);
			this.checkBox_Stretch.TabIndex = 0;
			this.checkBox_Stretch.Text = "Stretch";
			this.checkBox_Stretch.UseVisualStyleBackColor = true;
			this.checkBox_Stretch.CheckedChanged += new System.EventHandler(this.checkBox_Stretch_CheckedChanged);
			// 
			// clearButton
			// 
			this.clearButton.Location = new System.Drawing.Point(69, 3);
			this.clearButton.Name = "clearButton";
			this.clearButton.Size = new System.Drawing.Size(115, 23);
			this.clearButton.TabIndex = 1;
			this.clearButton.Text = "Очистить рисунок";
			this.clearButton.UseVisualStyleBackColor = true;
			this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
			// 
			// backgroundButton
			// 
			this.backgroundButton.Location = new System.Drawing.Point(190, 3);
			this.backgroundButton.Name = "backgroundButton";
			this.backgroundButton.Size = new System.Drawing.Size(117, 23);
			this.backgroundButton.TabIndex = 2;
			this.backgroundButton.Text = "Установить цвет фона";
			this.backgroundButton.UseVisualStyleBackColor = true;
			this.backgroundButton.Click += new System.EventHandler(this.backgroundButton_Click);
			// 
			// closeButton
			// 
			this.closeButton.Location = new System.Drawing.Point(313, 3);
			this.closeButton.Name = "closeButton";
			this.closeButton.Size = new System.Drawing.Size(114, 23);
			this.closeButton.TabIndex = 3;
			this.closeButton.Text = "Закрыть";
			this.closeButton.UseVisualStyleBackColor = true;
			this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "openFileDialog1";
			this.openFileDialog1.Filter = "JPEG Files (*.jpg)|*.jpg|PNG Files (*.png)|*.png|BMP Files (*.bmp)|*.bmp|All file" +
    "s (*.*)|*.*";
			this.openFileDialog1.Title = "Выбор файла изображения";
			// 
			// LoadIImg
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 467);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "LoadIImg";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Load_img";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.LoadIImg_FormClosing);
			this.tableLayoutPanel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
			this.flowLayoutPanel1.ResumeLayout(false);
			this.flowLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.PictureBox pictureBox;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
		private System.Windows.Forms.CheckBox checkBox_Stretch;
		private System.Windows.Forms.Button clearButton;
		private System.Windows.Forms.Button backgroundButton;
		private System.Windows.Forms.Button closeButton;
		private System.Windows.Forms.ColorDialog colorDialog1;
	}
}
namespace Coursework_3
{
	partial class Books_Form
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
			this.components = new System.ComponentModel.Container();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.Img_Book = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.Name_book_label = new System.Windows.Forms.Label();
			this.Name_Avtor_label = new System.Windows.Forms.Label();
			this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.About_author = new System.Windows.Forms.Label();
			this.About_book = new System.Windows.Forms.Label();
			this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.tableLayoutPanel5 = new System.Windows.Forms.TableLayoutPanel();
			this.label_number = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.timer = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.Img_Book)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.tableLayoutPanel3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.tableLayoutPanel4.SuspendLayout();
			this.tableLayoutPanel5.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(117)))), ((int)(((byte)(93)))));
			this.tableLayoutPanel2.ColumnCount = 3;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 97.4026F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 2.597403F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 497F));
			this.tableLayoutPanel2.Controls.Add(this.Img_Book, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel1, 0, 1);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel3, 2, 0);
			this.tableLayoutPanel2.Controls.Add(this.tableLayoutPanel4, 2, 1);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 2;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 76.24521F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.75479F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(766, 522);
			this.tableLayoutPanel2.TabIndex = 1;
			// 
			// Img_Book
			// 
			this.Img_Book.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Img_Book.Image = global::Coursework_3.Properties.Resources.Image;
			this.Img_Book.Location = new System.Drawing.Point(3, 3);
			this.Img_Book.Name = "Img_Book";
			this.Img_Book.Size = new System.Drawing.Size(256, 392);
			this.Img_Book.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Img_Book.TabIndex = 0;
			this.Img_Book.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.Name_book_label, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.Name_Avtor_label, 0, 1);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 401);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 2;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(256, 118);
			this.tableLayoutPanel1.TabIndex = 1;
			// 
			// Name_book_label
			// 
			this.Name_book_label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Name_book_label.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name_book_label.Location = new System.Drawing.Point(3, 0);
			this.Name_book_label.Name = "Name_book_label";
			this.Name_book_label.Size = new System.Drawing.Size(250, 59);
			this.Name_book_label.TabIndex = 0;
			this.Name_book_label.Text = "Название";
			this.Name_book_label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// Name_Avtor_label
			// 
			this.Name_Avtor_label.Dock = System.Windows.Forms.DockStyle.Fill;
			this.Name_Avtor_label.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name_Avtor_label.Location = new System.Drawing.Point(3, 59);
			this.Name_Avtor_label.Name = "Name_Avtor_label";
			this.Name_Avtor_label.Size = new System.Drawing.Size(250, 59);
			this.Name_Avtor_label.TabIndex = 1;
			this.Name_Avtor_label.Text = "Автор";
			this.Name_Avtor_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// tableLayoutPanel3
			// 
			this.tableLayoutPanel3.ColumnCount = 1;
			this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 46.23656F));
			this.tableLayoutPanel3.Controls.Add(this.dataGridView1, 0, 2);
			this.tableLayoutPanel3.Controls.Add(this.About_author, 0, 1);
			this.tableLayoutPanel3.Controls.Add(this.About_book, 0, 0);
			this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel3.Location = new System.Drawing.Point(271, 3);
			this.tableLayoutPanel3.Name = "tableLayoutPanel3";
			this.tableLayoutPanel3.RowCount = 3;
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 64.13043F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 35.86956F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
			this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel3.Size = new System.Drawing.Size(492, 392);
			this.tableLayoutPanel3.TabIndex = 2;
			// 
			// dataGridView1
			// 
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(3, 371);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.Size = new System.Drawing.Size(203, 18);
			this.dataGridView1.TabIndex = 5;
			this.dataGridView1.Visible = false;
			// 
			// About_author
			// 
			this.About_author.Dock = System.Windows.Forms.DockStyle.Fill;
			this.About_author.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.About_author.Location = new System.Drawing.Point(3, 236);
			this.About_author.Name = "About_author";
			this.About_author.Size = new System.Drawing.Size(486, 132);
			this.About_author.TabIndex = 1;
			this.About_author.Text = "Об авторе";
			this.About_author.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// About_book
			// 
			this.About_book.Dock = System.Windows.Forms.DockStyle.Fill;
			this.About_book.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.About_book.Location = new System.Drawing.Point(3, 0);
			this.About_book.Name = "About_book";
			this.About_book.Size = new System.Drawing.Size(486, 236);
			this.About_book.TabIndex = 2;
			this.About_book.Text = "О книге";
			this.About_book.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// tableLayoutPanel4
			// 
			this.tableLayoutPanel4.ColumnCount = 2;
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.Controls.Add(this.label4, 1, 0);
			this.tableLayoutPanel4.Controls.Add(this.button1, 0, 1);
			this.tableLayoutPanel4.Controls.Add(this.tableLayoutPanel5, 0, 0);
			this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel4.Location = new System.Drawing.Point(271, 401);
			this.tableLayoutPanel4.Name = "tableLayoutPanel4";
			this.tableLayoutPanel4.RowCount = 2;
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel4.Size = new System.Drawing.Size(492, 118);
			this.tableLayoutPanel4.TabIndex = 3;
			// 
			// label4
			// 
			this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label4.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(249, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(240, 59);
			this.label4.TabIndex = 1;
			this.label4.Text = "В наличии \r\nНет в наличии\r\nСкоро";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// button1
			// 
			this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.button1.BackColor = System.Drawing.Color.DarkGray;
			this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
			this.button1.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(117)))), ((int)(((byte)(93)))));
			this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F);
			this.button1.ForeColor = System.Drawing.Color.White;
			this.button1.Location = new System.Drawing.Point(52, 62);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(141, 53);
			this.button1.TabIndex = 2;
			this.button1.Text = "Взять";
			this.button1.UseVisualStyleBackColor = false;
			// 
			// tableLayoutPanel5
			// 
			this.tableLayoutPanel5.ColumnCount = 2;
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Controls.Add(this.label_number, 0, 0);
			this.tableLayoutPanel5.Controls.Add(this.label3, 0, 0);
			this.tableLayoutPanel5.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel5.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel5.Name = "tableLayoutPanel5";
			this.tableLayoutPanel5.RowCount = 1;
			this.tableLayoutPanel5.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel5.Size = new System.Drawing.Size(240, 53);
			this.tableLayoutPanel5.TabIndex = 3;
			// 
			// label_number
			// 
			this.label_number.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label_number.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_number.Location = new System.Drawing.Point(123, 0);
			this.label_number.Name = "label_number";
			this.label_number.Size = new System.Drawing.Size(114, 53);
			this.label_number.TabIndex = 3;
			this.label_number.Text = "... / ...";
			this.label_number.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// label3
			// 
			this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.label3.Font = new System.Drawing.Font("HoloLens MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(6, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(107, 53);
			this.label3.TabIndex = 2;
			this.label3.Text = "Ряд / Полка";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// timer
			// 
			this.timer.Enabled = true;
			this.timer.Interval = 900;
			this.timer.Tick += new System.EventHandler(this.timer_Tick);
			// 
			// Books_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(766, 522);
			this.Controls.Add(this.tableLayoutPanel2);
			this.Name = "Books_Form";
			this.Text = "Детали книги";
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.Img_Book)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.tableLayoutPanel4.ResumeLayout(false);
			this.tableLayoutPanel5.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
		private System.Windows.Forms.PictureBox Img_Book;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label Name_book_label;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
		private System.Windows.Forms.Label About_author;
		private System.Windows.Forms.Label About_book;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel5;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label_number;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Timer timer;
		private System.Windows.Forms.Label Name_Avtor_label;
	}
}
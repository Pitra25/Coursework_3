using System.Windows.Forms;

namespace Coursework_3
{
	partial class Users_Form
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
			this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
			this.panel1 = new System.Windows.Forms.Panel();
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.panel2 = new System.Windows.Forms.Panel();
			this.Relout_btn = new System.Windows.Forms.Button();
			this.textBoxLoginEmployee = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.textBoxNameEmployee = new System.Windows.Forms.TextBox();
			this.Locate_btnEmployee = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
			this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
			this.panel3 = new System.Windows.Forms.Panel();
			this.button1 = new System.Windows.Forms.Button();
			this.textBoxLoginUser = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBoxNameUser = new System.Windows.Forms.TextBox();
			this.Locate_brn_User = new System.Windows.Forms.Button();
			this.label6 = new System.Windows.Forms.Label();
			this.textBoxID = new System.Windows.Forms.TextBox();
			this.DeleteEmployeeBtn = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.UserIdTB = new System.Windows.Forms.TextBox();
			this.DeleteUsersBtn = new System.Windows.Forms.Button();
			this.label7 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
			this.panel1.SuspendLayout();
			this.tabControl1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			this.tableLayoutPanel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.tabPage2.SuspendLayout();
			this.tableLayoutPanel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// dataGridViewEmployee
			// 
			this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewEmployee.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewEmployee.Name = "dataGridViewEmployee";
			this.dataGridViewEmployee.Size = new System.Drawing.Size(574, 470);
			this.dataGridViewEmployee.TabIndex = 0;
			this.dataGridViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.tabControl1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(834, 508);
			this.panel1.TabIndex = 1;
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.tabPage1);
			this.tabControl1.Controls.Add(this.tabPage2);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(834, 508);
			this.tabControl1.TabIndex = 3;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.tableLayoutPanel1);
			this.tabPage1.Location = new System.Drawing.Point(4, 22);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(826, 482);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "Сотрудники";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoScroll = true;
			this.tableLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.76566F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.23434F));
			this.tableLayoutPanel1.Controls.Add(this.dataGridViewEmployee, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 476F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 476F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 476F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(820, 476);
			this.tableLayoutPanel1.TabIndex = 2;
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.textBoxID);
			this.panel2.Controls.Add(this.DeleteEmployeeBtn);
			this.panel2.Controls.Add(this.label3);
			this.panel2.Controls.Add(this.Relout_btn);
			this.panel2.Controls.Add(this.textBoxLoginEmployee);
			this.panel2.Controls.Add(this.label1);
			this.panel2.Controls.Add(this.textBoxNameEmployee);
			this.panel2.Controls.Add(this.Locate_btnEmployee);
			this.panel2.Controls.Add(this.label2);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(583, 3);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(234, 470);
			this.panel2.TabIndex = 0;
			// 
			// Relout_btn
			// 
			this.Relout_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.Relout_btn.Location = new System.Drawing.Point(129, 176);
			this.Relout_btn.Name = "Relout_btn";
			this.Relout_btn.Size = new System.Drawing.Size(95, 37);
			this.Relout_btn.TabIndex = 8;
			this.Relout_btn.Text = "Обновить";
			this.Relout_btn.UseVisualStyleBackColor = false;
			this.Relout_btn.Click += new System.EventHandler(this.Update_btn_Click);
			// 
			// textBoxLoginEmployee
			// 
			this.textBoxLoginEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLoginEmployee.Location = new System.Drawing.Point(16, 67);
			this.textBoxLoginEmployee.Name = "textBoxLoginEmployee";
			this.textBoxLoginEmployee.Size = new System.Drawing.Size(207, 26);
			this.textBoxLoginEmployee.TabIndex = 2;
			this.textBoxLoginEmployee.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(15, 44);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 20);
			this.label1.TabIndex = 3;
			this.label1.Text = "Логин";
			// 
			// textBoxNameEmployee
			// 
			this.textBoxNameEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxNameEmployee.Location = new System.Drawing.Point(17, 127);
			this.textBoxNameEmployee.Name = "textBoxNameEmployee";
			this.textBoxNameEmployee.Size = new System.Drawing.Size(207, 26);
			this.textBoxNameEmployee.TabIndex = 4;
			this.textBoxNameEmployee.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// Locate_btnEmployee
			// 
			this.Locate_btnEmployee.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Locate_btnEmployee.Location = new System.Drawing.Point(17, 176);
			this.Locate_btnEmployee.Name = "Locate_btnEmployee";
			this.Locate_btnEmployee.Size = new System.Drawing.Size(95, 37);
			this.Locate_btnEmployee.TabIndex = 1;
			this.Locate_btnEmployee.Text = "Найти";
			this.Locate_btnEmployee.UseVisualStyleBackColor = true;
			this.Locate_btnEmployee.Click += new System.EventHandler(this.Locate_btnEmployee_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label2.Location = new System.Drawing.Point(15, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(40, 20);
			this.label2.TabIndex = 5;
			this.label2.Text = "Имя";
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.tableLayoutPanel2);
			this.tabPage2.Location = new System.Drawing.Point(4, 22);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(826, 482);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "Клиенты";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel2
			// 
			this.tableLayoutPanel2.AutoScroll = true;
			this.tableLayoutPanel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.tableLayoutPanel2.ColumnCount = 2;
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.76566F));
			this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.23434F));
			this.tableLayoutPanel2.Controls.Add(this.dataGridViewUsers, 0, 0);
			this.tableLayoutPanel2.Controls.Add(this.panel3, 1, 0);
			this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel2.Name = "tableLayoutPanel2";
			this.tableLayoutPanel2.RowCount = 1;
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel2.Size = new System.Drawing.Size(820, 476);
			this.tableLayoutPanel2.TabIndex = 3;
			// 
			// dataGridViewUsers
			// 
			this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridViewUsers.Location = new System.Drawing.Point(3, 3);
			this.dataGridViewUsers.Name = "dataGridViewUsers";
			this.dataGridViewUsers.Size = new System.Drawing.Size(574, 470);
			this.dataGridViewUsers.TabIndex = 0;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.UserIdTB);
			this.panel3.Controls.Add(this.DeleteUsersBtn);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.button1);
			this.panel3.Controls.Add(this.textBoxLoginUser);
			this.panel3.Controls.Add(this.label4);
			this.panel3.Controls.Add(this.textBoxNameUser);
			this.panel3.Controls.Add(this.Locate_brn_User);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel3.Location = new System.Drawing.Point(583, 3);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(234, 470);
			this.panel3.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
			this.button1.Location = new System.Drawing.Point(129, 176);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(95, 37);
			this.button1.TabIndex = 8;
			this.button1.Text = "Обновить";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.Update_btn_Click);
			// 
			// textBoxLoginUser
			// 
			this.textBoxLoginUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxLoginUser.Location = new System.Drawing.Point(17, 67);
			this.textBoxLoginUser.Name = "textBoxLoginUser";
			this.textBoxLoginUser.Size = new System.Drawing.Size(207, 26);
			this.textBoxLoginUser.TabIndex = 2;
			this.textBoxLoginUser.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label4.Location = new System.Drawing.Point(15, 44);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(55, 20);
			this.label4.TabIndex = 3;
			this.label4.Text = "Логин";
			// 
			// textBoxNameUser
			// 
			this.textBoxNameUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxNameUser.Location = new System.Drawing.Point(17, 127);
			this.textBoxNameUser.Name = "textBoxNameUser";
			this.textBoxNameUser.Size = new System.Drawing.Size(207, 26);
			this.textBoxNameUser.TabIndex = 4;
			this.textBoxNameUser.TextChanged += new System.EventHandler(this.textBox_TextChanged);
			// 
			// Locate_brn_User
			// 
			this.Locate_brn_User.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.Locate_brn_User.Location = new System.Drawing.Point(17, 176);
			this.Locate_brn_User.Name = "Locate_brn_User";
			this.Locate_brn_User.Size = new System.Drawing.Size(95, 37);
			this.Locate_brn_User.TabIndex = 1;
			this.Locate_brn_User.Text = "Найти";
			this.Locate_brn_User.UseVisualStyleBackColor = true;
			this.Locate_brn_User.Click += new System.EventHandler(this.Locate_brn_User_Click);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label6.Location = new System.Drawing.Point(15, 104);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(40, 20);
			this.label6.TabIndex = 5;
			this.label6.Text = "Имя";
			// 
			// textBoxID
			// 
			this.textBoxID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.textBoxID.Location = new System.Drawing.Point(47, 253);
			this.textBoxID.Name = "textBoxID";
			this.textBoxID.Size = new System.Drawing.Size(65, 26);
			this.textBoxID.TabIndex = 10;
			// 
			// DeleteEmployeeBtn
			// 
			this.DeleteEmployeeBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DeleteEmployeeBtn.Location = new System.Drawing.Point(129, 248);
			this.DeleteEmployeeBtn.Name = "DeleteEmployeeBtn";
			this.DeleteEmployeeBtn.Size = new System.Drawing.Size(95, 37);
			this.DeleteEmployeeBtn.TabIndex = 9;
			this.DeleteEmployeeBtn.Text = "Удалить";
			this.DeleteEmployeeBtn.UseVisualStyleBackColor = true;
			this.DeleteEmployeeBtn.Click += new System.EventHandler(this.DeleteEmployeeBtn_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label3.Location = new System.Drawing.Point(13, 256);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(26, 20);
			this.label3.TabIndex = 11;
			this.label3.Text = "ID";
			// 
			// UserIdTB
			// 
			this.UserIdTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.UserIdTB.Location = new System.Drawing.Point(47, 253);
			this.UserIdTB.Name = "UserIdTB";
			this.UserIdTB.Size = new System.Drawing.Size(65, 26);
			this.UserIdTB.TabIndex = 13;
			// 
			// DeleteUsersBtn
			// 
			this.DeleteUsersBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.DeleteUsersBtn.Location = new System.Drawing.Point(129, 248);
			this.DeleteUsersBtn.Name = "DeleteUsersBtn";
			this.DeleteUsersBtn.Size = new System.Drawing.Size(95, 37);
			this.DeleteUsersBtn.TabIndex = 12;
			this.DeleteUsersBtn.Text = "Удалить";
			this.DeleteUsersBtn.UseVisualStyleBackColor = true;
			this.DeleteUsersBtn.Click += new System.EventHandler(this.DeleteUsersBtn_Click);
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label7.Location = new System.Drawing.Point(13, 256);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(26, 20);
			this.label7.TabIndex = 14;
			this.label7.Text = "ID";
			// 
			// Users_Form
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(834, 508);
			this.Controls.Add(this.panel1);
			this.Name = "Users_Form";
			this.Text = "Пользователи";
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
			this.panel1.ResumeLayout(false);
			this.tabControl1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.panel2.ResumeLayout(false);
			this.panel2.PerformLayout();
			this.tabPage2.ResumeLayout(false);
			this.tableLayoutPanel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridViewEmployee;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox textBoxNameEmployee;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox textBoxLoginEmployee;
		private System.Windows.Forms.Button Locate_btnEmployee;
		private TableLayoutPanel tableLayoutPanel1;
		private Panel panel2;
		private Button Relout_btn;
		private TabControl tabControl1;
		private TabPage tabPage1;
		private TabPage tabPage2;
		private TableLayoutPanel tableLayoutPanel2;
		private DataGridView dataGridViewUsers;
		private Panel panel3;
		private Button button1;
		private TextBox textBoxLoginUser;
		private Label label4;
		private TextBox textBoxNameUser;
		private Button Locate_brn_User;
		private Label label6;
		private TextBox textBoxID;
		private Button DeleteEmployeeBtn;
		private Label label3;
		private TextBox UserIdTB;
		private Button DeleteUsersBtn;
		private Label label7;
	}
}
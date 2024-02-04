using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Coursework_3
{
	public partial class Users_Form : Form
	{

		public Users_Form()
		{
			InitializeComponent();
			Function_Loading_Database_Employee();
			Function_Loading_Database_User();
		}

		static BD_Connection db = new BD_Connection();
		static DataTable dataTable;
		static SqlDataAdapter adapter;
		static SqlCommand command;

		private void Function_Loading_Database_Employee()
		{
			try
			{
				//dataGridViewEmployee.Rows.Clear();
				db.OpenConnection();
					command = new SqlCommand("Select * From Employee", db.getConnection());
					command.ExecuteNonQuery();
					dataTable = new DataTable();
		
					adapter = new SqlDataAdapter(command);
					adapter.Fill(dataTable);

				db.CloseConnection();
				
				//dataTable.Columns.Add(new DataColumn("Delate", typeof(DataGridViewButtonColumn)));
				dataGridViewEmployee.DataSource = dataTable;
				/*
					Установка ширины 0 столба в 30 единиц.
					И установка содержимого в центр ячейки.
				*/
				this.dataGridViewEmployee.Columns[0].Width = 30;
				this.dataGridViewEmployee.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void Function_Loading_Database_User()
		{
			try
			{
				//dataGridViewUsers.Rows.Clear();
				db.OpenConnection();
				command = new SqlCommand("Select * From User", db.getConnection());
				command.ExecuteNonQuery();
				dataTable = new DataTable();

				adapter = new SqlDataAdapter(command);
				adapter.Fill(dataTable);

				db.CloseConnection();

				//dataTable.Columns.Add(new DataColumn("Delate", typeof(DataGridViewButtonColumn)));
				dataGridViewUsers.DataSource = dataTable;
				/*
					Установка ширины 0 столба в 25 единиц.
					И установка содержимого в центр ячейки.
				*/
				this.dataGridViewUsers.Columns[0].Width = 25;
				this.dataGridViewUsers.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		//Добавляете метод, который будет заполнять элементы управления
		// данными из reader
		public void ClickHandler(int RowIndex)
		{
			int id = Convert.ToInt32(dataGridViewEmployee[1, RowIndex].Value.ToString());
			
			Console.WriteLine("ClickHandler {1}", id);

			db.OpenConnection();
				command.Parameters.Add("@id", SqlDbType.Int).Value = id;
				command = new SqlCommand("DELETE FROM Users WHERE id = @id", db.getConnection());
			db.CloseConnection();

			Function_Loading_Database_Employee();
			Function_Loading_Database_User();
		}
		private void Update_btn_Click(object sender, EventArgs e)
		{
			Function_Loading_Database_Employee();
			Function_Loading_Database_User();
		}
		private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{
			if (e.ColumnIndex == 0)
				ClickHandler(e.RowIndex);
		}

		private void Locate_btnEmployee_Click(object sender, EventArgs e)
		{
			if (textBoxLoginEmployee.Text != "")
			{
				db.OpenConnection();
				//Console.WriteLine("TextBoxLogin NULL");
				command = new SqlCommand("SELECT * FROM Employee WHERE Login = @LoginUser", db.getConnection());
				command.Parameters.Add("@LoginUser", SqlDbType.VarChar).Value = textBoxLoginEmployee.Text;
				command.ExecuteNonQuery();
				db.CloseConnection();

				dataTable = new DataTable();
				adapter = new SqlDataAdapter(command);
				adapter.Fill(dataTable);

				/*dataGridViewEmployee.DataSource = dataTable;
				
				this.dataGridViewEmployee.Columns[0].Width = 30;
				this.dataGridViewEmployee.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

				if (dataGridViewEmployee.Columns.Count <= 4)
				{
					dataGridViewEmployee.Columns.Add(new DataGridViewButtonColumn()
					{
						Text = "Say Hi",
						UseColumnTextForButtonValue = true,
						AutoSizeMode = DataGridViewAutoSizeColumnMode.None
					});
				}*/
			}
			else if(textBoxNameEmployee.Text != "")
			{

				db.OpenConnection();
				command = new SqlCommand("SELECT * FROM Employee WHERE Name = @NameUser", db.getConnection());
				command.Parameters.Add("@NameUser", SqlDbType.VarChar).Value = textBoxLoginEmployee.Text;
				command.ExecuteNonQuery();
				db.CloseConnection();

				dataTable = new DataTable();
				adapter = new SqlDataAdapter(command);
				adapter.Fill(dataTable);

				/*dataGridViewEmployee.DataSource = dataTable;
				
				this.dataGridViewEmployee.Columns[0].Width = 30;
				this.dataGridViewEmployee.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

				if (dataGridViewEmployee.Columns.Count <= 4)
				{
					dataGridViewEmployee.Columns.Add(new DataGridViewButtonColumn()
					{
						Text = "Say Hi",
						UseColumnTextForButtonValue = true,
						AutoSizeMode = DataGridViewAutoSizeColumnMode.None
					});
				}*/
			}
			else
				Console.WriteLine("Заполните хотя бы 1 поле для поиска.");

			//dataGridViewEmployee.Rows.Clear();
			dataGridViewEmployee.DataSource = dataTable;

			this.dataGridViewEmployee.Columns[0].Width = 30;
			this.dataGridViewEmployee.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
		}

		private void Locate_brn_User_Click(object sender, EventArgs e)
		{
			if (textBoxLoginEmployee.Text != "")
			{
				//Console.WriteLine("TextBoxLogin NULL");
				db.OpenConnection();
				command = new SqlCommand("SELECT * FROM User WHERE Login = @LoginUser", db.getConnection());
				command.Parameters.Add("@LoginUser", SqlDbType.VarChar).Value = textBoxLoginEmployee.Text;
				command.ExecuteNonQuery();
				db.CloseConnection();

				dataTable = new DataTable();
				adapter = new SqlDataAdapter(command);
				adapter.Fill(dataTable);

				/*dataGridViewEmployee.DataSource = dataTable;
				
				this.dataGridViewEmployee.Columns[0].Width = 30;
				this.dataGridViewEmployee.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

				if (dataGridViewEmployee.Columns.Count <= 4)
				{
					dataGridViewEmployee.Columns.Add(new DataGridViewButtonColumn()
					{
						Text = "Say Hi",
						UseColumnTextForButtonValue = true,
						AutoSizeMode = DataGridViewAutoSizeColumnMode.None
					});
				}*/
			}
			else if (textBoxNameEmployee.Text != "")
			{
				//Console.WriteLine("TextBoxName NULL");

				db.OpenConnection();
				command = new SqlCommand("SELECT * FROM User WHERE Login = @NameUser", db.getConnection());
				command.Parameters.Add("@NameUser", SqlDbType.VarChar).Value = textBoxLoginEmployee.Text;
				command.ExecuteNonQuery();
				db.CloseConnection();

				dataTable = new DataTable();
				adapter = new SqlDataAdapter(command);
				adapter.Fill(dataTable);

				/*dataGridViewEmployee.DataSource = dataTable;
			
				this.dataGridViewEmployee.Columns[0].Width = 30;
				this.dataGridViewEmployee.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

				if (dataGridViewEmployee.Columns.Count <= 4)
				{
					dataGridViewEmployee.Columns.Add(new DataGridViewButtonColumn()
					{
						Text = "Say Hi",
						UseColumnTextForButtonValue = true,
						AutoSizeMode = DataGridViewAutoSizeColumnMode.None
					});
				}*/
			}
			else
				Console.WriteLine("Заполните хотя бы 1 поле для поиска.");

			dataGridViewUsers.Rows.Clear();
			dataGridViewEmployee.DataSource = dataTable;
			/*
				Установка ширины 0 столба в 30 единиц.
				И установка содержимого в центр ячейки.
			*/
			this.dataGridViewEmployee.Columns[0].Width = 30;
			this.dataGridViewEmployee.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

		}

		private void textBox_TextChanged(object sender, EventArgs e)
		{
			Function_Loading_Database_User();
			Function_Loading_Database_Employee(); ;
		}

		private void DeleteEmployeeBtn_Click(object sender, EventArgs e)
		{
			if (textBoxID.Text == "")
			{
				MessageBox.Show("Поле id не заполнено.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			db.OpenConnection();
			command = new SqlCommand("DELETE FROM Employee WHERE id = @idDele", db.getConnection());
			command.Parameters.Add("@idDele", SqlDbType.VarChar).Value = textBoxID.Text;
			command.ExecuteNonQuery();
			dataTable = new DataTable();

			adapter = new SqlDataAdapter(command);
			adapter.Fill(dataTable);

			db.CloseConnection();

			Function_Loading_Database_Employee();
		}

		private void DeleteUsersBtn_Click(object sender, EventArgs e)
		{
			if (UserIdTB.Text == "")
			{
				MessageBox.Show("Поле id не заполнено.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			db.OpenConnection();
			command = new SqlCommand("DELETE FROM Users WHERE id = @idDele", db.getConnection());
			command.Parameters.Add("@idDele", SqlDbType.VarChar).Value = UserIdTB.Text;
			command.ExecuteNonQuery();
			dataTable = new DataTable();

			adapter = new SqlDataAdapter(command);
			adapter.Fill(dataTable);

			db.CloseConnection();

			Function_Loading_Database_User();
		}



		/*private void DeletionBar()
		{
			dataGridView1.DataSource = dataTable;
			/*
				Установка ширины 0 столба в 30 единиц.
				И установка содержимого в центр ячейки.
			/*
			this.dataGridView1.Columns[0].Width = 30;
			this.dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

			if (dataGridView1.Columns.Count <= 4)
			{
				dataGridView1.Columns.Add(new DataGridViewButtonColumn()
				{
					Text = "Say Hi",
					UseColumnTextForButtonValue = true,
					AutoSizeMode = DataGridViewAutoSizeColumnMode.None
				});
			}
		}*/

		/*==========================================================================*/

		/*
		 public MySqlRepository()
    { }

    private MySqlConnection GetConnection()
    {
        var cs = ConfigurationManager.ConnectionStrings["MySqlConn"].ToString();
        var builder = new MySqlConnectionStringBuilder(cs);
        //чтоб избежать проблем с русским языком
        builder.CharacterSet = "utf8";
        return new MySqlConnection(builder.ConnectionString);
    }

    public async Task<Result<List<Employee>>> GetEmployees()
    {
        var list = new List<Employee>();

        try
        {
            using (var con = GetConnection())
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "SELECT * FROM employees";
                con.Open();
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var emp = new Employee(reader.GetInt32(0));
                        emp.FirstName = reader.GetString(1);
                        emp.LastName = reader.GetString(2);
                        emp.Phone = reader.GetString(3);

                        list.Add(emp);
                    }
                }
            }

        }
        catch (MySqlException ex)
        {
            return new Result<List<Employee>>(GetUserFriendlyErrorMessage(ex));
        }
        catch (Exception ex)
        {
            return new Result<List<Employee>>(ex.Message);
        }

        return new Result<List<Employee>>(list);
    }

    public async Task<Result<int>> AddEmployee(Employee employee)
    {
        if (employee is null)
            throw new ArgumentNullException(nameof(employee));
        if (String.IsNullOrWhiteSpace(employee.FirstName)
            || String.IsNullOrEmpty(employee.FirstName))
        {
            return new Result<int>("Введите имя сотрудника.");
        }
        if (String.IsNullOrWhiteSpace(employee.LastName)
            || String.IsNullOrEmpty(employee.LastName))
        {
            return new Result<int>("Введите фамилию сотрудника.");
        }

        int result = 0;
        try
        {
            using (var con = GetConnection())
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "INSERT INTO employees (first_name, last_name, phone)" +
                    " VALUES(@firstName, @lastName, @phone)";

                cmd.Parameters.Add(new MySqlParameter("@firstName", MySqlDbType.VarChar, 200)
                { Value = employee.FirstName });

                cmd.Parameters.Add(new MySqlParameter("@lastName", MySqlDbType.VarChar, 300)
                { Value = employee.LastName });

                cmd.Parameters.Add(new MySqlParameter("@phone", MySqlDbType.VarChar, 45)
                {
                    Value = employee.Phone ?? (object)System.DBNull.Value
                });

                con.Open();
                result = await cmd.ExecuteNonQueryAsync();
            }

        }
        catch (MySqlException ex)
        {
            return new Result<int>(GetUserFriendlyErrorMessage(ex));
        }
        catch (Exception ex)
        {
            return new Result<int>(ex.Message);
        }

        return new Result<int>(result);
    }

    public async Task<Result<int>> RemoveEmployee(int id)
    {
        if (id <= 0)
            throw new ArgumentException(nameof(id));

        int result = 0;
        try
        {
            using (var con = GetConnection())
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "DELETE FROM employees WHERE id =@id";

                cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32)
                { Value = id });

                con.Open();
                result = await cmd.ExecuteNonQueryAsync();
            }

        }
        catch (MySqlException ex)
        {
            return new Result<int>(GetUserFriendlyErrorMessage(ex));
        }
        catch (Exception ex)
        {
            return new Result<int>(ex.Message);
        }

        return new Result<int>(result);
    }

    public async Task<Result<int>> UpdateEmployee(Employee employee)
    {
        if (employee is null)
            throw new ArgumentNullException(nameof(employee));
        if (String.IsNullOrWhiteSpace(employee.FirstName)
            || String.IsNullOrEmpty(employee.FirstName))
        {
            return new Result<int>("Введите имя сотрудника.");
        }
        if (String.IsNullOrWhiteSpace(employee.LastName)
            || String.IsNullOrEmpty(employee.LastName))
        {
            return new Result<int>("Введите фамилию сотрудника.");
        }

        int result = 0;
        try
        {
            using (var con = GetConnection())
            using (var cmd = con.CreateCommand())
            {
                cmd.CommandText = "UPDATE employees" +
                    " SET first_name = @firstName, last_name = @lastName, phone = @phone" +
                    " WHERE id =@id";

                cmd.Parameters.Add(new MySqlParameter("@firstName", MySqlDbType.VarChar, 200)
                { Value = employee.FirstName });

                cmd.Parameters.Add(new MySqlParameter("@lastName", MySqlDbType.VarChar, 300)
                { Value = employee.LastName });

                cmd.Parameters.Add(new MySqlParameter("@phone", MySqlDbType.VarChar, 45)
                {
                    Value = employee.Phone ?? (object)System.DBNull.Value
                });

                cmd.Parameters.Add(new MySqlParameter("@id", MySqlDbType.Int32)
                { Value = employee.Id });

                con.Open();
                result = await cmd.ExecuteNonQueryAsync();
            }

        }
        catch (MySqlException ex)
        {
            return new Result<int>(GetUserFriendlyErrorMessage(ex));
        }
        catch (Exception ex)
        {
            return new Result<int>(ex.Message);
        }

        return new Result<int>(result);
    }

    private string GetUserFriendlyErrorMessage(MySqlException ex)
    {
        var message = String.Empty;
        switch (ex.Number)
        {
            case 0:
                if (ex.InnerException.Message.Contains("Unknown"))
                {
                    message = "Неверное название схемы или таблицы.";
                }
                else if (ex.InnerException.Message.Contains("Access"))
                {
                    message = "Неверное имя или пароль доступа.";
                }
                else
                {
                    message = ex.Message;
                }
                break;
            case 1042:
                message = "Сервер по указанному адресу не доступен." +
                    "\nОшибка ожидания.";
                break;
            case 1045:
                message = "Неверное имя пользователя или пароль, " +
                    "\nпожалуйста, попробуйте еще раз.";
                break;
            default:
                message = ex.Message;
                break;
        }
        return message;
    }
		 */

	}
}

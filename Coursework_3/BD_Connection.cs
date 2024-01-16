using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Coursework_3
{
	internal class BD_Connection
	{

		private SqlConnection connection = new SqlConnection("Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\Patrick\\Documents\\BDCoursework.mdf;" +
				"Integrated Security=True;Connect Timeout=30;Encrypt=False");

		public void OpenConnection()
		{
			if (connection.State == System.Data.ConnectionState.Closed)
				connection.Open();
		}
		public void CloseConnection()
		{
			if (connection.State == System.Data.ConnectionState.Open)
				connection.Close();
		}
		public SqlConnection getConnection()
		{
			return connection;
		}


		/*
		private SqlConnection Connection = new SqlConnection("server=localhost;port=3306;username=User;password=User;database=BDCoursework");
		private SqlConnection Connection_adm = new SqlConnection("server=localhost;port=3306;username=ADMIN_BD;password=123;database=BDCoursework");

		public void OpenConnection()
		{
			if (Connection.State == System.Data.ConnectionState.Closed)
				Connection.Open();
		}
		public void CloseConnection()
		{
			if (Connection.State == System.Data.ConnectionState.Open)
				Connection.Close();
		}
		public SqlConnection getConnection()
		{
			return Connection;
		}


		public void OpenConnectionAdm()
		{
			if (Connection_adm.State == System.Data.ConnectionState.Closed)
				Connection_adm.Open();
		}
		public void CloseConnectionAdm()
		{
			if (Connection_adm.State == System.Data.ConnectionState.Open)
				Connection_adm.Close();
		}
		public SqlConnection getConnectionAdm()
		{
			return Connection_adm;
		}*/
	}
}

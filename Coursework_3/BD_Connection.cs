using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Coursework_3
{
	internal class BD_Connection
	{

		/*static string datasource = "127.0.0.1";
		static string database = "BDCoursework";
		static string port = "3306";

		static string usernameU = "User";
		static string passwordU = "User";

		static string usernameA = "ADMIN";
		static string passwordA = "123";

		static string ConnectionString = $"datasource={ datasource };port={ port };username={ usernameU };password={ passwordU };database={ database }";
		static string query = "Select * From User";

		MySqlCommand commandDatabase = new MySqlCommand(query, ConnectionString);
		commandDatabase.CommandTimeout = 60;
		MySqlDataReader reader;*/




		private MySqlConnection Connection = new MySqlConnection("server=localhost;port=3306;username=User;password=User;database=BDCoursework");
		private MySqlConnection Connection_adm = new MySqlConnection("server=localhost;port=3306;username=ADMIN_BD;password=123;database=BDCoursework");
		
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
		public MySqlConnection getConnection()
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
		public MySqlConnection getConnectionAdm()
		{
			return Connection_adm;
		}
	}
}

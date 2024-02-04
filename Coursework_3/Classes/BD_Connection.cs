using System.Data.SqlClient;
using System.Configuration;
using System.Data.Common;
using System.Data.Entity;

namespace Coursework_3
{
	internal class BD_Connection 
	{
		//protected BD_Connection() : base("DBConnsectionString") { }



		
		//static string BDConnect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Prodgect\\CourseWork_3_courses\\Coursework_3\\Coursework_3\\bin\\Debug\\Databases\\BDCoursework.mdf;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
		//private static string BDConnect = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Prodgect\\CourseWork_3_courses\\Coursework_3\\Coursework_3\\bin\\Debug\\Databases\\BDCoursework.mdf;Integrated Security=True;Connect Timeout=30";
		static public SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["DBConnsectionString"].ConnectionString);

		public void OpenConnection()
		{
			if (sqlConnection.State == System.Data.ConnectionState.Closed)
				sqlConnection.Open();
		}
		public void CloseConnection()
		{
			if (sqlConnection.State == System.Data.ConnectionState.Open)
				sqlConnection.Close();
		}
		public SqlConnection getConnection()
		{
			return sqlConnection;
		}
		
		//static public SqlConnection sqlConnection = new SqlConnection(ConfigurationManager.ConnectionStrings["StringBD"].ConnectionString);

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

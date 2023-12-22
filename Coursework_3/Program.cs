using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework_3
{
	internal static class Program
	{
		/// <summary>
		/// Главная точка входа для приложения.
		/// </summary>
		[STAThread]
		static void Main()
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new StartForm());
		}
	}
}

/*using System;
using System.Collections.Generic;
using MySql.Data.MySqlClient;
using System.Threading;

namespace RetryAdo2
{

	public class Program
	{
		public static int Main(string[] args)
		{
			bool succeeded = false;
			const int totalNumberOfTimesToTry = 4;
			int retryIntervalSeconds = 10;

			for (int tries = 1; tries <= totalNumberOfTimesToTry; tries++)
			{
				try
				{
					if (tries > 1)
					{
						Console.WriteLine(
							"Transient error encountered. Will begin attempt number {0} of {1} max...",
							tries,
							totalNumberOfTimesToTry
						);
						Thread.Sleep(1000 * retryIntervalSeconds);
						retryIntervalSeconds = Convert.ToInt32(retryIntervalSeconds * 1.5);
					}
					AccessDatabase();
					succeeded = true;
					break;
				}
				catch (SqlException sqlExc)
				{
					if (TransientErrorNumbers.Contains(sqlExc.Number))
					{
						Console.WriteLine("{0}: transient occurred.", sqlExc.Number);
						continue;
					}

					Console.WriteLine(sqlExc);
					succeeded = false;
					break;
				}
				catch (TestSqlException sqlExc)
				{
					if (TransientErrorNumbers.Contains(sqlExc.Number))
					{
						Console.WriteLine("{0}: transient occurred. (TESTING.)", sqlExc.Number);
						continue;
					}

					Console.WriteLine(sqlExc);
					succeeded = false;
					break;
				}
				catch (Exception e)
				{
					Console.WriteLine(e);
					succeeded = false;
					break;
				}
			}

			if (!succeeded)
			{
				Console.WriteLine("ERROR: Unable to access the database!");
				return 1;
			}
			return 0;
		}
	}


	/// <summary>
	/// Connects to the database, reads,
	/// prints results to the console.
	/// </summary>
	static void AccessDatabase()
	{
		//throw new TestSqlException(4060); //(7654321);  // Uncomment for testing.

		using var sqlConnection = new MySqlConnection(GetSqlConnectionString());

		using var dbCommand = sqlConnection.CreateCommand();

		dbCommand.CommandText =
			@"  
				SELECT TOP 3  
				ob.name,  
				CAST(ob.object_id as nvarchar(32)) as [object_id]  
				FROM sys.objects as ob  
				WHERE ob.type='IT'  
				ORDER BY ob.name;";

		sqlConnection.Open();
		var dataReader = dbCommand.ExecuteReader();

		while (dataReader.Read())
		{
			Console.WriteLine(
				"{0}\t{1}",
				dataReader.GetString(0),
				dataReader.GetString(1));
		}
	}

	/// <summary>
	/// You must edit the four 'my' string values.
	/// </summary>
	/// <returns>An ADO.NET connection string.</returns>
	static private string GetSqlConnectionString()
	{
		// Prepare the connection string to Azure SQL Database.
		var sqlConnectionSB = new MySqlConnectionStringBuilder
		{
			// Change these values to your values.
			DataSource = "tcp:myazuresqldbserver.database.windows.net,1433", //["Server"]
			InitialCatalog = "MyDatabase",                                       //["Database"]
			UserID = "MyLogin",                                          // "@yourservername"  as suffix sometimes.
			Password = "MyPassword",
			// Adjust these values if you like. (ADO.NET 4.5.1 or later.)
			ConnectRetryCount = 3,
			ConnectRetryInterval = 10, // Seconds.
									   // Leave these values as they are.
			IntegratedSecurity = false,
			Encrypt = true,
			ConnectTimeout = 30
		};

		return sqlConnectionSB.ToString();
	}

	static List<int> TransientErrorNumbers = new()
		{
			4060, 40197, 40501, 40613, 49918, 49919, 49920, 11001
		};


	/// <summary>
	/// For testing retry logic, you can have method
	/// AccessDatabase start by throwing a new
	/// TestSqlException with a Number that does
	/// or does not match a transient error number
	/// present in TransientErrorNumbers.
	/// </summary>
	internal class TestSqlException : ApplicationException
	{
		internal TestSqlException(int testErrorNumber)
		{
			Number = testErrorNumber;
		}

		internal int Number { get; set; }
	}
}
*/

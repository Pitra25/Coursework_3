/*using System;
using System.Collections.Generic;
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
}*/

/*
 * Нужна 10 версия c#
 */


using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Threading;

namespace Coursework_3
{
    public class Program
    {
        public static int Main(string[] args)
        {
            bool succeeded = false;
            const int totalNumberOfTimesToTry = 4;
            int retryIntervalSeconds    = 10;

            for (int tries = 1; tries <= totalNumberOfTimesToTry; tries++)
            {
                try
                {
                    if (tries > 1)
                    {
                        Console.WriteLine(
							"Возникла переходная ошибка. Начнется попытка номер {0} из {1} макс....",
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
                catch (SqlException sqlExc) {
                    if (TransientErrorNumbers.Contains(sqlExc.Number))
                    {
                        Console.WriteLine("{0}: произошел переход.", sqlExc.Number);
                        continue;
                    }

                    Console.WriteLine(sqlExc);
                    succeeded = false;
                    break;
                }
                catch (TestSqlException sqlExc) {
                    if (TransientErrorNumbers.Contains(sqlExc.Number))
                    {
                        Console.WriteLine("{0}: произошел переходный процесс. (ТЕСТИРОВАНИЕ.)", sqlExc.Number);
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

            if (!succeeded) {
                Console.WriteLine("ОШИБКА: Невозможно получить доступ к базе данных!");
                return 1;
            }

            return 0;
        }

		/// <summary>
		/// Подключается к базе данных, считывает,
		/// печатает результаты в консоль.
		/// </summary>
		static void AccessDatabase() {
			//throw new TestSqlException(4060); //(7654321); // Снимите комментарий для тестирования.

			var sqlConnection = new SqlConnection(GetSqlConnectionString());

            var dbCommand = sqlConnection.CreateCommand();

            dbCommand.CommandText =
                @" SELECT TOP 3  
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
                    dataReader.GetString(1)
                );
            }
        }

		/// <summary>
		/// Вы должны отредактировать четыре значения строки.
		/// </summary>
		/// <returns>An ADO.NET connection string.</returns>
		static private string GetSqlConnectionString()
        {
			// Подготовьте строку подключения к Azure SQL Database.
			var sqlConnectionSB = new SqlConnectionStringBuilder 
            {
				// Измените эти значения на свои.
				DataSource           = "tcp:myazuresqldbserver.database.windows.net,1433", //["Server"]
                InitialCatalog       = "MyDatabase",                                       //["Database"]
                UserID               = "MyLogin",                                          // "@yourservername"  as suffix sometimes.
                Password             = "MyPassword",
				// Настройте эти значения по своему усмотрению. (ADO.NET 4.5.1 или более поздняя версия).
				ConnectRetryCount = 3,
                ConnectRetryInterval = 10, // Seconds.
                // Оставьте эти значения как есть.
				IntegratedSecurity = false,
                Encrypt            = true,
                ConnectTimeout     = 30
            };

            return sqlConnectionSB.ToString();
        }

        static List<int> TransientErrorNumbers = new() 
        {
            4060, 40197, 40501, 40613, 49918, 49919, 49920, 11001
        };
    }


	/// <summary>
	/// Для тестирования логики повторных попыток можно использовать метод
	/// AccessDatabase начинался с выброса нового
	/// TestSqlException с номером, который совпадает
	/// или не совпадает с номером переходной ошибки
	/// присутствующим в TransientErrorNumbers.
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
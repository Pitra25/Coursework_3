using System;
using System.IO;

namespace Coursework_3.Classes
{
	internal class JournalRecordsHistory
	{
		public async void LogWriter(string TextToLog, string LogType = "global")
		{ 
            string pathGlobal = "D:\\Prodgect\\CourseWork_3_courses\\Coursework_3\\Coursework_3\\Logs\\GLobal.log";
			string pathBD = "D:\\Prodgect\\CourseWork_3_courses\\Coursework_3\\Coursework_3\\Logs\\BD.log";

            //string pathGlobal = "D:\\Coursework\\Coursework_3\\Coursework_3\\Logs\\GLobal.log";
            //string pathBD = "D:\\Coursework\\Coursework_3\\Coursework_3\\Logs\\BD.log";

            if (LogType == "global")
			{
				using (StreamWriter stream = new StreamWriter(pathGlobal, true)) { 
					await stream.WriteAsync(TextToLog);
				}

			}
			else if (LogType == "BD")
			{
                using (StreamWriter stream = new StreamWriter(pathBD, true)){
                    await stream.WriteAsync(TextToLog);
                }
            }
		}
        public void printCons<T>(T content) =>
            Console.WriteLine(Convert.ToString(content));
       // public void printMessage<T>(T content) =>
       //     MessageBox.Show(Convert.ToString(content));
    }
}

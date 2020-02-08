using System;
using System.Collections.Generic;
using System.IO;

namespace OopAssignment
{
    public static class LogClass
    {
        public static List<ErrorLog> errorLog = new List<ErrorLog>();
        public static string filePath = @"D:\Programming\Refactory\OOPAssignment\OopAssignment\app.log";
        public static void SaveAllErrorLog()
        {
            var lines = new List<string>();
            lines.Add("Date, Message");

            foreach(var e in errorLog)
            {
                lines.Add($"{e.Date},{e.Message}");
            }
            File.WriteAllLines(filePath, lines);
        }

    public static void PopulateErrorLog()
        {
            DateTime date = DateTime.Now;
            errorLog.Add(new ErrorLog { Date = date, Message = "Contoh Error 1" });
            errorLog.Add(new ErrorLog { Date = date, Message = "Contoh Error 2" });
            errorLog.Add(new ErrorLog { Date = date, Message = "Contoh Error 3" });
            errorLog.Add(new ErrorLog { Date = date, Message = "Contoh Error 4" });
            errorLog.Add(new ErrorLog { Date = date, Message = "Contoh Error 5" });
        }
    }
    public class ErrorLog : IErrorLog
    {
        public DateTime Date { get; set; }
        public string Message { get; set; }
    }
    
}

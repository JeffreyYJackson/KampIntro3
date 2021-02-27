using System;

namespace OOP3
{
    public class DataBaseLoggerService:ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına Logandı");
        }
    }
}
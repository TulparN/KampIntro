using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SmsLoggerServices : ILoggerServices
    {
        public void Log()
        {
            Console.WriteLine("Sms Yollandı !");
        }
    }
}

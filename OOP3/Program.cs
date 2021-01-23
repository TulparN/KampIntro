using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        //interfacelerde o implemente edilen sınıfın referansını tutabiliyor
        static void Main(string[] args)
        {
            ICreditManager ihtiyacCreditManager = new IhtiyacCreditManager();
            //ihtiyacCreditManager.Calc();

            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            //vehicleCreditManager.Calc();

            ICreditManager konutCreditManager = new KonutCreditManager();
            //konutCreditManager.Calc();

            ILoggerServices dataBaseLoggerServices = new DatabaseLoggerServices();
            ILoggerServices fileLoggerServices = new FileLoggerServices();

            List<ILoggerServices> loggers = new List<ILoggerServices> {new SmsLoggerServices(), new DatabaseLoggerServices() };

            BasvuruManager basvuru = new BasvuruManager();
            basvuru.BasvuruYap(new EsnafCreditManager(), loggers ); //new DataBaseLoggerservices şeklinde de kullanılabilir

            List<ICreditManager> credits = new List<ICreditManager>() {ihtiyacCreditManager, konutCreditManager,vehicleCreditManager };

            //basvuru.CreditFirstInfo(credits);

            Console.ReadLine();
        }
    }
}

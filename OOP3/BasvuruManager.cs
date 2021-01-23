using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //method injection
    class BasvuruManager
    {
        public void BasvuruYap(ICreditManager creditManager, List<ILoggerServices> loggerServices )
        {
            //Başvuru bilgilerini değerlendirme
            //
            //
            creditManager.Calc();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }

        public void CreditFirstInfo(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
               
                credit.Calc();
            }
        }
    }
}

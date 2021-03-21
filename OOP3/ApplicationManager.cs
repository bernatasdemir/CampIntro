using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        //Method injection
        public void MakeApplication(ICreditManager creditManager, List<ILoggerService>loggerServices)
        {
            //public void MakeApplication(ICreditManager creditManager, ILoggerService loggerService)
            //tek bir tane log olsaydı böyle yapılırdı. Ama birden fazla istedigimde liste olusturulur.
            //Başvuran bilgilerini değerlendirme yapılır
            creditManager.Calculate();
            foreach (var loggerService   in loggerServices)
            {
                loggerService.Log();
            }
            

        }
        public void MakeCreditPreinformation(List<ICreditManager> credits)
        {
            foreach (var credi in credits)
            {
                credi.Calculate();
            }

        }
    }
}

using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)

        {
            //Interfaceler de o interfacei implement eden clasın referans numarasını tutabilri.

            //PersonalFinanceCreditManeger personalFinanceCreditManeger = new PersonalFinanceCreditManeger();
            //personalFinanceCreditManeger.Calculate();

            //TransportCreditManager transportCreditManager = new TransportCreditManager();
            //transportCreditManager.Calculate();

            //MortgageLoanManager mortgageLoanManager = new MortgageLoanManager();
            //mortgageLoanManager.Calculate();

            ICreditManager personalFinanceCreditManager = new PersonalFinanceCreditManager();
            ICreditManager transportCreditManager = new TransportCreditManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLoggerServise = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.MakeApplication(mortgageLoanManager, 
                new List<ILoggerService> { new DatabaseLoggerService(), new SmsLoggerService() });



            // applicationManager.MakeApplication(mortgageLoanManager,new DatabaseLoggerService() );
            // ya da bu işlemi parantez içinde newleyerek yaparsın ya da bu şekilde aynu ikisi de
            // ILoggerService databaseLoggerService = new DatabaseLoggerService();
            // ILoggerService fileLoggerServise = new FileLoggerService();
            // applicationManager.MakeApplication(mortgageLoanManager,databaseLoggerService );


            List<ICreditManager> credits = new List<ICreditManager>() {personalFinanceCreditManager, transportCreditManager };
            // applicationManager.MakeCreditPreinformation(credits);
          
        }

        
    }
}

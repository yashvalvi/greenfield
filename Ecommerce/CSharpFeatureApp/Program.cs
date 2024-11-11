using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatureApp
{
    internal class Program
    {
        static void Main(string[] args)
        {//compile time, early binding ,
         //  Handler.PayGST();
         //register method with delegate instance
         ////   Operation opn1 = new Operation(Handler.PayServiceTax);
         // Operation opn2 = new Operation(Handler.PayIncomeTax);
         // Operation opn3 = new Operation(Handler.PayGST);
         //
         // Operation masterOperation = null;
         //
         // masterOperation += opn1;
         // masterOperation+= opn2;
         // masterOperation += opn3;
         // //opn1.nvoke(30);
         // //opn1.nvoke(30);
         // //opn1.nvoke(30);
         // masterOperation.Invoke(56);
         // Console.WriteLine("After detachment");
         // masterOperation -= opn3;
         // masterOperation.Invoke(56);
         // Console.ReadLine();
         //object creation
            Account acct = new Account(15000);
            //Event registration
            acct.underBalance += PenaltyHandler.ServiceDisconnectionPenalty;
            acct.underBalance += PenaltyHandler.NotificationPenaltyCharges;
            //object invocation
            acct.Withdraw(8000);
            acct.overBalance += TaxHandler.PayServiceTax;
            acct.overBalance -= TaxHandler.PayProfessionalTax;
            acct.overBalance += TaxHandler.PayIncomeTax;
            acct.overBalance += TaxHandler.PayGST;
            acct.Deposit(5000000);
            Console.ReadLine();

            
































        }
    }
}

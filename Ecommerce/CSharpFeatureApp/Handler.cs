using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFeatureApp
{
    public delegate void Operation(float factor);
    public static class TaxHandler

    {
        public static void PayIncomeTax(float factor)
        {
            Console.WriteLine("Income tax "+factor+"is deducted from your account");


        }

        public static void PayProfessionalTax(float factor)
        {
            Console.WriteLine("Income tax "+factor+" is deducted from your account");
        }
        public static void PayGST(float factor)
        {
            Console.WriteLine("GST tax "+factor+"is deducted from your account");
        }
        public static void PayServiceTax(float factor)
        {
            Console.WriteLine("Income tax "+factor+" is deducted from your account");
        }

    }
    public static class PenaltyHandler
    {
        public static void ServiceDisconnectionPenalty(float amount)
        {
            Console.WriteLine("Disconnection charges Applied=" + amount);
        }
        public static void NotificationPenaltyCharges(float amount)
        {
            Console.WriteLine("Notification charges Applied=" + amount);
        }
    }
}
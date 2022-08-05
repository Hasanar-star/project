using System;
namespace Studytonight
{
    public class Interest
    {
        // interest for 1 year of tenure
        public double TrueBank(double amount, double rate)
        {
            return amount + (amount * rate);
        }
        public double TrueBank(double amount, double rate, string holdertype)
        {
            return amount + (amount * rate) + 2000;
        }
    }
    public class Program
    {
        public static void Main(string[] args)
        {
            Interest i = new Interest();

            double finalamount = i.TrueBank(5000.00, 0.1);
            Console.WriteLine("Normal interest for a holder " + finalamount);

            finalamount = i.TrueBank(5000.00, 0.1, "prime");
            Console.WriteLine("Prime interest for a holder " + finalamount);

        }
    }
}
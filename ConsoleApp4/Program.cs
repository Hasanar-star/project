using System;
public abstract class Bank
{
    public virtual void withdraw()
    {
        Console.WriteLine("Thank You. Bonus 200 added to your account");
    }
}

public class YesBank : Bank
{
    public override void withdraw()
    {
        Console.WriteLine("Withdrawn cash from YesBank");
        base.withdraw();
    }
}

public class NoBank : Bank
{
    public override void withdraw()
    {
        Console.WriteLine("Withdrawn cash from NoBank");
    }
}

namespace Studytonight
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Bank b = new YesBank();
            b.withdraw();
            b = new NoBank();
            b.withdraw();
        }
    }
}
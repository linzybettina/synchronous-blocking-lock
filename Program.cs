using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class Program
{
    decimal totalBalance = 50000;
    private Object myLock = new Object();

    static void Main(string[] args)
    {
        Program program = new Program();
        program.WithDraw(5000);
        Console.ReadKey();
    }

    public void WithDraw(decimal amount)
    {
        lock (myLock)
        {
            if (amount > totalBalance)
            {
                Console.WriteLine("Insufficient Amount.");
            }

            totalBalance -= amount;
            Console.WriteLine("Total Balance {0}", totalBalance);
        }
    }

}   

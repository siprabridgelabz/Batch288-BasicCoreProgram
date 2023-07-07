using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Programs");
            int n;
            Console.WriteLine("Choose a option 1-flipcoin, 2-LeadYear ,3-PowerOfTwo " +
                "4-Harmonic Number ,5-FactorofNumber,6-Division,7-Swap Two Number");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("The Flip coin Program");
                    FlipCoin f = new FlipCoin();
                    f.Display();
                    break;
                case 2:
                    Console.WriteLine("Lead Year");
                    LeapYear le = new LeapYear();
                    le.year();
                    break;
                case 3:
                    Console.WriteLine("Power of two Program");
                    Power power = new Power();
                    power.Poweroftwo();
                    break;
                case 4:
                    Console.WriteLine("Harmonic Series Program");
                    Harmonic h = new Harmonic();
                    h.Series();
                    break;
                case 5:
                    Console.WriteLine("FactorsofNumber Program");
                    Factors factors = new Factors();
                    factors.FactorOfnumber();
                    break;
                case 6:
                    Console.WriteLine("Division Program");
                    Division division = new Division();
                    division.Math(33, 2);
                    break;
                case 7:
                    Console.WriteLine("Swap two Number Program");
                    
                    SwapTwoNumber swap = new SwapTwoNumber();
                    swap.TwoNumbers(7, 2);
                    break;
                default:
                    Console.WriteLine("Entered Wrong choice");
                    break;
            }


            Console.ReadLine();
        }
    }
}

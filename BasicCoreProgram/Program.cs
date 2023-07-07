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
            Console.WriteLine("Enter your choice");
            Console.WriteLine("1-flipcoin");
            Console.WriteLine("2-LeadYear");
            Console.WriteLine("3-PowerOfTwo");
            Console.WriteLine("4-Harmonic Number");
            Console.WriteLine("5-FactorofNumber");
            Console.WriteLine("6-Division");
            Console.WriteLine("7-SwapingNumbers");
            Console.WriteLine("8-Even.Odd");
            Console.WriteLine("9-Alphabets");
            Console.WriteLine("\n");

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
                case 8:
                    Console.WriteLine("Even or Odd Number Program");

                    EvenOrOdd evenOrOdd = new EvenOrOdd();

                    evenOrOdd.Odd();
                    break;
                case 9:
                    Console.WriteLine("Consonants and vowels");
                   VowelAndConsonant vowelAndConsonant = new VowelAndConsonant();

                    vowelAndConsonant.Vowels();
                    break;
                default:
                    Console.WriteLine("Entered Wrong choice");
                    break;
            }


            Console.ReadLine();
        }
    }
}

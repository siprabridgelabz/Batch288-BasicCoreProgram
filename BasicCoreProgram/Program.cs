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

            Console.WriteLine("Choose a option 1-flipcoin ");
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    Console.WriteLine("The Flip coin Program");
                    FlipCoin f = new FlipCoin();
                    f.Display();
                    break;
                default:
                    Console.WriteLine("Entered Wrong choice");
                    break;
            }
            Console.ReadLine();
        }
    }
}

﻿using System;
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
            Console.WriteLine("Choose a option 1-flipcoin ,2-LeadYear,3-PowerOfTwo ");
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
                default:
                    Console.WriteLine("Entered Wrong choice");
                    break;
            }


            Console.ReadLine();
        }
    }
}

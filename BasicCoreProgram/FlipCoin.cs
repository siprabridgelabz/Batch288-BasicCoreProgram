using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class FlipCoin
    {
         
        public void Display()
        {
            Random r = new Random();
            int flip = r.Next(2);
            Console.WriteLine(flip);
            if (flip == 0)
            {
                Console.WriteLine("It's Head");
            }
            else
            {
                Console.WriteLine("It's Tail");
            }

        }
    }
}


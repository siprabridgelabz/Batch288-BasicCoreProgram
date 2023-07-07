using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCoreProgram
{
    public class Power
    {
        public void Poweroftwo()
        {
            int n, pw, i;
            for(i=0;i<=3;i++)
            {
                pw = 1;
                n= i;
                while(n>0)
                {
                    pw *= 2;
                    n--;
                }
                Console.WriteLine("2 to the" +i+"power is"+pw);
            }
        }
    }
}

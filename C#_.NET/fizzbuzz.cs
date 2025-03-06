using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__.NET
{
    internal class fizzbuzz
    {
     public fizzbuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                string printValue = string.Empty;
                printValue += (i % 3 == 0) ? "Fizz" : string.Empty;
                printValue += (i % 5 == 0) ? "Buzz" : string.Empty;
                if (printValue != string.Empty)
                    Console.WriteLine(printValue);
                else
                    Console.WriteLine(i);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_YP.Functions
{
    internal class Factorial
    {
         static int _digitalFactorual { get; set; }
         static int _factorial { get; set; }
        public Factorial(int digital)
        {
            _digitalFactorual = digital;
            int resultFactourial = 1;
            for (int i = 1; i <= digital; i++)
            {
                resultFactourial *= i;
            }
            _factorial = resultFactourial;
        }
        internal static void Display()
        {
            Console.WriteLine($"\nФакториал числа {_digitalFactorual} = {_factorial}");
        }
       

    }

}

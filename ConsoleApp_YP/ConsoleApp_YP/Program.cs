using System;
using ConsoleApp_YP.Functions;

namespace ConsoleApp_YP
{
    public class Program
    {
       static void Main(string[] args)
        {
            bool running = true;
            int variant;
            do
            {
                Console.WriteLine("Выберите функцию" +
                     "\n1.Факториал\n2.Логарифм");
                variant = Convert.ToInt32(Console.ReadLine());

                
                switch (variant)
                {
                    case 1:
                        {   
                            Console.WriteLine("Введите число для факторила");
                            int digital = Convert.ToInt32(Console.ReadLine());
                            Factorial factorial = new Factorial(digital);
                            Factorial.Display();
                            break;
                        }
                    default: {
                            Console.Clear();
                            running = false;
                            break;
                        }
                }
            } while (running);

        }
    }
}
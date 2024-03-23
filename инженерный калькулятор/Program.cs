using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace инженерный_калькулятор
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstvalue, twovalue;
            string operatorV;

            Console.WriteLine("Введите первое значение: ");
            firstvalue = Double.Parse(Console.ReadLine());

            Console.WriteLine("Введите второе значение: ");
            twovalue = Double.Parse(Console.ReadLine());

            Console.WriteLine("Выберите метод операции: | - | * | / |");
            operatorV = Console.ReadLine();

            switch (operatorV)
            {
                case "+":
                    Console.WriteLine(firstvalue + twovalue);
                    break;
                case "-":
                    Console.WriteLine(firstvalue - twovalue);
                    break;
                case "*":
                    Console.WriteLine(firstvalue - twovalue);
                    break;
                case "/":
                    if (firstvalue == 0)
                        Console.WriteLine(0);
                    else if (twovalue == 0)
                        Console.WriteLine(0);
                    else
                        Console.WriteLine(firstvalue / twovalue);
                        break;


                default:
                    Console.WriteLine("Неизвестная команда, повторите попытку!");
                    break;

            }
            Console.ReadKey();


        }
    }
}

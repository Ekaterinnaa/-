using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace инженерный_калькулятор
{
    class Program
    {
       
   }
    public class Program {
        {
        public static void Menu(Operation[] operations)
        {
            Console.WriteLine("Новая операция:");
            for (int i = 0; i < operations.Length; i++)
            {
                Operation operation = operations[i];
                Console.WriteLine($"{i + 1}. {operation.Name}");
            }
        }
        static void Main(string[] args) {
            try
            {
                Console.WriteLine("Вместо знака корень используйте # ");
                Console.WriteLine("Выберите необходимое количество чисел ");
                string a = (Console.ReadLine());
                string[] Nums = a.Split(new char[] { ' ' }); //Создоётся массив записывающий числа считывая через пробел
                double[] Wht = new double[Nums.Length];
                int gg = 0;
                foreach (string el in Nums) // Цикл перебора объектов в массиве
                {
                    Wht[gg] = Convert.ToDouble(el);
                    gg++;
                }
                
        public abstract class Operation
    {

        public abstract class Operation //шаблон операций
        {
            public abstract string Name { get; }

            public abstract double Run(params double[] numbers);
        }

        public class Addition : Operation
        {
            public override string Name => "Сложение";

            public override double Run(params double[] numbers)
            {
                return numbers.Sum();
            }
        }

        public class Substraction : Operation
        {
            public override string Name => "Вычитание";

            public override double Run(params double[] numbers)
            {
                return 0d;
            }
        }

        public class Multiplacation : Operation
        {
            public override string Name => "Умножение";

            public override double Run(params double[] numbers)
            {
                return 0d;
            }
        }

        public class Division : Operation
        {
            public override string Name => "Деление";

            public override double Run(params double[] numbers)
            {
                return 0d;
            }
        }

        public class Sqrt : Operation
        {
            public override string Name => "Квадратный корень";

            public override double Run(params double[] numbers)
            {
                return 0d;
            }
        }

    }

                }

            }
Consol.ReadLine();
        }
       public static void Ptint(string Text) 
        {
            Console.WriteLine(Text);
        }
    }
}
            class ProcessCalculation
                {
        public static void TextLines()
        {
Console.WriteLine("Выберите номер вида операции: 1.Алгебраические; 2.Тригонометрические");
                string f = (Console.ReadLine());
                switch (f) {
                    case "1":
                        Console.WriteLine("Выбирите оперцию: x ^ y; # х; сложение [+]; вычитание [-]; деление [:]; умножение [*]");
                        break;

                    case "2":
                        Console.WriteLine("Выбирите оперцию: Sin | Cos | tan");
                        break;

                    default:
                        string choice = Console.ReadLine();
                        double result = 0;}
        }
}
{
        private static string value; private static int choice;

        public void Run()
        {
            do
            {
                Operation operations = new();
                DataInput.UserInput();

                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    default:
                        Console.WriteLine("Неизвестный оператор!");
                        break;
                    case 1:
                        Console.WriteLine("Результат: " +  '\n');
                        break;
                    case 2:
                        Console.WriteLine("Результат: " + Operation.SubtractionOperation, '\n');
                        break;
                    case 3:
                        Console.WriteLine("Результат: " + Operation.MultiplicationOperation, '\n');
                        break;
                    case 4:
                        Console.WriteLine("Результат: " + Operation.DivisionOperation, '\n');  
                        break;
                        //больше операций 
                };

                Console.Write("Подолжить? (д/н):", '\n');
                value = Console.ReadLine();
            }
            while

            (value == "y" || value == "Y" || value == "д" || value == "Д");
        }
    }
}

using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int GetNumbers(string massage)
            {
                int result = 0;
                bool isCorrect = false;

                while (!isCorrect)
                {
                    Console.WriteLine(massage);
                    if (int.TryParse(Console.ReadLine(), out result))
                    {
                        isCorrect = true;
                    }
                    else
                    {
                        Console.WriteLine("Вы ввели не число. Введите число.");
                    }
                }

                return result;
            }

            int a = GetNumbers("Введите число А:");
            int b = GetNumbers("Введите число B:");

            Console.WriteLine(Math.Pow(a, b));

            //Возможно цикл имелся ввиду такой:
            int result = 1;

            if (b > 0)
            {
                for (int i = 1; i <= b; i++)
                {
                    result = result * a;
                }
                Console.WriteLine(result);
            }
            else Console.WriteLine(result);
        }
    }
}

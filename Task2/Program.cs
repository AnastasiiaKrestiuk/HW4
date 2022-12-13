using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int DigitSum (int number)
            {
                int result = 0;
                int temp = number;
                do
                {
                    int n = temp % 10;
                    result += n;

                    temp = temp / 10;
                } while (temp % 10 != 0);
                return result;
            }

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

            int number = GetNumbers("Введите число:");
            Console.WriteLine(DigitSum(number));
        }
    }
}

using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int size = 8;
            int[] arr = new int[size];

            for (int i = 0; i < size; i++)
            {
                arr[i] = rnd.Next(1, 51);
            }

            Console.Write("[");
            for (int i = 0; i < size-1; i++)
            {
                Console.Write($"{arr[i]}, ");
            }
            Console.Write($"{arr[size-1]}]");
        }
    }
}

using System;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int sum = 0;
            bool success;

            do
            {
                success = int.TryParse(Console.ReadLine(), out number);

                if (success)
                {
                    sum += number;
                }
            }while (success != false);

            Console.WriteLine(sum);
        }
    }
}
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
            count = 0;

            do
            {
                success = int.TryParse(Console.ReadLine(), out number);

                if (success)
                {
                    sum += number;
                    counter++;
                }

            }while (success != false);

            Console.WriteLine(sum/count);

        }
    }
}
using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            
            if(int.TryParse(args[0], out number) && number > 0) 
            {
                for (int i = 0; i<= number; i++)
                {
                    Console.WriteLine(i);
                }
            }
            

        }
    }
}


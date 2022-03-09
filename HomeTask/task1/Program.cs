using System;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 12;

            if (a > 0 && a < 3)
            {
                Console.WriteLine("qis");
            }
            else if (a >= 3 && a < 6)
            {
                Console.WriteLine("yaz");
            }
            else if (a >= 6 && a < 9)
            {
                Console.WriteLine("yay");
            }
            else if (a >= 9 && a < 12)
            {
                Console.WriteLine("payiz");
            }
            else if (a == 12)
            {
                Console.WriteLine("qis");
            }
            else
            {
                Console.WriteLine("yanlisdir");
            }

            
        }
    }
}

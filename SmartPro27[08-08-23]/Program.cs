using System;

namespace SmartPro27_08_08_23_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int input_fact, last = 1;

            Console.Write("Faktoriyel alınacak sayı: ");
            input_fact = int.Parse(Console.ReadLine());

            for (int i = 1; i <= input_fact; i++)
            {
                last *= i;
            }
            Console.Write("\n{0}! = {1}",input_fact, last);
            Console.ReadKey();
        }
    }
}

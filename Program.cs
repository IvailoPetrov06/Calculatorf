using System;

namespace Calculatorf
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Моля, въведете число: ");
            string input = Console.ReadLine();

            Console.Write("Моля, въведете бройната система на числото: ");
            int s = int.Parse(Console.ReadLine());

            Console.Write("Моля, въведете бройната система, в която искате да е числото: ");
            int k = int.Parse(Console.ReadLine());

            if (s == 10 && k == 2)
            {
                int decimalNumber = int.Parse(input);
                string binaryResult = Convert.ToString(decimalNumber, 2);
                Console.Write($"{binaryResult}");
            }
            else if (s == 2 && k == 10)
            {
                int decimalNumber = Convert.ToInt32(input, 2);
                Console.Write($"{decimalNumber}");
            }
            else if (s == 10 && k == 16)
            {
                int decimalNumber = int.Parse(input);
                string hexResult = decimalNumber.ToString("X");
                Console.Write($"{hexResult}");
            }
            else if (s == 16 && k == 10)
            {
                int decimalNumber = Convert.ToInt32(input, 16);
                Console.Write($"{decimalNumber}");
            }
        }
    }
}
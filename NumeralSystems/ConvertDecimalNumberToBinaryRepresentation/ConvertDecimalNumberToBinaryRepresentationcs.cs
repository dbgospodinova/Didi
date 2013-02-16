using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertDecimalNumberToBinaryRepresentation
{
    class Program
    {
        /*Write a program to convert decimal numbers to their binary representation. */

        static void Main(string[] args)
        {
            Console.Write("Decimal: ");
            int decimalNumber = int.Parse(Console.ReadLine());

            int remainder;
            string result = string.Empty;
            while (decimalNumber > 0)
            {
                remainder = decimalNumber % 2;
                decimalNumber /= 2;
                result = remainder.ToString() + result;
            }
            Console.WriteLine("Binary:  {0}",result);
        }
    }
}

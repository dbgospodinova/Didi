using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertHexadecimalNumberToDecimalNumber
{
    /*Write a program to convert hexadecimal numbers to their decimal representation. */

    class ConvertHexadecimalNumberToDecimalNumber
    {
        static void Main(string[] args)
        {
            Console.Write("Hexadecimal: ");
            string hexadecimal = Console.ReadLine();
            decimal decimalNumber = Convert.ToInt32(hexadecimal, 16);
            Console.WriteLine("Decimal: {0}", decimalNumber);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertDecimalNumberToHexadecimalNumber
{
    class ConvertDecimalNumberToHexadecimalNumber
    {
        /*Write a program to convert decimal numbers to their hexadecimal representation.*/
        static void Main(string[] args)
        {
            Console.Write("Decimal: ");
            int number = int.Parse(Console.ReadLine());
            string hexadecimal = Convert.ToString(number, 16);
            string upperHex = hexadecimal.ToUpper();
            Console.WriteLine("Hexadecimal: {0}",upperHex);
        }
    }
}


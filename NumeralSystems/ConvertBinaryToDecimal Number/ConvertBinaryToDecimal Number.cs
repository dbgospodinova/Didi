using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertBinaryToDecimal_Number
{
    class Program
    {
        /*Write a program to convert binary numbers to their decimal representation.*/
        static void Main(string[] args)
        {
            Console.Write("Binary: ");
            string binary = Console.ReadLine();
            decimal decimalNumber = Convert.ToInt64(binary, 2);
            Console.WriteLine("Decimal: {0}", decimalNumber);
        }
    }
}

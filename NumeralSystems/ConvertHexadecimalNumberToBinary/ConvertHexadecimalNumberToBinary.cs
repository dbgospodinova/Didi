using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertHexadecimalNumberToBinary
{
    class ConvertHexadecimalNumberToBinary
    {
        /*Write a program to convert hexadecimal numbers to binary numbers (directly).*/
        static void Main(string[] args)
        {
            Console.Write("Hexadecimal: ");
            string hexadecimal = Console.ReadLine();

            string binarystring = String.Join(String.Empty,hexadecimal.Select(c => Convert.ToString(Convert.ToInt32(c.ToString(), 16), 2).PadLeft(4, '0')));
            Console.WriteLine("Binary: {0}", binarystring);
        }
    }
}

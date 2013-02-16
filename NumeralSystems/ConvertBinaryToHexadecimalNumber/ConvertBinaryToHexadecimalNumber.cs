using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertBinaryToHexadecimalNumber
{
    class ConvertBinaryToHexadecimalNumber
    {
        /*Write a program to convert binary numbers to hexadecimal numbers (directly).*/
        static void Main(string[] args)
        {
            Console.Write("Binary: ");
            string binary = Console.ReadLine();

            int remainder = binary.Length % 4;
            binary = binary.PadLeft(remainder, '0'); //pad the length out to by divideable by 4

            string output = "";

            for (int i = 0; i <= binary.Length - 4; i += 4)
            {
                output += string.Format("{0:X}", Convert.ToByte(binary.Substring(i, 4), 2));
            }
            Console.WriteLine("Hexadecimal: {0}",output);
        }
    }
}

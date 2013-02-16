using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BinaryPresentationOfSighnedIntegerShort
{
    class BinaryPresentationOfSighnedIntegerShort
    {
        /*Write a program that shows the binary representation of given 16-bit signed integer number (the C# type short).*/

        static void Main(string[] args)
        {
            Console.Write("Insert number: ");
            short shortNumber  = short.Parse(Console.ReadLine());
            short sign = shortNumber;
            if (sign <= 0)
            { 
                shortNumber = (short)(shortNumber + 1); 
            }

            Console.Write("Binary: ");
            string result = string.Empty;
            for (int i = 15; i >= 0; i--)
            {
                short exponent = (short)Math.Pow(2, i);
                short digit = (short)(shortNumber / exponent);
                shortNumber = (short)(shortNumber % exponent);

                if (sign < 0) 
                {
                    Console.Write(1 + digit);
                }
                else 
                { 
                    Console.Write(digit); 
                }
            }
            Console.WriteLine();
        }
    }
}

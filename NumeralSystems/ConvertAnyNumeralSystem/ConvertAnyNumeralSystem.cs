using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConvertAnyNumeralSystem
{
    class ConvertAnyNumeralSystem
    {
        /*Write a program to convert from any numeral system of given base s to any other numeral system of base d (2 ≤ s, d ≤  16).*/

        static void Main(string[] args)
        {
            Console.WriteLine("Base s:");
            int baseNumeralSystemS = int.Parse(Console.ReadLine());
            Console.WriteLine("Base d:");
            int baseNumeralSystemD = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter number:");
            string number = Console.ReadLine();

            int digitsS = 0;
            int sum = 0;
            int startIndex = number.Length - 1;

            for (int i = 0; i < number.Length; i++)
            {
                string digitNumeralSystemS = number.Substring(startIndex, 1);
                digitsS = Convert.ToInt32(digitNumeralSystemS) * (int)Math.Pow(baseNumeralSystemS, i);
                sum = sum + digitsS;
                startIndex--;
            }
            //Console.WriteLine(sum);

            Console.Write("Convert number: ");
            string result = string.Empty;
            while (sum > 0)
            {
                switch (sum % baseNumeralSystemD)
                {
                    case 0: result += "0"; break;
                    case 1: result += "1"; break;
                    case 2: result += "2"; break;
                    case 3: result += "3"; break;
                    case 4: result += "4"; break;
                    case 5: result += "5"; break;
                    case 6: result += "6"; break;
                    case 7: result += "7"; break;
                    case 8: result += "8"; break;
                    case 9: result += "9"; break;
                    case 10: result += "a"; break;
                    case 11: result += "b"; break;
                    case 12: result += "c"; break;
                    case 13: result += "d"; break;
                    case 14: result += "e"; break;
                    case 15: result += "f"; break;
                    default: result += ""; break;
                }
                sum = sum / baseNumeralSystemD;
            }
            //Reverse the string
            char[] array = result.ToCharArray();
            Array.Reverse(array);
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i]);
            }
            Console.WriteLine();
        }
        
    }
}

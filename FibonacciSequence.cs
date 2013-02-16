using System;

class FibonacciSequence
    {
        static void Main()
        {
            int i;
            int n = 100;
            decimal a = 0;
            decimal b = 1;
            decimal c;
            for (i = 1; i <= n; i++ )
            {
                c = a + b;
                a = b;
                b = c;                
                Console.WriteLine(c);
            }
        }
    }


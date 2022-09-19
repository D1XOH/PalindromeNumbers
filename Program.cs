using System;

namespace Palindrome1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            for(int i = 100000; i < 999999; i++)
            {
                int num = i;
                int N = 0;
                while(num != 0)
                {
                    int digit = num % 10;
                    N = N * 10 + digit;
                    num = num / 10;
                }
                if(i == N)
                {
                    Console.WriteLine("{0}", i);
                }
            }

        }
    }
}

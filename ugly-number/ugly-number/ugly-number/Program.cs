using System;

namespace ugly_number
{
    class Program
    {
        /* url: https://leetcode.com/problems/ugly-number/
         * Description
          An ugly number is a positive integer whose prime factors are limited to 2, 3, and 5.

          Given an integer n, return true if n is an ugly number. 
        */

        static void Main(string[] args)
        {
            Console.WriteLine("Enter a iteger: ");
            var x=   Console.ReadLine();

            var s = new Solution();
            var result = s.get( Convert.ToInt32(x));
            Console.WriteLine(result);
        }  
    }

    public class Solution
    {
        public bool get(int n)
        {
            if (n > 0)
            {
                for (; n % 2 == 0; n /= 2);
                for (; n % 3 == 0; n /= 3) ;
                for (; n % 5 == 0; n /= 5) ;
            }
            return n == 1;
        }
    }
}

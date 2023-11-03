using System;

namespace prime_number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Start number: ");
            var number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("End number: ");
            var endNumber = Convert.ToInt32(Console.ReadLine());

            var s = new Solution();
            //var IsPrime = s.IsPrime(number);
            //Console.WriteLine("Number is prime: {0}", IsPrime);

            s.PrimeNumber(number, endNumber);
        }
    }

    public class Solution
    {
        public bool IsPrime(int n)
        {
            bool r = true;
            for(int i= 2; i<n; i++)
            {
                if (n % i == 0)
                {
                    r = false;
                    break;
                }
            }
            return r;
        }

        public bool PrimeRecursion(int n, int i)
        {
            if(i>=2 && n > i)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            if(i>n)
            {
                return true;
            }

            return PrimeRecursion(n, i+1);
        }

        public void PrimeNumber(int x, int y)
        {
            for (int i = x; i <= y; i++)
            {
                if (PrimeRecursion(i, 2) == true && i > 1)
                    //if(IsPrime(i) == true && i > 1)
                    Console.WriteLine("Prime number: {0}", i);
            }
        }
    }
}

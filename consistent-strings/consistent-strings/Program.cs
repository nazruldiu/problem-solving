using System;

namespace consistent_strings
{
    /*
     * https://leetcode.com/problems/count-the-number-of-consistent-strings/
     * 
     * https://onlinejudge.org/index.php?option=com_onlinejudge&Itemid=8&category=3&page=show_problem&problem=36
     */

    class Program
    {
        static void Main(string[] args)
        {
            string[] w = { "ab", "a", "b", "ce", "bd", "adc" };
            //int C=   ConsistentStrings("abc", w);

            //Console.WriteLine(C);

            //Console.WriteLine(IsGrouped("AABCD"));

            Count(1, 20);
        }
        public static int ConsistentStrings(string s, string[] words)
        {
            int count = 0;
            bool found = true;
            foreach (var item in words)
            {
                foreach (var w in item)
                {
                    if (!s.Contains(w))
                        found = false;
                }
                if (found)
                    count++;
            }

            return count;
        }

        public static bool IsGrouped(string s)
        {
            bool result = true;
            for (int i = 0; i < s.Length - 1; i++)
            {
                char C;
                if (s[i] == s[i + 1])
                {
                    C = s[i];
                    result = true;
                }
                else
                {
                    result = false;
                }
            }
            return result;
        }

        public static void Count(int x, int n)
        {
            int count = 1;
            int tempN = n;
            for(int i=x; i<=n; i++)
            {
                if (i == 1)
                    break;
                if(n%2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n=3*n + 1;
                }
                count++;
            }
            Console.WriteLine(count);
        }
    }
}

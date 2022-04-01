using System;

namespace consistent_strings
{
    /*
     * https://leetcode.com/problems/count-the-number-of-consistent-strings/
     * 
     * https://onlinejudge.org/index.php?option=com_onlinejudge&Itemid=8&category=3&page=show_problem&problem=36
     * 
     * count-the-number-of-consistent-strings  Grouped count 3n+1
     */

    class Program
    {
        static void Main(string[] args)
        {
            string[] w = { "ab", "a", "b", "ce", "bd", "adc" };
            //int C=   ConsistentStrings("abc", w);

            //Console.WriteLine(C);

            //Console.WriteLine(IsGrouped("ABCDD"));

            Count(1, 10);
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
            bool result = false;
            for (int i = 0; i < s.Length - 1; i++)
            {
                char C = s[i];
                for(int j = i+1; j<s.Length; j++)
                {
                    if (C == s[j])
                    {
                        result = true;
                    }
                }

                if (result)
                {

                }
            }
            return result;
        }

        public static void Count(int x, int n)
        {
            int count = 0;
            int result = 0;
            for(int i=x; i<=n; i++)
            {
                count = 1;
                int num = i;
                while (num >= 1)
                {
                    if (num == 1)
                    {
                        break;
                    }
                    if (num % 2 == 0)
                    {
                        num = num / 2;
                    }
                    else
                    {
                        num = 3 * num + 1;
                    }
                    count++;
                }
                Console.WriteLine("Number {0} Count {1}",i,count);
                if (result < count)
                {
                    result = count;
                }
                    
            }
            Console.WriteLine(result);
        }
    }
}

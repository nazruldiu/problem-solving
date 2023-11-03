using System;

namespace longest_palindromic_substring
{
    /*
     * 1.
     * 2. https://leetcode.com/problems/longest-common-prefix/
     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //ababd
            var s = new Solution();
            s.GetPrefix();
        }
    }

    public class Solution{
        
        public string GetResult(string s)
        {
            string result = "";
            for (int i = 0; i < s.Length; i++)
            {
                int start = i;
                int end = i;
                //Odd
                while (start >= 0 && end < s.Length && s[start] == s[end])
                {
                    if (end - start + 1 > result.Length)
                    {
                        result = s.Substring(start, end - start + 1);
                    }
                    start--;
                    end++;
                }
                start = i;
                end = i + 1;
                // Even 
                while (start >= 0 && end < s.Length && s[start] == s[end])
                {
                    if (end - start + 1 > result.Length)
                    {
                        result = s.Substring(start, end - start + 1);
                    }
                    start--;
                    end++;
                }

            }
            return result;
        }

        public void GetPrefix()
        {
            string[] strs = { "flower", "flow", "Light" };

            string result = "";
            if (strs.Length <= 0)
            {
                result = "";
            }
           
            for (int i=0; i<strs.Length-1; i++)
            {
                result = "";
                string my_s = strs[i];
                int intex = 0;
                foreach(var item in my_s)
                {
                    if(intex == strs[i + 1].Length)
                    {
                        break;
                    }
                    if(item == strs[i + 1][intex] && intex < strs[i + 1].Length)
                    {
                        result = result + strs[i + 1][intex];
                    }
                    else
                    {
                        break;
                    }
                    intex++;

                }
            }
            Console.WriteLine(result);
        }


    }

}

using System;
namespace palindrome
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var s = new Solution();
            // s.IsPalindrome();
            //  s.ValidPalindrome();

            //string my_p = "race  car";
            //my_p = my_p.Replace(" ", "");
            //var r = s.MyPalindrome(my_p, 0, my_p.Length-1);
            //Console.WriteLine(r);

            s.SubSecuence();
        }
    }

    public class Solution
    {
        public void IsPalindrome()
        {
            string my_p = "racecar".ToLower();
            bool result = true;
            int l = my_p.Length;
            for (int i = 0, j = l - 1; i<l ; i++, j--){

                if(my_p[i] == my_p[j])
                    result = true;
                else
                    result = false;
            }
            Console.WriteLine(result);
        }

        public void ValidPalindrome()
        {
            string my_p = "race a car";
            my_p = my_p.Replace(" ", "");
            my_p = my_p.ToLower();
            bool result = true;
            int l = my_p.Length;
            for (int i = 0, j = l - 1; i < l; i++, j--)
            {

                if (my_p[i] == my_p[j])
                    result = true;
                else
                {
                    result = false;
                    break;
                }

            }
            //var s = my_p.ToCharArray().Reverse().ToArray();
            //if (my_p == new string(s))
            //    result = true;
            //else
            //    result = false;

            Console.WriteLine(result);
        }

        public bool MyPalindrome(string my_p, int s, int e)
        {
            
            my_p = my_p.ToLower();
            if (my_p[s] != my_p[e])
            {
                return false;
            }
            if (s <= e)
            {
               return MyPalindrome(my_p, s+1, e-1);
            }
            return true;
        }

        public void SubSecuence()
        {
            string S = "bbbab";
            char RC=char.MinValue;
            int Rcount = 0;

            for (int i=0; i<S.Length; i++)
            {
                char C = S[i];
                int count = 0;
                for(int j=0;j<S.Length; j++)
                {
                    if (C == S[j])
                        count++;
                }

                if(count > Rcount)
                {
                    Rcount = count;
                    RC = C;
                }
            }

            char[] res = new char[Rcount];
            for (int i = 0; i < Rcount; i++)
                res[i] = RC;

            Console.WriteLine("{0} {1} {2}", RC, Rcount, new string(res));
        }
    }
}

using System;

namespace missing_number
{
    class Program
    {
        /* 
         * https://leetcode.com/problems/missing-number/
         * https://leetcode.com/problems/find-the-duplicate-number/
         */
        static void Main(string[] args)
        {
            //MNumber();
            DNumber();
        }
        #region Missing Number
        public static void MNumber()
        {
            Console.Write("Enter array size :");
            int size = int.Parse(Console.ReadLine());
            int[] myNum = new int[size];

            Console.WriteLine("Enter {0} array element :", size);
            for (int i = 0; i < size; i++)
            {
                myNum[i] = int.Parse(Console.ReadLine());
            }
            Array.Sort(myNum);
            int m = MissingNumber(myNum);
            Console.Write("Missing element : {0}", m);
            Console.ReadKey();
        }

        public static int MissingNumber(int[] num)
        {
            int length = num.Length;

            for(int i=0; i< length; i++)
            {
                if (num[i] != i)
                {
                    return i;
                }
            }
            return length;
        }
        #endregion

        #region Duplicate Number
        public static void DNumber()
        {
            Console.Write("Enter array size :");
            int size = int.Parse(Console.ReadLine());
            int[] myNum = new int[size];

            Console.WriteLine("Enter {0} array element :", size);
            for (int i = 0; i < size; i++)
            {
                myNum[i] = int.Parse(Console.ReadLine());
            }
            int m = DuplicateNumber(myNum);
            Console.Write("Duplicate element : {0}", m);
            Console.ReadKey();
        }

        public static int DuplicateNumber(int[] num)
        {
            int length = num.Length;
            for (int i = 0; i < length; i++)
            {
                for (int j = i+1; j < length; j++)
                {
                    if (num[i] == num[j])
                        return num[i];
                }
            }
            return length;
        }
        #endregion

    }

}

using System;

namespace array_partition
{
    /*
     * https://leetcode.com/problems/array-partition-i/
     * Bubble Sort
     * Linear Search
     * Binary Search
     */
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 4, 3, 2, 5 };

            //Console.WriteLine(sum(num));
            //Sort(num);
            LinearSearch(num, 3);
        }

        public static int sum(int[] number)
        {
            int result = 0;
            Array.Sort(number);
            for(int i=0; i< number.Length; i += 2)
            {
                result = result + number[i];
            }
            return result;
        }

        public static void Sort(int[] number)
        {
            int temp;
            for (int i = 0; i < number.Length; i++)
            {
                temp = number[i];
                for (int j = i+1; j < number.Length; j++)
                {
                    if (number[i] > number[j])
                    {
                        number[i] = number[j];
                        number[j] = temp;
                    }
                }
            }

            for (int i = 0; i < number.Length; i++)
                Console.WriteLine(number[i]);
        }

        public static void LinearSearch(int[] number, int x)
        {
            int result = -1;
            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == x)
                    result = i;
            }

            Console.WriteLine(result);
        }

        public static void BinarySearch(int[] number, int x)
        {
            int l = 0; int r = number.Length - 1; int result = -1;

            while (l <= r)
            {
                int m = l + (r - l) / 2;

                if (number[m] == x)
                {
                    result = m;
                    break;
                }

                if (number[m] < x)
                    l = m + 1;
                else
                    r = m - 1;
            }
            Console.WriteLine(result);
        }
    }
}

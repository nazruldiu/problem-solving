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
            //DNumber();
            //BubbleSort();
            //LinearSearch();
            //BinarySearch();
            Fibonacci();
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

        public static void BubbleSort()
        {
            int[] number = { 1, 3, 4, 2 };
            int isSwap;

            for(int i = 0; i<number.Length-1; i++)
            {
                isSwap = 0;
                for(int j=0; j < number.Length - 1- i; j++)
                {
                    int temp;
                    if (number[j] > number[j + 1])
                    {
                        temp = number[j];
                        number[j] = number[j + 1];
                        number[j + 1] = temp;
                        isSwap = 1;
                    }
                }
                if (isSwap == 0)
                    break;
            }

            for(int i=0; i<number.Length; i++)
            {
                Console.Write("{0} ", number[i]);
            }
        }

        public static void LinearSearch()
        {
            int[] num = { 1, 2, 3, 4 };
            int f = 3;

            for(int i=0; i<num.Length; i++)
            {
                if (num[i] == f)
                {
                    Console.WriteLine("{0} at possition {1}", f, i);
                    break;
                }
            }
        }

        public static void BinarySearch()
        {
            int[] num = { 1, 2, 3, 4, 5};
            int key = 4;
            int min = 0;
            int max = num.Length - 1;

            while (min <= max)
            {
                int mid = (max + min) / 2;
                if (num[mid] == key)
                {
                    Console.WriteLine("{0} at possition {1}", key, mid);
                    break;
                }
                else if(num[mid] > key)
                {
                    max = mid--;
                }
                else
                {
                    min = mid++;
                }
            }

        }

        public static void Fibonacci()
        {
            int t1 = 0, t2 = 1;
            int n = 10;
            Console.Write("{0} {1} ", t1, t2);
            int nextN = t1 + t2;
            while (nextN <= n)
            {
                Console.Write("{0} ", nextN);
                t1 = t2;
                t2 = nextN;
                nextN = t1 + t2;
            }
        }
    }

}

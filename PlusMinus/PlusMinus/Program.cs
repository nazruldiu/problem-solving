namespace PlusMinus
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            //Result.plusMinus(arr);


            TextWriter textWriter = new StreamWriter(@System.Environment.GetEnvironmentVariable("OUTPUT_PATH"), true);

            int arrCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

            List<int> res = Result.reverseArray(arr);

            textWriter.WriteLine(String.Join(" ", res));

            textWriter.Flush();
            textWriter.Close();
        }
    }

    class Result
    {

        /*
         * Complete the 'plusMinus' function below.
         *
         * The function accepts INTEGER_ARRAY arr as parameter.
         */
        public static List<int> reverseArray(List<int> a)
        {
            List<int> result = new List<int>();
            int[] x = a.ToArray();
            for(int i=x.Length -1; i>=0; i--)
            {
                result.Add(x[i]);
            }
            return result;
        }

        public static void plusMinus(List<int> arr)
        {
            decimal r = arr.Count();
            decimal p = 0;
            decimal n = 0;
            decimal z = 0;

            decimal pd, nd, zd;
            foreach (var item in arr)
            {
                if (item > 0)
                    p = p + 1;
                if (item < 0)
                    n = n + 1;
            }

            z = r - p - n;
            pd = p / r;
            nd = n / r;
            zd = z / r;

            Console.WriteLine(pd.ToString("N5"));
            Console.WriteLine(nd.ToString("N5"));
            Console.WriteLine(zd.ToString("N5"));
        }

    }
}
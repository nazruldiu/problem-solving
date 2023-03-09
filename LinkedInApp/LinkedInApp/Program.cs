namespace LinkedInApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> myString = new List<string> {"Dhaka", "Comilla", "Dhaka", "Mymensing", "Barishal" };

            //// Order By
            //myString.Sort();

            //myString.Reverse();

            //myString.OrderBy(x => x);

            //myString.OrderByDescending(x => x);

            //// removing Duplicate
            //var uniqueString = myString.Distinct().ToList();
            //var uniqueString = myString.ToHashSet().ToList();
            //var uniqueString = myString.GroupBy(x=>x).Select(d=>d.First()).ToList();

            Console.WriteLine("Hello, World!");
        }
    }
}
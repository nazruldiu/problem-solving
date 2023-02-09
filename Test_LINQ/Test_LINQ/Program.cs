namespace Test_LINQ;

internal class Program
{
    static void Main(string[] args)
    {
        string myString = "helloo";

        char[] arr = myString.ToCharArray();

        var result = arr.GroupBy(x => x)
                    .Where(x => x.Count() > 1)
                    .Select(x => x.Key);
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        Console.ReadLine();
    }
}
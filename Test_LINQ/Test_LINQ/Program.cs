namespace Test_LINQ;

internal class Program
{
    public delegate int Calculate(int firstNumber, int secondNumber);


    static void Main(string[] args)
    {
        string myString = "helloo";

        char[] arr = myString.ToCharArray();

        var result = arr.GroupBy(x => x)
                    .Where(x => x.Count() > 1)
                    .Select(x => x.Key);
        //foreach (var item in result)
        //{
        //    Console.WriteLine(item);
        //}

        /* To point or initialize a method to a delegate signature must need to be equal 
         * that means (a) delegate return type and method must be same and (b) parameters need to be same also.
         */
        //Calculate calculate = new Calculate(Sum);  // we can point delegate in this way. Here 'calculate' is pointer or reference
        Calculate calculate = Sum;                   // we can point delegate in this way too.

        //int myResult = calculate.Invoke(5, 5);    // we can invoke delegate in this way.
        //int myResult = calculate(5, 5);           // we can invoke delegate in this way too.

        //Console.WriteLine(myResult);

        MyDelegateMethod(calculate,5,5);   // Passing method as a parameter using C# delegate.

        Calculate calculate1 = Sub;

        MyDelegateMethod(calculate1, 5, 5); // Passing method as a parameter using C# delegate.

        Console.ReadLine();
    }

    static int Sum(int x, int y)
    {
        return x + y;
    }

    static int Sub(int x, int y)
    {
        return x - y;
    }

    static void MyDelegateMethod(Calculate calculate, int fNumber, int sNumber)
    {
        Console.WriteLine(calculate(fNumber, sNumber));
    }
}
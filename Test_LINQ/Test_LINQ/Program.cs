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

        //int[] myNum = { 1, 2, 2, 3, 4, 4, 5 };

        //var numResult = myNum.GroupBy(x => x)
        //                .Where(x => x.Count() == 1)
        //                .Select(x => x.Key);

        int[] myNum = { 1, 2, 2, 3, 4, 4, 5 , 6, 6};

        var numResult = myNum.Min(x => x);

        Console.WriteLine(numResult);

        //string myCar = "madam";
        //char[] myArray = myCar.ToCharArray();
        //Array.Reverse(myArray);
        //string str = new string(myArray);
        //if (myCar == str)
        //{
        //    Console.WriteLine("palindrome");
        //}
        //else
        //{
        //    Console.WriteLine("not palindrome");
        //}

        //string myLine = "I live in Dhaka!";
        //string[] myStringArr = myLine.Split(' ').ToArray();
        //Array.Reverse(myStringArr);

        //for(int i=0; i< myStringArr.Length; i++)
        //{
        //    Console.Write(myStringArr[i]+" ");
        //}

        /* To point or initialize a method to a delegate signature must need to be equal 
         * that means (a) delegate return type and method must be same and (b) parameters need to be same also.
         */
        //Calculate calculate = new Calculate(Sum);  // we can point delegate in this way. Here 'calculate' is pointer or reference
        //Calculate calculate = Sum;                   // we can point delegate in this way too.

        //int myResult = calculate.Invoke(5, 5);    // we can invoke delegate in this way.
        //int myResult = calculate(5, 5);           // we can invoke delegate in this way too.

        //Console.WriteLine(myResult);

        //MyDelegateMethod(calculate, 5, 5);   // Passing method as a parameter using C# delegate.

        //Calculate calculate1 = Sub;

        //MyDelegateMethod(calculate1, 5, 5); // Passing method as a parameter using C# delegate.

        //Console.ReadKey();
    }

    static int Sum(int x, int y) =>(x + y); // Lambda expression Left side parameter and right side expression.

    static int Sub(int x, int y)
    {
        return x - y;
    }

    static void MyDelegateMethod(Calculate calculate, int fNumber, int sNumber)
    {
        Console.WriteLine(calculate(fNumber, sNumber));
    }
}
using System.Security.Cryptography.X509Certificates;

namespace LinkedInApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> myString = new List<string> { "Dhaka", "Comilla", "Dhaka", "Mymensing", "Barishal" };

            //// Order By
            //myString.Sort();

            //myString.Reverse();

            //myString.OrderBy(x => x);

            //myString.OrderByDescending(x => x);

            //// removing Duplicate
            //var uniqueString = myString.Distinct().ToList();
            //var uniqueString = myString.ToHashSet().ToList();
            //var uniqueString = myString.GroupBy(x=>x).Select(d=>d.First()).ToList();


            MyBase myBase = new MyDerived();
            myBase.Install();
            //GetName(myBase);

            //Console.WriteLine(myBase.Name);
        }

        //public static void GetName(MyDerived my){
        //    Console.WriteLine(my.Name);
        //}

    }

    public class MyBase
    {
        public void Install()
        {
            Console.WriteLine("Installed");
        }
        public virtual void Print( string text)
        {
            Console.WriteLine("Print :"+ text);
        }
    }

    public class MyDerived : MyBase
    {
        public new void Install()
        {
            Console.WriteLine("MyDerived Installed");
        }
        public override void Print(string text)
        {
            Console.WriteLine("MyDerived Print :" + text);
        }
    }
}
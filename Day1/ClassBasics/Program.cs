//using System;
global using System;
namespace ClassBasics
{
    internal class Program
    {
        static void Main1()
        {
            //System.Console.WriteLine("h w");

            System.Console.WriteLine("aa");

            Console.WriteLine("Hello, World!");
            //ClassBasics.n2.Class1
            //n2.Class1
            //n3.Class1
        }
        static void Main()
        {
            Class1 o;
            o = new Class1();

            o.Display();
            o.Display("hello");

            Console.WriteLine(o.Add());
            Console.WriteLine(o.Add(10));
            Console.WriteLine(o.Add(10, 20));
            Console.WriteLine(o.Add(10, 20,30)); //positional parameters

            Console.WriteLine(o.Add(c: 10, a: 20, b: 30)); //named parameters
            Console.WriteLine(o.Add(c: 10)); //named parameters

            o.DoSomething();
        }
    }
    public class Class1 //: Object
    {
        public void Display()
        {
            Console.WriteLine("display...");
        }
        public void Display(string s)
        {
            Console.WriteLine("display..."+ s);
        }

        //public int Add(int a, int b)
        //{
        //    return a + b;
        //}
        //public int Add(int a, int b, int c)
        //{
        //    return a + b+c;
        //}

        //optional parameters with default values
        public int Add(int a=0, int b=0, int c=0)
        {
            return a + b + c;
        }

        public void DoSomething()
        {
            int i = 0;
            Console.WriteLine("do something");
            DoSomethingElse();
            DoSomethingElse2();

            //local function
            //implicitly private
            void DoSomethingElse()
            {
                Console.WriteLine("do something else ");
                //local func can access a variable defined in the calling function
                Console.WriteLine(i);
                
            }
            static void DoSomethingElse2()
            {
                Console.WriteLine("do something else ");
                //static local func cannot access a variable defined in the calling function
                //Console.WriteLine(i);
            }


        }
         

    }


    //namespace n2
    //{
    //    public class Class1 { }
    //}
}

//namespace n3
//{
//    namespace n3a
//    {
//        public class Class1 { }

//    }
//}

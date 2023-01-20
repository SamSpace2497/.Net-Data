namespace Delegates1
{
    //step 1 : create a delegate class having the same signature as the functon to call
    public delegate void Del1();

    public delegate int Del2(int a, int b);
    //Object
    //Delegate
    //MulticastDelegate
    //Del1
    internal class Program
    {
        static void Main1()
        {
            //step 2 : create an object of the delegate class, passing function name as a parameter
            Del1 objDel = new Del1(Display);

            //step 3 : call the function with the delegate reference
            objDel();
        }
        static void Main2()
        {
            Del1 objDel = Display;
            objDel();

            Console.WriteLine();
            objDel = Show;
            objDel();

        }

        static void Main3()
        {
            Del1 objDel = Show;
            objDel();

            Console.WriteLine();
            objDel += Show;
            objDel();

            Console.WriteLine();
            objDel += Display;
            objDel();

            Console.WriteLine();
            objDel -= Display;
            objDel();

            Console.WriteLine();
            objDel -= Display;
            objDel();

            Console.WriteLine();
            objDel -= Show;
            objDel();
        }
        static void Main4()
        {
            //Del1 objDel = Display;
            //objDel = (Del1)Delegate.Combine(objDel, new Del1(Show), new Del1(Display));


            Del1 objDel =(Del1) Delegate.Combine(new Del1(Display), new Del1(Show), new Del1(Display));
            objDel();

            Console.WriteLine();
            //objDel = (Del1)Delegate.Remove(objDel, new Del1(Display));
            objDel = (Del1)Delegate.RemoveAll(objDel, new Del1(Display));
            objDel();
        }

        static void Main5()
        {
            Del2 objDel2 = Add;
            int ans = objDel2(10, 20);
            Console.WriteLine(ans);

            Console.WriteLine( objDel2(10,20) );
        }
        static void Main6()
        {
            Del2 objDel2 = Add;

            objDel2 += Subtract;

            //int ans = objDel2(10, 20);
            //ans = Add(10, 20);
            //ans = Subtract(10, 20);
            //Console.WriteLine(ans);

            Console.WriteLine(objDel2(10, 20));
        }

        static void Main7()
        {
            Del1 objDel = Class1.Display;
            objDel();

            Class1 ocls1 = new Class1();
            objDel = ocls1.Show;
            objDel();
        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
        static void Display()
        {
            Console.WriteLine("Display called");
        }
        static void Show()
        {
            Console.WriteLine("Show called");
        }
    }

    public class Class1
    {
        public static void Display()
        {
            Console.WriteLine("class1 Display called");
        }
        public void Show()
        {
            Console.WriteLine("Show called");
        }
    }
}

namespace Delegates2
{
    //step 1 : create a delegate class having the same signature as the functon to call

    public delegate int Del2(int a, int b);
 
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine(PassFuncNameAsAParameter(Add,10,20));
            Console.WriteLine(PassFuncNameAsAParameter(Subtract,20,10));
        }
        static int PassFuncNameAsAParameter(Del2 objDel2,int a,int b)
        {
            return objDel2(a,b);

        }
        static int Add(int a, int b)
        {
            return a + b;
        }
        static int Subtract(int a, int b)
        {
            return a - b;
        }
       
    }

   
}
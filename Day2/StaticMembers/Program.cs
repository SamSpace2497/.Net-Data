namespace StaticMembers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 o1;
            o1 = new Class1();

            Class1.s_i = 1234;
            Class1.sDisplay();
            Class1.sP1 = 20;
            Class1 o2 = new Class1();
            o1.i = 1000;
            o2.i = 2000;

            o1.Display();
            o1.P1 = 10;

        }
    }

    public class Class1
    {
        public int i;
        //single copy
        public static int s_i;

        public void Display()
        {
            Console.WriteLine("display");
            Console.WriteLine(i);
            Console.WriteLine(s_i);
        }

        //can be called without creating an object.
        //directly called as classname.methodname
        public static void sDisplay()
        {
            Console.WriteLine("static display");
            //Console.WriteLine(i); //error
            Console.WriteLine(s_i);
        }
        private int p1;
        public int P1
        {
            set
            {
                if (value < 100)
                    p1 = value;
                else
                    Console.WriteLine("invalid p1");
            }
            get
            {
                return p1;
            }
        }
        private static int sp1;
        public static int sP1
        {
            set
            {
                if (value < 100)
                    sp1 = value;
                else
                    Console.WriteLine("invalid p1");
            }
            get
            {
                return sp1;
            }
        }
        public Class1()
        {
            Console.WriteLine("cons");
        }
        static Class1()
        {
            Console.WriteLine("static cons");
            s_i = 1;
            sP1 = 2;
        }

    }
}

//why static variable - single copy
//why property - validations
//why static property - single copy with validations

//why constructor? - to initialise data members
//why static constructor? - to initialise static data members
//when is the static constructor called? - when the class is loaded
//when is the class loaded? - either when the first object is created OR
//                           a static member is first accessed


//static class
//can only contain static members
//cannot be instantiated
//cannot be a base class


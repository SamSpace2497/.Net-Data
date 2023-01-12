
//inheritance 
namespace InheritanceExamples
{
    internal class Program
    {
        static void Main1(string[] args)
        {
            //BaseClass o = new BaseClass();
            
            //DerivedClass o = new DerivedClass();
            //o.
        }
    }

    public class BaseClass
    {
        public int i;
    }

    public class DerivedClass : BaseClass
    {
        public int j;
    }
}

//access specifiers
namespace InheritanceExamples2
{

    //default access specifier is internal at the namespace level
    class Program
    {
        static void Main2(string[] args)
        {
            //BaseClass o = new BaseClass();
            //o.

            TestAccessSpecifiers.BaseClass o = new TestAccessSpecifiers.BaseClass();
            //o.
        }
    }
    public class BaseClass
    {
        //public - available everywhere
        //private - same class
        //protected - same class,  derived class
        //internal - same class, same assembly(same project)
        //protected internal - same class,  derived class, same assembly(same project)
        //private protected - same class,  derived class that is in the same assembly
        public int PUBLIC;
        private int PRIVATE;
        protected int PROTECTED;
        internal int INTERNAL;
        protected internal int PROTECTED_INTERNAL;
        private protected int PRIVATE_PROTECTED;
        int x; //default access specifier is private for members of a class

    }

    public class DerivedClass : TestAccessSpecifiers.BaseClass   //: BaseClass
    {
        void DoNothing()
        {
            //this.
        }
    }
}

//constructors in inheritance
namespace InheritanceExamples3
{
    class Program
    {
        static void Main1()
        {
            //DerivedClass o = new DerivedClass();
            DerivedClass o2 = new DerivedClass(123, 456);
            Console.ReadLine();
        }
    }
    public class BaseClass
    {
        public int i;
        public BaseClass()
        {
            Console.WriteLine("base class no param cons");
            i = 10;
        }
        public BaseClass(int i)
        {
            Console.WriteLine("base class int cons");
            this.i = i;
        }
    }
    public class DerivedClass : BaseClass
    {
        public int j;
        public DerivedClass()
        {
            Console.WriteLine("derived class no param cons");
            //i = 10;
            j = 20;
        }
        public DerivedClass(int i, int j) : base(i)
        {
            Console.WriteLine("derived class int,int cons");
            //this.i = i;
            this.j = j;
        }
    }
}


//overloading, hiding/overriding base class method in derived class
namespace InheritanceExamples4
{
    class Program
    {
        static void Main1()
        {
            DerivedClass o = new DerivedClass();
            //o.Display1();
            //o.Display1("aa");

            o.Display2();
            o.Display3();
            Console.ReadLine();
        }

        static void Main()
        {
            BaseClass o;
            o = new BaseClass();
            //o.Display2();
            o.Display3();

            Console.WriteLine();
            o = new DerivedClass();
            //o.Display2();
            o.Display3();

            Console.WriteLine();
            o = new SubDerivedClass();
            //o.Display2();
            o.Display3();

            Console.WriteLine();
            o = new SubSubDerivedClass();
            //o.Display2();
            o.Display3();

        }
    }
    public class BaseClass
    {
        public void Display1()
        {
            Console.WriteLine("base display1");
        }
        public void Display2()
        {
            Console.WriteLine("base display2");
        }
        public virtual void Display3()
        {
            Console.WriteLine("base display3");
        }
    }
    public class DerivedClass : BaseClass
    {
        public void Display1(string s) //overload 
        {
            Console.WriteLine("derived display1" + s);
        }

        public new void Display2()  //hiding
        {
            Console.WriteLine("derived display2");
        }

        public override void Display3() //overriding
        {
            Console.WriteLine("derived display3");
        }

    }

    public class SubDerivedClass : DerivedClass
    {
        public sealed override void Display3()
        {
            Console.WriteLine("subderived display3");
        }
    }
    public class SubSubDerivedClass : SubDerivedClass
    {
        public new void Display3()
        {
            Console.WriteLine("subsubderived display3");
        }
    }

}
/*

1. overload the base class method
- same method name, diff signature
- objDerived.BaseMethod()
- objDerived.BaseMethod(parameters) //derived class method

2. hide the base class method
- same method name, same signature
- objDerived.BaseMethod() //derived class method
- any method can be hidden

3. override the base class method
- same method name, same signature
- objDerived.BaseMethod() //derived class method
- only a virtual method can be overridden


*/

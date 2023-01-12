namespace InheritanceExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //AbstractClass1 o = new  AbstractClass1();  //error
            Derived1 o1 = new Derived1();
            o1.Method1();

            Derived2 o2 = new Derived2();
            o2.Show();
        }
    }

    public abstract class AbstractClass1
    {
        public void Method1()
        {
            Console.WriteLine("abstract class method 1");
        }
    }
    public class Derived1 : AbstractClass1
    {

    }
    public abstract class AbstractClass2
    {
        public void Method1()
        {
            Console.WriteLine("abstract class method 1");
        }
        public abstract void Display();  //pure virtual func
        public abstract void Show();  //pure virtual func

        //public abstract void SomeOtherMethod();  //pure virtual func
    }
    public class Derived2 : AbstractClass2
    {
        public override void Display()
        {
            Console.WriteLine("Display");
        }

        public override void Show()
        {
            Console.WriteLine("show");
        }
    }
}

/*
                                          Abstract class        Sealed class
Can be instantiated                         NO                  YES
Can be used as a base class                 YES                 NO
  
 */




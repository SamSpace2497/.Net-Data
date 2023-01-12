namespace ConstructorsAndObjectInitializers1
{
    internal class Program
    {
        static void Main1()
        {
            //Class1 o = new Class1();
            Class1 o = new Class1(1, 2, 3);
            Console.WriteLine(o.P1);
            Console.WriteLine(o.P2);
            Console.WriteLine(o.P3);

        }
    }
    public class Class1
    {
        public int P1 { get; set; }
        public int P2 { get; set; }
        public int P3 { get; set; }

        //public Class1()
        //{
        //    P1 = 10;
        //    P2 = 20;
        //    P3 = 30;
        //}
        //public Class1(int P1, int P2, int P3)
        //{
        //    this.P1 = P1;
        //    this.P2 = P2;
        //    this.P3 = P3;
        //}
        //public Class1(int P1, int P2)
        //{
        //    this.P1 = P1;
        //    this.P2 = P2;
        //    this.P3 = 30;
        //}
        //public Class1(int P1)
        //{
        //    this.P1 = P1;
        //    this.P2 = 20;
        //    this.P3 = 30;
        //}
        public Class1(int P1=10, int P2=20, int P3=30)
        {
            this.P1 = P1;
            this.P2 = P2;
            this.P3 = P3;
        }

    }
}

namespace ConstructorsAndObjectInitializers2
{
    internal class Program
    {
        static void Main1()
        {
            //Class1 o = new Class1();
            //o.P1 = 1;
            //o.P2 = 2;
            //o.P3 = 3;

            //Class1 o = new Class1(1, 2, 3);

            //object initializer
            Class1 o = new Class1() { P1 = 1, P2 = 2, P3 = 3 };
            Class1 o2 = new Class1{ P1 = 1, P2 = 2, P3 = 3 };



            Console.WriteLine(o.P1);
            Console.WriteLine(o.P2);
            Console.WriteLine(o.P3);

        }
    }
    public class Class1
    {
        public int P1 { get; set; }
        public int P2 { get; set; }
        public int P3 { get; set; }
    }
}
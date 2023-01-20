namespace EventHandling1
{
    //internal class Program
    //{
    //    static void Main()
    //    {
    //       Class1  objCls1 = new Class1();
    //        objCls1.InvalidP1 += objCls1_InvalidP1;
    //        objCls1.InvalidP1 += handler2;

    //        objCls1.P1 = 101;
    //    }
    //    static void objCls1_InvalidP1()
    //    {
    //        Console.WriteLine("event handled here");
    //    }
    //    static void handler2()
    //    {
    //        Console.WriteLine("event handled here too!!!!!");
    //    }
    //}

    //step 1 : create a delegate class having the same signature as the event handler

    internal class UserClass
    {
        static void Main1()
        {
            Class1 objCls1 = new Class1();
            objCls1.InvalidP1 += ObjCls1_InvalidP1;

            objCls1.P1 = 10000;

        }

        private static void ObjCls1_InvalidP1()
        {
            Console.WriteLine("event handled here");
        }
    }

    public delegate void InvalidP1EventHandler();
    public class Class1
    {
        //step 2 : declare the event (delegate reference) of the delagate type
        public event  InvalidP1EventHandler InvalidP1;

        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    //step 3 : call the event (delegate obj) whenever required
                    if(InvalidP1!=null)
                        InvalidP1();
                }
            }
        }
    }
}


namespace EventHandling2
{
    internal class UserClass
    {
        static void Main()
        {
            Class1 obj = new Class1();
            obj.InvalidP1 += Obj_InvalidP1;
            obj.P1 = 1234;
        }

        private static void Obj_InvalidP1(int InvalidValue)
        {
            Console.WriteLine("event raised. invalid value was "+ InvalidValue);
        }
    }
    //step 1 : create a delegate class having the same signature as the event handler
    public delegate void InvalidP1EventHandler(int InvalidValue);
    public class Class1
    {
        //step 2 : declare the event (delegate reference) of the delegate type
        public event InvalidP1EventHandler InvalidP1;

        private int p1;
        public int P1
        {
            get
            {
                return p1;
            }
            set
            {
                if (value < 100)
                    p1 = value;
                else
                {
                    //step 3 : call the event (delegate obj) whenever required
                    if (InvalidP1 != null)
                        InvalidP1(value);
                }
            }
        }
    }
}
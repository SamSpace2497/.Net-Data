namespace ActionFuncPredicate
{
    internal class Program
    {
        static void Main1()
        {
            Action o1 = Display;
            o1();

            Action<string> o2 = Display;
            o2("hello");

            Action<string, int> o3 = Display;
            o3("aa", 10);

        }
        static void Main()
        {
            Func<string> o1 = GetNow;
            Console.WriteLine(o1());

            Func<int, bool> o2 = IsEven;
            Console.WriteLine(o2(10));

            Func<int, int, int> o3 = Add;
            Console.WriteLine(o3(10,20));

            Func<string, int,int, string> o4 = GetSubstring;
            Console.WriteLine(o4("Hello",0,4));

            Predicate<int> o5 = IsEven;
            Console.WriteLine(o5(20));

        }
        static void Display()
        {
            Console.WriteLine("Display called");
        }
        static void Display(string s)
        {
            Console.WriteLine("Display called" + s);
        }
        static void Display(string s, int i)
        {
            Console.WriteLine("Display called" + s + i);
        }

        static int Add(int a, int b)
        {
            return a + b;
        }
        static string GetNow()
        {
            return DateTime.Now.ToString();
        }
        static string GetSubstring(string s, int startIndex, int noOfChars)
        {
            return s.Substring(startIndex, noOfChars);
        }
        static bool IsEven(int i)
        {
            if (i % 2 == 0)
                return true;
            else
                return false;
        }
    }
}
namespace AnonymousMethodsAndLambdas1
{
    internal class Program
    {
        static void Main1()
        {
            int i=100;
            Action o1 = delegate()
            {
                Console.WriteLine(i);
                Console.WriteLine("Anon method called");
            };
            o1();
            Func<int, int, int> o2 = delegate (int a, int b)
            {
                return a + b;
            };
        }
    }
}

namespace AnonymousMethodsAndLambdas
{
    internal class Program
    {
        static void Main1()
        {
            Func<int, int> o1 = GetDouble;  //function
            Console.WriteLine(o1(10));

            Func<int, int> o2 = delegate(int a)
            {
                return a * 2;
            };  //anon method
            Console.WriteLine(o2(10));
            //Func<int, int> o3 = (a) => a * 2;
            Func<int, int> o3 = a => a * 2;  //lambda
            Console.WriteLine(o3(10));
        }
        static void Main()
        {
            Func<string> o1 = ()=> DateTime.Now.ToString();
            Console.WriteLine(o1());

            Func<int, int, int> o2 = (a, b) => a + b;
            Console.WriteLine(o2(10,20));

            Func<string, int, int, string> o3 = (s, startIndex, noOfChars) => s.Substring(startIndex, noOfChars);
            Console.WriteLine(o3("Hello",0,2));

            Predicate<int> o4 = i =>
            {
                if (i % 2 == 0)
                    return true;
                else
                    return false;
            };

            Func<int, bool> o5 = i => i % 2 == 0;
            Console.WriteLine(o4(10));
            Console.WriteLine(o5(10));

            Predicate<Employee> o6 = emp => emp.Basic > 10000;
            Employee obj = new Employee { EmpNo = 1, Basic = 2000 };
            Console.WriteLine(o6(obj));

        }
        static int GetDouble(int a) { return a * 2; }
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
        //write a func that takes an employee object as a parameter and returns true if Basic >10000
        static bool IsBasicMoreThan10000(Employee obj)
        {
            if (obj.Basic > 10000)
                return true;
            else
                return false;
        }
    }
    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }
        public decimal Basic { get; set; }
        public int DeptNo { get; set; }

    }
}
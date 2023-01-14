namespace NullableTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? i;
            i = 100;
            i = null;

            int j;
            if (i != null)
                j = (int)i;
            else
                j = 0;

            if (i.HasValue)
                j = i.Value;
            else
                j = 0;

            j = i.GetValueOrDefault();
            j = i.GetValueOrDefault(10);
            j = i ?? 0; //null coalescing operator

            Console.WriteLine(j);
        }
    }

    public class Employee
    {
        private string name;
        public string Name
        {
            get { return name; }
            set {  name = value; }
        }
    }
}
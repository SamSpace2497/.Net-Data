namespace Arrays
{
    internal class Program
    {
        static void Main()
        {
            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = new int[3] { 1, 2, 3};
            int[] arr = new int[5];
            //int[] arr  --- arr is an object of the (integer array) class
            //(integer array) class inherits from the System.Array class

            for (int i = 0; i < arr.Length; i++)
            {
                //Console.WriteLine("Enter element no " + i.ToString());  //string concatenation
                //Console.WriteLine("Enter element no {0} ", i);  //placeholder
                Console.Write($"Enter element no {i} ");  //string interpolation

                arr[i] = int.Parse(Console.ReadLine());
                //arr[i] = Convert.ToInt32 (Console.ReadLine());
            }
            Console.WriteLine();
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

        }
    }
}
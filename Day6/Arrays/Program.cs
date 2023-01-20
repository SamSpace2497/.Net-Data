namespace Arrays
{
    internal class Program
    {
        static void Main1()
        {
            int[] arr1 = new int[] { 1, 2, 3 };
            int[] arr2 = new int[3] { 1, 2, 3 };
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
        static void Main2()
        {
            int[] arr = new int[] { 10, 20, 30 , 10, 50};

            int pos = Array.IndexOf(arr, 15); //-1
            
            pos = Array.LastIndexOf(arr, 10);
            pos = Array.BinarySearch(arr, 10);

            //Array.Clear(arr);
            //Array.Copy(arr, arr2, arr.Length);
            //Array.ConstrainedCopy

            //int[] arr2 = (int[])Array.CreateInstance(typeof(int), 5);
            Array.Reverse(arr);
            Array.Sort(arr);

            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }

        }
        static void Main3()
        {
            int[,] arr = new int[3, 5];
            //int[,,] arr3d = new int[2, 3, 5];
            Console.WriteLine(arr.Rank); //no of dimensions - 2
            Console.WriteLine(arr.Length); //15
            Console.WriteLine(arr.GetLength(0)); //length of 1st dimension -  3
            Console.WriteLine(arr.GetLength(1)); //length of 2nd dimension - 5

            Console.WriteLine(arr.GetUpperBound(0)); //upper bound of 1st dimension -  2
            Console.WriteLine(arr.GetUpperBound(1)); //- 4

            //arr[0,0] arr[0,1] arr[0,2] arr[0,3] arr[0,4]
            //arr[1,0] arr[1,1] arr[1,2] arr[1,3] arr[1,4]
            //arr[2,0] arr[2,1] arr[2,2] arr[2,3] arr[2,4]

            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"Enter element no {i},{j} : ");
                    arr[i,j ] = int.Parse(Console.ReadLine());
                }
                Console.WriteLine();
            }



        }
        static void Main4()
        {
            Employee[] arr = new Employee[5];

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = new Employee();

                //arr[i].Name = Console.ReadLine();
            }
            //Employee o2 = new Employee();
            int x = 0;
            foreach (Employee item in arr)
            {
                //item = new Employee(); //not allowed
                item.Name = "changed value" + ++x;
                item.EmpNo = x;
            }

            foreach (Employee item in arr)
            {
                Console.WriteLine(item.EmpNo);
                Console.WriteLine(item.Name);
            }

        }

        static void Main()
        {
            //jagged
            int[][] arr = new int[4][];
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = new int[x]
            //}

            arr[0] = new int[3]; // arr[0][0] arr[0][1] arr[0][2]
            arr[1] = new int[4]; // arr[1][0] arr[1][1] arr[1][2] arr[1][3]
            arr[2] = new int[2];//  arr[2][0] - arr [2][1]
            arr[3] = new int[3];//  arr[3][0] arr[3][1] arr[3][2]

            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.Write("enter value for subscript [{0}][{1}] : ", i, j);
                    arr[i][j] = Convert.ToInt32(Console.ReadLine());
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 0; j < arr[i].Length; j++)
                {
                    Console.WriteLine("value for subscript {0},{1} is {2}  ", i, j, arr[i][j]);

                }
            }
            Console.ReadLine();
        }


    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }

    }
}
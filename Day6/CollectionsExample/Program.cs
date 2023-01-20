using System.Collections;
namespace CollectionsExample
{
    internal class Program
    {
        static void Main1()
        {
            ArrayList objArrayList = new ArrayList();
            objArrayList.Add(10);
            objArrayList.Add("aaaa");
            objArrayList.Add(true);
            objArrayList.Add(10.123);

            objArrayList.Insert(0, "inserted");
            //objArrayList.AddRange(objArrList2)
            //objArrayList.InsertRange(0, objArrList2);

            //objArrayList.Remove(10); //object
            //objArrayList.RemoveAt(10); //index 10
            //objArrayList.RemoveRange(3,5) // 3,4,5,6,7

            //objArrayList.IndexOf
            //objArrayList.LastIndexOf
            //objArrayList.BinarySearch


            //objArrayList.Clear(); //delete all

            //objArrayList.Clone -- to read *************
            bool isPresent = objArrayList.Contains(10);
            object[] obj = new object[objArrayList.Count];
            objArrayList.CopyTo(obj);
            object[] obj2 = objArrayList.ToArray();

            ArrayList al2 = objArrayList.GetRange(0, 3);//index, count
            objArrayList.SetRange(0, al2); //overwrites objArrayList wth values from al2
            Console.WriteLine(objArrayList[0]);//objArrayList.this[0]
            Console.WriteLine(objArrayList[1]);

            Console.WriteLine(objArrayList.Count);
            foreach (object item in objArrayList)
            {
                Console.WriteLine(item);
            }

           //objArrayList.Capacity = 10;  
           //allocate a large capacity to avoid multiple reallocation of memory (specially in a loop)
           
            //add objects here (in a loop)
            
            //objArrayList.TrimToSize();
            //remove te extra capacity that is not required
        }

        static void Main2()
        {
            //Hashtable objDictionary = new Hashtable();
            SortedList objDictionary = new SortedList();
            objDictionary.Add(30, "Abhi");
            objDictionary.Add(10, "Shubham");
            objDictionary.Add(20, "Omkar");
            objDictionary[40] = "Aakash";
            objDictionary[10] = "changed";

            //objDictionary.Remove(20); //key = 20
            //objDictionary.RemoveAt(2); //index = 2

            bool isPresent;
            isPresent = objDictionary.Contains(20); //key
            isPresent = objDictionary.ContainsKey(20); //key
            isPresent = objDictionary.ContainsValue("Omkar"); //value

            //objDictionary.CopyTo
            objDictionary.GetByIndex(0);//value at index 0
            objDictionary.GetKey(0); //key at index 0
            IList objKeys = objDictionary.GetKeyList();
            foreach (object item in objKeys)
            {

            }
            IList objvalues = objDictionary.GetValueList();

            ICollection objColl = objDictionary.Keys;
            //objColl = objDictionary.Values;
            foreach (object item in objColl)
            {

            }
            //objDictionary.IndexOfKey(10)
            //objDictionary.IndexOfValue("Omkar")

            objDictionary.SetByIndex(0, "new value");

            foreach (DictionaryEntry item in objDictionary)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }


        }

        static void Main3()
        {
            Stack s = new Stack();
            s.Push(10);
            Console.WriteLine(s.Peek());
            Console.WriteLine(s.Pop());

            Queue q = new Queue();
            q.Enqueue(10);
            Console.WriteLine(q.Peek());
            Console.WriteLine(q.Dequeue());
        }


        static void Main4()
        {
            List<int> list1 = new List<int>();
            list1.Add(10);

            foreach (int item in list1)
            {

            }

            List<string> list2 = new List<string>();
            list2.Add("aaa");
            foreach (string item in list2)
            {

            }
            List<Employee> list3 = new List<Employee>();
            list3.Add(new Employee { EmpNo = 1, Name = "Shubham" });
            list3.Add(new Employee { EmpNo = 2, Name = "Omkar" });
            list3.Add(new Employee { EmpNo = 3, Name = "Abhi" });
            list3.Add(new Employee { EmpNo = 4, Name = "Sky" });

            foreach (Employee item in list3)
            {
                Console.WriteLine(item.EmpNo);
                Console.WriteLine(item.Name);
            }
        }
        static void Main5()
        {
            SortedList<int, Employee> objSortedList = new SortedList<int, Employee>();
            objSortedList.Add(1, new Employee { EmpNo = 1, Name = "Shubham" });
            objSortedList.Add(2, new Employee { EmpNo = 2, Name = "Omkar" });
            objSortedList.Add(3, new Employee { EmpNo = 3, Name = "Abhi" });
            objSortedList.Add(4, new Employee { EmpNo = 4, Name = "Sky" });

            foreach (KeyValuePair<int, Employee> item in objSortedList)
            {
                Console.WriteLine( item.Key );
                Console.WriteLine( item.Value.Name);
            }
        }
        static void Main()
        {
            Stack<int> s = new Stack<int>();
            Queue<string> q = new Queue<string>();
        }
    }

    public class Employee
    {
        public int EmpNo { get; set; }
        public string Name { get; set; }

    }
}
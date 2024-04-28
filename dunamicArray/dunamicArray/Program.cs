namespace dunamicArray
    {
    internal class Program
        {

        static void Main(string[] args)
            {
            var list1 = new DunamArray();
            list1.Add(3);
            list1.Add(52);
            list1.Add("string");
            list1.Add(new int[] { 4, 8 });
            list1.Insert(3, "Inswrt");
            list1.Remove(52);
            list1.RemoveAt(1);
            //list1.Clear();
            Console.WriteLine(list1);
            Console.WriteLine(list1.Contains("string"));
            Console.WriteLine(list1.Contains(456));
            Console.WriteLine(list1.IndexOf("string"));
            Console.WriteLine(list1.IndexOf(0));
            var list2 = new DunamArray(); 
            list2.Add(1);
            list2.Add(2);
            list2.Add(3);
            list2.Add(4);
            list2.Reverse();

            var list3 = new DunamArray();
            object[] arr1 = { 2, 8, 9 };
            list3.Items = arr1;

            }
        }
    }

namespace LinkedList
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            SinglyLinkedList myList = new SinglyLinkedList();
            myList.Add(1);
            myList.Add(2);
            myList.Add(3);
            myList.AddFirst(7);
            myList.PrintList();

           // myList.RemoveFirst();

            myList.PrintList();
            //myList.removeLast();
            //myList.Clear();
        var arr = myList.ToArray();
            Console.ReadLine();
            }
        }
    }

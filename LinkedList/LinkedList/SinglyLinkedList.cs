using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedList
    {
    public class Node
        {
        public object Data;
        public Node Next;

        public Node First { get; }
        public Node Count { get; }
        public Node Last { get; }

        public Node(object data)
            {
            Data = data;
            Next = null;
            }
        }
    public class SinglyLinkedList
        {
        private Node head;
        public SinglyLinkedList()
            {
            head = null;
            }
        public void Add(object data)
            {
            Node newNode = new Node(data);

            if (head == null)
                {
                head = newNode;
                }
            else
                {
                Node current = head;
                while (current.Next != null)
                    {
                    current = current.Next;
                    }

                current.Next = newNode;
                }
            }
        public void AddFirst(object data) 
            {
            Node newNode = new Node(data);
            newNode.Next = head;
            head = newNode;
            }
        public Node RemoveFirst()
            {
            Node temp = head;
            head = head.Next;
            return temp;
            }
        public void removeLast()
            {
            if (head == null)
                {
                Console.WriteLine("List is empty.");
                return;
                }

            if (head.Next == null)
                {
                head = null;
                return;
                }

            Node current = head;
            while (current.Next.Next != null)
                {
                current = current.Next;
                }

            current.Next = null;
            }
        public void Clear()
            {
            head = null;
            }
        public void PrintList()
            {
            Node current = head;
            while (current != null)
                {
                Console.WriteLine(current.Data);
                current = current.Next;     
                }
            }

        public bool Contains(object data)
            {
            Node current = head;
            while (current != null)
                {
                if (current.Data.Equals(data))
                    {
                    return true;
                    }
                current = current.Next;
                }
            return false;
            }
        public object[] ToArray()
            {
            if (head == null)
                {
                return new object[0];
                }

            int count = 0;
            Node current = head;
            while (current != null)
                {
                count++;
                current = current.Next;
                }

            object[] array = new object[count];
            current = head;
            int index = 0;
            while (current != null)
                {
                array[index] = current.Data;
                index++;
                current = current.Next;
                }

            return array;
            }

        void Iterate() 
            { 
                Node current = head;
            while(current != null )
                {
                current = current.Next;
                }
            }

        }

    }

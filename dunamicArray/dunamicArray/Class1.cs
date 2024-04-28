using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace dunamicArray
    {
    internal class DunamArray
        {
        public object[] items;
        int _size;

        public object[] Items
            {
            get
                {
                if (items != null) return items;
                else throw new NullReferenceException();
                }
            set
                {
                if (value != null) items = value;
                }
            }
        public  int Count { get { return _size; } }
        public DunamArray() { }
        public DunamArray(int capacity) 
            {
               Items = new object[capacity];
               _size = capacity;
            }

        public void Add(object item) 
            {
            if (item is null) throw new ArgumentNullException(nameof(item), "argument cannot be null");
                {
                if (items == null) 
                    { 
                    items = new object[]{item};
                    _size = items.Length;
                    }
                else
                    {
                    var arr = new object[_size + 1];
                    for (int i = 0; i < _size; i++)
                        {
                        arr[i] = items[i];
                        arr[_size] = item;
                        }
                    items = arr;
                    _size = arr.Length;
                    }
                }
            }     
        public void Insert(int index, object item) 
            {

            if (item == null) throw new Exception("index must be positive and the item not equal null");
            if (0 <= index && index < items.Length)
                {
                var arr = new object[items.Length+1]; 
                { 
                   for(int i = 0; i < items.Length; i++)
                        {
                        if(i == index) 
                            {
                            arr[i] = item;
                            while(i < items.Length) 
                                {
                                  arr[i + 1] = items[i];
                                i++;
                                }
                            }
                        else arr[i] = items[i];
                        }
                    items = arr;
                    _size = arr.Length;
                    };
                } 
            else 
                {
                throw new ArgumentOutOfRangeException(nameof(_size), "Argument must be 0 < index && index < _size ");
                }
            }
        public void Remove(object item)
            {
            if (item == null) throw new Exception("item can not equal null");
            var arr = new object[items.Length - 1];
            for (int i = 0; i < items.Length; i++)
                {
                if (items[i].GetHashCode() == item.GetHashCode())
                    {
                    while (i < items.Length - 1)
                        {
                        arr[i] = items[i + 1];
                         i++;
                        }
                    }
                else arr[i] = items[i];
                }
            items = arr;
            _size = arr.Length;
            }
        public void RemoveAt(int index) 
            {
             if (0 <= index && index < items.Length) 
                {
                var arr = new object[items.Length - 1];
                for (int i = 0; i < items.Length; i++) 
                    { 
                        if(index == i)
                        {
                        while (i < items.Length - 1)
                            {
                            arr[i] = items[i + 1];
                            i++;
                            }
                        }
                    }
                 }
            else
                {
                throw new ArgumentOutOfRangeException(nameof(_size), "Argument must be 0 < index && index < _size ");
                }
            }
        public void Clear()
            {
            var arr = new object[0];
            items = arr;
            _size = 0;

            }
        public bool Contains(object item) 
            {
            if (item == null) throw new Exception("item can not equal null");
            bool seachItem = false;
            for(int i = 0; i< items.Length; i++)
                {
                if (items[i].Equals(item)) seachItem = true;
                }
            return seachItem;
            }
       public int IndexOf(object item) 
            {
            if (item == null) throw new Exception("item can not equal null");
            int index = -1;
             for (int i = 0; i < items.Length; i++)
                {
                if (items[i].Equals(item)) index = 1;
                }
            return index; 
            }
        public void Reverse()
            {
            var arr = new object[items.Length];
            int i = 0;
            for (int j = arr.Length-1; j>=0 ; j--)
                {
                arr[i] = items[j];
                i++;
                }
            items = arr;
            }


        }
    }


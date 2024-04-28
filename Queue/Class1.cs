using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Queue
    {
    using System;
    using System.Collections.Generic;

    public class CustomQueue<T>
        {
        private List<T> queue = new List<T>();

        public void Enqueue(T item)
            {
            queue.Add(item);
            }

        public T Dequeue()
            {
            if (queue.Count == 0)
                {
                throw new InvalidOperationException("Queue is empty");
                }

            T item = queue[0];
            queue.RemoveAt(0);
            return item;
            }

        public void Clear()
            {
            queue.Clear();
            }

        public bool Contains(T item)
            {
            return queue.Contains(item);
            }

        public T Peek()
            {
            if (queue.Count == 0)
                {
                throw new InvalidOperationException("Queue is empty");
                }

            return queue[0];
            }

        public T[] ToArray()
            {
            return queue.ToArray();
            }

        public int Count
            {
            get { return queue.Count; }
            }
        }

    }

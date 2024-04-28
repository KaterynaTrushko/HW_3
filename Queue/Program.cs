namespace Queue
    {
    internal class Program
        {
        static void Main(string[] args)
            {
            var queue = new CustomQueue<int>();
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(1);
            queue.Contains(2);
            int a = queue.Count;
            queue.Clear();
            }
        }
    }

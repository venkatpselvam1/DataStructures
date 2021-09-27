using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _002_PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            Demo();
            //Time Complexity
            // Enqueue  - O(Log n)
            // Dequeue  - O(Log n)
            // Peek     - O(1)
        }
        public static void Demo()
        {
            var q = new PriorityQueue<int>();
            q.Enqueue(5, 1);
            q.Enqueue(6, 1);
            q.Enqueue(7, 2);
            q.Enqueue(8, 1);
            q.Enqueue(9, 1);
            q.Enqueue(10, 3);
            Console.WriteLine("Peek : " + q.Peek());
            while (q.Count > 0)
            {
                var n = q.Dequeue();
                Console.WriteLine(n);
            }
        }
    }

}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _001_PriorityQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * In this session, we will implement priority queue using linked lists.
             * When using the linked list, the highest priority node will be on top(head) of the linked list 
             * and all the other elements are arranged in sorting orders.
             */
            Demo();
            //Time Complexity
            // Enqueue  - O(n)
            // Dequeue  - O(1)
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

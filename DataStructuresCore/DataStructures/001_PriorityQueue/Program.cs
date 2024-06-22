// See https://aka.ms/new-console-template for more information

using _001_PriorityQueue;

var q = new VenkatPriorityQueue<int>();
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
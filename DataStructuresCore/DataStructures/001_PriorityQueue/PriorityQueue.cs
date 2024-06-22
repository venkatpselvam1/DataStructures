namespace _001_PriorityQueue;
public class VenkatPriorityQueue<T>
{
    Node<T> Head;
    public int Count { get; private set; }
    public void Enqueue(T newVal, int priority)
    {
        Count++;
        var newN = new Node<T>();
        newN.Value = newVal;
        newN.Priority = priority;
        if (Head == null)
        {
            Head = newN;
        }
        else if (Head.Priority < newN.Priority)
        {
            newN.Next = Head;
            Head = newN;
        }
        else
        {
            var curr = Head;
            while (curr != null)
            {
                if (curr.Next == null || curr.Next.Priority < newN.Priority)
                {
                    newN.Next = curr.Next;
                    curr.Next = newN;
                    break;
                }
                curr = curr.Next;
            }
        }
    }

    public T Dequeue()
    {
        var val = Head.Value;
        Head = Head.Next;
        Count--;
        return val;
    }

    public T Peek()
    {
        return Head.Value;
    }
}
public class Node<T>
{
    public T Value;
    public int Priority;
    public Node<T> Next;
}
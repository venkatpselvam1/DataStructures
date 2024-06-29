// See https://aka.ms/new-console-template for more information

using CommonUtils;

// var arr = new Array(1_000_000_000);
// var list = new ListV(1_000_000_000);
var len = 1_000_000_000;
var arr = new int[len];
var list = new List<int>();
var listVenkat = new LinkedListVenkat();
for (int i = 0; i < len; i++)
{
    arr[i] = i;
    list.Add(i);
    listVenkat.Insert(i);
}
// Console.WriteLine(list.Count);
Console.WriteLine("Hello, World!");
MeasureUtils.MeasureTime(() => arr[len/2] = 2);
MeasureUtils.MeasureTime(() => list.Insert(len/2, 2));

MeasureUtils.MeasureTime(() => Console.WriteLine(arr[len/3]));
MeasureUtils.MeasureTime(() => Console.WriteLine(list[len/3]));
MeasureUtils.MeasureTime(() => Console.WriteLine(listVenkat.Get(len/3)));

public class LinkedListVenkat
{
    private Node head;
    private Node tail;
    private int size = 0;

    public void Insert(int v)
    {
        if (head == null)
        {
            head = new Node(v);
            tail = head;
        }
        else
        {
            tail.Next = new Node(v);
            tail = tail.Next;
        }

        size += 1;
    }

    public int Get(int ind)
    {
        if (ind >= size) throw new Exception("out of bound");
        var curr = head;
        while (ind > 0)
        {
            ind--;
            curr = curr.Next;
        }

        return curr.Val;
    }
}
public class Node
{
    public int Val;
    public Node Next;

    public Node(int v, Node n = null)
    {
        this.Val = v;
        this.Next = n;
    }
}
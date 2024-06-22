namespace _001_SegmentTree;

public class SegmentTreeTest
{
    public static void TestSegmentTree()
    {
        var seg = new Solution.SegmentTreeMax(1, 10);
        //seg.print();

        Console.WriteLine("1-10 => " + seg.query(1, 10));
        Console.WriteLine("5-10 => " + seg.query(5, 10));
        Console.WriteLine("0-100 => " + seg.query(0, 100));
        Console.WriteLine("0-11 => " + seg.query(0, 11));

        seg.update(2, 2);

        Console.WriteLine("1-10 => " + seg.query(1, 10));
        Console.WriteLine("5-10 => " + seg.query(5, 10));
        Console.WriteLine("0-100 => " + seg.query(0, 100));
        Console.WriteLine("0-11 => " + seg.query(0, 11));
        seg.update(1, 5);
        Console.WriteLine("1-10 => " + seg.query(1, 10));
        Console.WriteLine("5-10 => " + seg.query(5, 10));
        Console.WriteLine("0-100 => " + seg.query(0, 100));
        Console.WriteLine("0-11 => " + seg.query(0, 11));
        seg.print();
    }
}
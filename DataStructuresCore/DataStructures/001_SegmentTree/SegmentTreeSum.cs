namespace _001_SegmentTree;

public class SegmentTreeSum
{
    int start, end;
    int val;
    SegmentTreeSum left, right;
    public SegmentTreeSum(int s, int e)
    {
        this.start = s;
        this.end = e;
        if (s == e) return;
        var m = (s + e + 1) / 2;
        this.left = new SegmentTreeSum(s, m-1);
        this.right = new SegmentTreeSum(m, e);
    }
    public int query(int s, int e)
    {
        if(end < s || e < s )
        {
            return 0;
        }
        if (s <= start && end <= e) return val;
        return left.query(s, e) + right.query(s,e);
    }
    public int update(int ind, int v)
    {
        if(ind < start || end < ind)
        {
            return val;
        }
        if(start == end && start == ind)
        {
            this.val = v;
            return val;
        }
        var l = left.update(ind, v);
        var r = right.update(ind, v);
        val = l + r;
        return val;
    }
    public void print()
    {
        Console.WriteLine(start+"-"+end+"="+val);
        if(left != null) left.print();
        if(right != null) right.print();
    }
}
namespace _001_SegmentTree;

public class Solution
{
    public int LengthOfLIS(int[] nums, int k)
    {
        var seg = new SegmentTreeMax(1, 100000);
        var ans = 0;
        foreach (var num in nums)
        {
            var v = seg.query(num - k, num - 1);
            seg.update(num, v + 1);
            ans = Math.Max(ans, v + 1);
        }
        return ans;
    }
    public class SegmentTreeMax
    {
        int start, end, val;
        SegmentTreeMax left, right;
        public SegmentTreeMax(int s, int e)
        {
            this.start = s;
            this.end = e;
            if (s == e) return;
            var m = (s + e + 1) / 2;
            this.left = new SegmentTreeMax(s, m - 1);
            this.right = new SegmentTreeMax(m, e);
        }
        public int query(int s, int e)
        {
            if (end < s || e < start) return 0;
            if (s <= start && end <= e) return val;
            return Math.Max(left.query(s, e), right.query(s, e));
        }
        public int update(int ind, int v)
        {
            if (start == end && start == end)
            {
                this.val = v;
                return val;
            }
            if (ind < start || end < ind) return 0;
            var l = left.update(ind, v);
            var r = right.update(ind, v);
            this.val = Math.Max(l, r);
            return val;
        }
        public void print()
        {
            Console.WriteLine(start + "-" + end + "=" + val);
            if (left != null) left.print();
            if (right != null) right.print();
        }
    }
}
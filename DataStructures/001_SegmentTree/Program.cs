using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace _001_SegmentTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            problem();
            //TestSegMentTree();
        }

        private static void TestSegMentTree()
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

        private static void problem()
        {
            var sln = new Solution();
            var arr = new int[] { 4, 2, 1, 4, 3, 4, 5, 8, 15 };
            var ans = sln.LengthOfLIS(arr, 3);
            System.Console.WriteLine("ans " + ans);
        }
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
        class Solution
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
    }
}

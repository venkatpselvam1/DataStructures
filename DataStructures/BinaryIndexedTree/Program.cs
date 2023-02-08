using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryIndexedTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //https://www.geeksforgeeks.org/binary-indexed-tree-or-fenwick-tree-2/
            var arr = new int[65];
            for(int i = 0; i < 65; i++)
            {
                arr[i] = i + 1;
            }
            var bt = new BinaryIndexedTree(arr);
            for(int i = 0; i < arr.Length;i++)
            {
                Console.WriteLine("sum upto "+i+"th ind " + bt.getSum(i));
            }
            
        }
        public class BinaryIndexedTree
        {
            int[] bit;
            int len;
            public BinaryIndexedTree(int[] arr)
            {
                this.len = arr.Length;
                bit = new int[len+1];
                for(int i= 0; i < len; i++)
                {

                    update(i, arr[i]);
                }
            }
            public int getSum(int ind)
            {
                Console.WriteLine("for the ind " + ind + ": ");
                var sum = 0;
                ind++;
                while(ind > 0)
                {
                    Console.Write(ind + ",");
                    sum += bit[ind];
                    ind -= (ind & -ind);
                }
                Console.WriteLine();
                return sum;
            }
            public void update(int ind, int diff)
            {
                Console.WriteLine("for the ind "+ind+": ");
                ind++;
                while(ind  <= len)
                {
                    Console.Write(ind+",");
                    bit[ind] += diff;
                    ind += (ind & -ind);
                }
                Console.WriteLine();
            }
        }
    }
}

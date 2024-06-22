// See https://aka.ms/new-console-template for more information

//https://www.geeksforgeeks.org/binary-indexed-tree-or-fenwick-tree-2/
var arr = new int[65];
for(int i = 0; i < 65; i++)
{
    arr[i] = i + 1;
}
var bt = new BinaryIndexedTree.BinaryIndexedTree(arr);
for(int i = 0; i < arr.Length;i++)
{
    Console.WriteLine("sum upto "+i+"th ind " + bt.getSum(i));
}
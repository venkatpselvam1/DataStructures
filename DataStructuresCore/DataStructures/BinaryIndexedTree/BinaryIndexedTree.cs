namespace BinaryIndexedTree;

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
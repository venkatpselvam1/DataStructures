namespace _002_PriorityQueue;

    public class VenkatPriorityQueue<T>
    {
        Node<T>[] arr = new Node<T>[50];
        int emptyInd = 0;
        public int Count => emptyInd;

        public void Enqueue(T val, int priority)
        {
            var newN = new Node<T>();
            newN.Priotiy = priority;
            newN.Val = val;
            arr[emptyInd] = newN;
            emptyInd++;
            ShiftUp(emptyInd-1);
        }

        public T Dequeue()
        {
            var val = arr[0].Val;
            arr[0] = arr[emptyInd-1];
            emptyInd--;
            ShiftDown(0);
            return val;
        }
        public T Peek()
        {
            return arr[0].Val;
        }
        private void ShiftUp(int ind)
        {
            if (ind == 0)
            {
                return;
            }
            var parent = GetParent(ind);
            ShiftDown(parent);
            ShiftUp(parent);
        }
        private void ShiftDown(int ind)//heapify node
        {
            var largestInd = ind;
            var left = GetLeft(ind);
            var right = GetRight(ind);
            if (left < emptyInd && arr[left].Priotiy > arr[largestInd].Priotiy)
            {
                largestInd = left;
            }
            if (right < emptyInd && arr[right].Priotiy > arr[largestInd].Priotiy)
            {
                largestInd = right;
            }
            if (largestInd != ind)
            {
                Swap(largestInd, ind);
                ShiftDown(largestInd);
            }
        }
        private int GetLeft(int n)
        {
            return 2 * n + 1;
        }
        private int GetRight(int n)
        {
            return 2 * n + 2;
        }
        private int GetParent(int n)
        {
            return (n-1)/2;
        }
        public void Swap(int i, int j)
        {
            if (i != j)
            {
                (arr[i], arr[j]) = (arr[j], arr[i]);
            }
        }
    }

    public class Node<T>
    {
        public int Priotiy;
        public T Val;
    }
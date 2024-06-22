namespace _001_CountNiceSubArray;

class Solution {
    public int NumberOfSubarrays(int[] nums, int k) {
        var ans = 0;
        var n = nums.Length;
        var oddCount = GetOddCount(nums);
        if(oddCount == 0) return ans;
        var list = new int[oddCount];
        var revList = new int[oddCount];
        var evenCount = 0;
        var revEvenCount = 0;
        var listInd = 0;
        var revListInd = oddCount-1;
        for(int i = 0; i < n; i++)
        {
            if(nums[i]%2==0)
            {
                evenCount+=1;
            }else{
                list[listInd] = evenCount + 1;
                evenCount=0;
                listInd+=1;
            }

            if(nums[n-1-i]%2==0)
            {
                revEvenCount+=1;
            }else{
                revList[revListInd] = revEvenCount + 1;
                revEvenCount=0;
                revListInd-=1;
            }
        }
        // printList(list);
        // Collections.reverse(revList);
        // printList(revList);
        // var len = list.length;
        for(int i = 0; i < oddCount-k+1; i++)
        {
            // System.out.println(i+" - "+(i+k-1));
            ans+=list[i] * revList[i+k-1];
        }
        return ans;
    }
    private int GetOddCount(int[] arr)
    {
        var ans = 0;
        foreach (var item in arr)
        {
            if(item%2==1) ans+=1;
        }

        return ans;
    }
    
}
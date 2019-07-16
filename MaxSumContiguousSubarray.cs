/* Max Sum Contiguous Subarray*/
class Solution {
    public int maxSubArray(List<int> A) {
        
        var sum = 0;
        int Maxsum = int.MinValue;
        int start = 0;
        int end = 0;
        for (int i = 0; i < A.Count; i++ )
        {
            sum = sum + A[i];
            if(A[i]>sum)
            {
                start = i;
                end = i;
                sum = A[i];
            }
            if(sum > Maxsum)
            {
                Maxsum = sum;
                end = i;
            }
          
            
             
        }
        
        return Maxsum;
    }
}

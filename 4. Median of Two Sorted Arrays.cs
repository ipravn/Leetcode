public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        double median = 0;
        double[] temp = new double[nums1.Length + nums2.Length];
        
        for (int i = 0; i < nums1.Length+nums2.Length; i++)
        {
            if (i < nums1.Length)
            {
                temp[i] = nums1[i];
            }
            else
            {
                temp[i] = nums2[i - nums1.Length];
            }
        }
        
        Array.Sort(temp);
        
        if (temp.Length%2 == 1)
        {
            median = temp[temp.Length / 2];
        }
        if (temp.Length%2==0)
        {
            int mid = temp.Length / 2;
            median = (temp[mid-1] + temp[mid]) / 2;
        }
        
        return median;
    }
}

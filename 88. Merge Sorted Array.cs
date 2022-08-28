public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int tempLength = m + n;
            int[] temp = new int[tempLength];
            for (int i = 0; i < m; i++)
            {
                temp[i] = nums1[i];
            }

            for (int i = 0; i < n; i++)
            {
                temp[m + i] = nums2[i];
            }
            Array.Sort(temp);
            for (int i = 0; i < temp.Length; i++)
            {
                nums1[i] = temp[i];
            }
            
            Console.WriteLine(String.Join(",",nums1));
    }
}

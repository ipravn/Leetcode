public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        ArrayList al = new ArrayList();
      int count = 0;
      for (int i = 0; i < nums1.Length; i++)
      {
        for (int j = 0; j < nums2.Length; j++)
        {
          if (nums1[i] == nums2[j])
          {
            al.Add(nums1[i]);
            count++;
            break;
          }
        }
      }
      int[] arr = new int[count];
      al.CopyTo(arr, 0);
      int[] unique = arr.Distinct().ToArray();
      return unique;
    }
}

public class Solution {
    public int[] SortArray(int[] nums) {
        // Using Insertion Sort
        int temp = 0;
      for (int i = 0; i < nums.Length - 1; i++)
      {
        for (int j = i + 1; j > 0; j--)
        {
          if (nums[j] < nums[j -1])
          {
            temp = nums[j];
            nums[j] = nums[j-1];
            nums[j-1] = temp;
          }
          else
          {
            break;
          }
        }
      }

      return nums;
    }
}

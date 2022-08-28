public class Solution {
    public int Search(int[] nums, int target) {
        if (nums.Length == 0)
            {
                return -1;
            }
            for (int i = 0; i < nums.Length; i++)
            { 
                int element = nums[i];
                if (element == target)
                { 
                    return i;
                }
            }
            return -1;
    }
}

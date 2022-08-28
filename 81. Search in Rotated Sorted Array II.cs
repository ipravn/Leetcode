public class Solution {
    public bool Search(int[] nums, int target) {
        if (nums.Length == 0)
            {
                return false;
            }
            for (int i = 0; i < nums.Length; i++)
            { 
                int element = nums[i];
                if (element == target)
                { 
                    return true;
                }
            }
            return false;
    }
}

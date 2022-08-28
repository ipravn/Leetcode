public class Solution {
    public int[] SortedSquares(int[] nums) {
        int[] temp = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                temp[i] = nums[i] * nums[i];
            }
            
            Array.Sort(temp);

            return temp;
    }
}

public class Solution {
    public int LargestRectangleArea(int[] heights) {
    int maxArea = 0;
    int currArea = 0;
    Stack<int> stack = new Stack<int>();
    for (int i = 0; i < heights.Length; i++)
    {
        if (stack.Count == 0 || heights[i] >= heights[stack.Peek()])
        {
            stack.Push(i);
        }
        else
        {
            int lastIndex = 0;
            while (stack.Count > 0 && heights[i] < heights[stack.Peek()])
            {
                lastIndex = stack.Pop();
                int width = stack.Count == 0 ? i : i - stack.Peek() - 1;
                currArea = heights[lastIndex] * width;
                maxArea = Math.Max(maxArea, currArea);
            }
            stack.Push(i);
        }
    }
    while (stack.Count > 0)
    {
        int lastIndex = stack.Pop();
        int width = stack.Count == 0 ? heights.Length : heights.Length - stack.Peek() - 1;
        currArea = heights[lastIndex] * width;
        maxArea = Math.Max(maxArea, currArea);
    }
    return maxArea;
    }
}

public class Solution 
{
    public int[] NumsSameConsecDiff(int n, int k) 
    {
        var res = new List<int>();
        
        for (int i = 1; i <= 9; i++)
        {
            DFS(n - 1, k, i, res);
        }
        
        return res.ToArray();
    }
    
    private void DFS(int n, int k, int num, IList<int> res)
    {
        if (n == 0)
        {
            res.Add(num);
            return;
        }
        
        int digit = num % 10;
        
        if (k == 0)
        {
            DFS(n - 1, k, num * 10 + digit, res);
            return;
        }
        
        if (digit + k <= 9)
        {
            DFS(n - 1, k, num * 10 + digit + k, res);
        }
        
        if (digit - k >= 0)
        {
            DFS(n - 1, k, num * 10 + digit - k, res);
        }
    }
}

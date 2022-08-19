public class Solution {
    public void Rotate(int[][] matrix) {
        List<int> al = new List<int>();
        for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = matrix[i].Length - 1; j > -1; j--)
                {
                    
                    al.Add(matrix[j][i]);
                }
            }
        
            int count = 0;
            for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length ; j++)
                {
                    matrix[i][j] = al[count];
                    count++;   
                }
            }
        
        for (int i = 0; i < matrix.Length; i++)
            {
                for (int j = 0; j < matrix[i].Length ; j++)
                {
                   Console.Write(matrix[i][j]+",");
                }
            }
        
    }
}

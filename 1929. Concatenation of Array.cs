public class Solution {
    public int[] GetConcatenation(int[] nums) {
        
    int[] newar = new int[nums.Length * 2];            
    int count = 0;                                     
    for (int i = 0; i < 2; i++)                        
    {                                                  
        for (int j = 0; j < nums.Length; j++)          
        {                                              
            newar[count] = nums[j];                    
            count++;                                   
        }                                              
    }                                                  
                                                       
    return newar;                                      
}                                                      
}

public class Solution {
    public int LengthOfLastWord(string s) {
         int lengthCount = 0;
            for (int i = s.Length-1; i > 0; i--)
            {
                if (s[i] == ' ')
                {
                    lengthCount++;
                }
                else
                {
                    break;
                }
            }

            int lengthCount1 = s.Length - lengthCount;
            
            int count = 0;
            for (int i = lengthCount1-1; i > -1; i--)
            {
                
                if (s[i] == ' ')
                {
                    break;
                }
                else
                {
                    count++;
                }
            }

            return count;
    }
}

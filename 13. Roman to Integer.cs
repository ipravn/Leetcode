public class Solution {
    private Dictionary<char,int> NumeralDictionary = new ()
    {
        {'I',1},
        {'V',5},
        {'X',10},
        {'L',50},
        {'C',100},
        {'D',500},
        {'M',1000}
    };
    
    
    public int RomanToInt(string s) 
    {
        var chars = s.ToCharArray();
        var curr = ' '; 
        var prev = ' ';
        int result = 0;
        
        for(int i = chars.Length - 1; i >= 0 ; i--)
        {
            curr = chars[i];
            NumeralDictionary.TryGetValue(curr, out int currNumeral);
            NumeralDictionary.TryGetValue(prev, out int prevNumeral);
            
            if(currNumeral < prevNumeral)
                result -= currNumeral;
            else 
                result += currNumeral;
            
            prev = curr;
        }
        return result;
    }
}

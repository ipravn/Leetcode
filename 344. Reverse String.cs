public class Solution {
    public void ReverseString(char[] s) {
        Array.Reverse(s);
        Console.WriteLine(String.Join(",",s));   
    }
}


//////////////////////////////////////////////////////////////////////////////////////


Recursion

public class Solution {
    public void Reverse(char[] s, int start, int end) {
        if(start >= end)
            return;
        
        var temp = s[start];
        s[start] = s[end];
        s[end] = temp;
        
        start++;
        end--;
        Reverse(s, start, end);
            
    }
    
    public void ReverseString(char[] s) {
        Reverse(s, 0, s.Length - 1);
    }
}

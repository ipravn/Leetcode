public class Solution {
    public bool IsPowerOfFour(int n) {
        if(n==1)
                return true;
        
            if(n<=0 || n%4 != 0)
                return false;

            return IsPowerOfFour(n / 4);
    }
}

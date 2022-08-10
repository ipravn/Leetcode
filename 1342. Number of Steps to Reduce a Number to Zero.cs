public class Solution {
    public int NumberOfSteps(int num)
        {
            return chkVal(num, 0);
        }

        public int chkVal(int numb, int count)
        {
            if (numb == 0)
            {
                return count;
            }
            else if (numb%2 == 0)
            {
                return chkVal(numb / 2, count + 1);
            }

            return chkVal(numb - 1, count + 1);
        }
}

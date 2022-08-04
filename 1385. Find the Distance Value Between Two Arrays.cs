public class Solution {
    public int FindTheDistanceValue(int[] arr1, int[] arr2, int d) {
       int val = arr1.Length;
      int NegNumber;
      for (int i = 0; i < arr1.Length; i++)
      {
        for (int j = 0; j < arr2.Length; j++)
        {
          int cal = arr1[i] - arr2[j];
          if (cal < 0)
          {
            NegNumber = System.Math.Abs(cal);
          }
          else
          {
            NegNumber = cal;
          }
          {
            if (NegNumber <= d)
            {
              val--;
              break;
            }
          }
        }
      }
      return val;
    }
}

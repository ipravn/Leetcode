public class Solution {
    public bool CheckIfPangram(string sentence) {
        SortedSet<char> alpha = new SortedSet<char>();
        for (int i = 0; i < sentence.Length; i++)
        {
            alpha.Add(sentence[i]);
        }
        int count = alpha.Count;
        if (count==26)
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

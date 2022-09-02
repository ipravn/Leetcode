/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode SwapPairs(ListNode head) {
        if (head == null)
            {
                return head;
            }
            var intList = new List<int>();
            var temp = head;
            while (temp?.val != null)
            {
                if (temp != null)
                {
                    intList.Add(temp.val);
                    temp = temp.next;
                }
            }
            if (intList.Count() > 1)
            {
                for (int i = 0; i < intList.Count - 1; i += 2)
                {
                    var tempInt = intList[i];
                    intList[i] = intList[i + 1];
                    intList[i + 1] = tempInt;
                }
            }
            if (intList.Count > 0)
            {
                intList = Enumerable.Reverse(intList).ToList();
                var newListnode = new ListNode((int)intList.FirstOrDefault());
                for (int i = 1; i < intList.Count(); i++)
                {
                    ListNode node = new ListNode();
                    node.val = (int)intList[i];
                    node.next = newListnode;
                    newListnode = node;
                    
                }
                return newListnode;
            }
            else
            {
                return default;
            }
    }
}

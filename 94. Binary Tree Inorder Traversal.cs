/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        if(root == null) 
            return new List<int>();
        
        if(root != null && root.left == null && root.right == null)
            return new List<int>(){root.val};
        
        var node = root;
        IList<int> treeList = new List<int>();
        
        if(node != null)
        traverse(node, treeList);
        
        return treeList;
            
        }
    
    public void traverse(TreeNode node, IList<int> list) {
      
        if(node.left != null)
        traverse(node.left, list);
        
        list.Add(node.val);
        
        if(node.right != null)
        traverse(node.right, list);
    }
}

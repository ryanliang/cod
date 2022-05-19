public class Solution {
    public IList<int> InorderTraversal(TreeNode root) {
        var results = new List<int>();
        DepthFirstSearch(root, results);
        return results;
    }
    
    public void DepthFirstSearch(TreeNode node, IList<int> res)
    {
        if (node == null) return;
        
        DepthFirstSearch(node.left, res);
        res.Add(node.val);
        DepthFirstSearch(node.right, res);
    }
}

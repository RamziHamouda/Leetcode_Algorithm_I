namespace Leetcode_Algorithm_I.Easy
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
    }

    public class Solution
    {
        public TreeNode MergeTrees(TreeNode root1, TreeNode root2)
        {

            if (root1 == null && root2 == null) return null;

            int val = 0;
            if (root1 != null) val += root1.val;
            if (root2 != null) val += root2.val;

            TreeNode result = new TreeNode(val, null, null);

            if (root1 != null && root1.left != null || root2 != null && root2.left != null) result.left = MergeTrees(root1?.left, root2?.left);
            if (root1 != null && root1.right != null || root2 != null && root2.right != null) result.right = MergeTrees(root1?.right, root2?.right);

            return result;

        }

    }
}

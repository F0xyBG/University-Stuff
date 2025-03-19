using System.Diagnostics.Contracts;

namespace Homework_3;


class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int x) { val = x; }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Input values seperated by commas:");
        string input = Console.ReadLine();

        TreeNode root = BuildTree(input);

        bool isBST = IsValidBST(root);

        Console.WriteLine(isBST ? "True" : "False");
    }

    static TreeNode BuildTree(string input)
    {
        if (string.IsNullOrWhiteSpace(input)) return null;

        string[] values = input.Split(',');

        if (values[0].Trim().ToLower() == "null")
        {
            return null;
        }

        TreeNode root = new TreeNode(int.Parse(values[0].Trim()));
        Queue<TreeNode> queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        int i = 1; 
        while (queue.Count > 0 && i < values.Length)
        {
            TreeNode current = queue.Dequeue();

            if (i < values.Length)
            {
                string leftVal = values[i++].Trim().ToLower();
                if (leftVal != "null")
                {
                    current.left = new TreeNode(int.Parse(leftVal));
                    queue.Enqueue(current.left);
                }
            }

            if (i < values.Length)
            {
                string rightVal = values[i++].Trim().ToLower();
                if (rightVal != "null")
                {
                    current.right = new TreeNode(int.Parse(rightVal));
                    queue.Enqueue(current.right);
                }
            }
        }

        return root;
    }
    static bool IsValidBST(TreeNode root)
    {
        return IsValidBST(root, long.MinValue, long.MaxValue);
    }

    static bool IsValidBST(TreeNode node, long minVal, long maxVal)
    {
        if (node == null)
        {
            return true;
        }

        if (node.val <= minVal || node.val >= maxVal)
        {
            return false;
        }

        return IsValidBST(node.left, minVal, node.val) &&
               IsValidBST(node.right, node.val, maxVal);
    }
}


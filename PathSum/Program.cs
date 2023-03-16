namespace PathSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string treeString = Console.ReadLine();
            Node root = Node.ParseRootFromTreeString(treeString);
            int targetSum = int.Parse(Console.ReadLine());

            Console.WriteLine(HasPathSum(root, targetSum));
        }

        public static bool HasPathSum(Node root, int targetSum)
        {
            if (root == null)
            {
                return false;
            }
            return NodeHasPathSum(root, root.Value, targetSum);
        }

        public static bool NodeHasPathSum(Node? node, int? sum, int targetSum)
        {
            if (node.Left == null && node.Right == null)
            {
                return sum == targetSum;
            }

            if (node.Left == null)
            {
                return NodeHasPathSum(node.Right, sum + node.Right.Value, targetSum);
            }

            if (node.Right == null)
            {
                return NodeHasPathSum(node.Left, sum + node.Left.Value, targetSum);
            }

            return NodeHasPathSum(node.Left, sum + node.Left.Value, targetSum) || NodeHasPathSum(node.Right, sum + node.Right.Value, targetSum);
        }
    }
}
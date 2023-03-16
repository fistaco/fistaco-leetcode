namespace PathSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string treeString = Console.ReadLine();
            Node root = Node.ParseRootFromTreeString(treeString);
            root.PrintTree();
        }
    }
}
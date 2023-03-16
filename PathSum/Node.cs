using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PathSum
{
    internal class Node
    {
        public int? Value = 0;

        public Node? Left = null;
        public Node? Right = null;

        /// <summary>
        /// Constructs a Node from a given integer and predefined children.
        /// </summary>
        /// <param name="value"></param>
        /// <param name="left"></param>
        /// <param name="right"></param>
        public Node(int? value, Node? left = null, Node? right = null)
        {
            this.Value = value;
            this.Left = left;
            this.Right = right;
        }

        /// <summary>
        /// Constructs a Node from a given input string that defines a binary tree.
        /// </summary>
        /// <param name="treeString"></param>
        public static Node ParseRootFromTreeString(string treeString)
        {
            // Parse the nodes' values and construct nodes without children
            string[] nodeValues = treeString.TrimStart('[').TrimEnd(']').Split(',');
            var nodes = new Node?[nodeValues.Length];
            for (int i = 0; i < nodeValues.Length; i++)
            {
                int? nodeVal = nodeValues[i] == "null" ? null : int.Parse(nodeValues[i]);
                nodes[i] = nodeVal == null ? null : new Node(nodeVal);
            }

            // Set children according to their known indices
            for (int i = 0; i < nodes.Length; i++)
            {
                if (nodes[i] == null) { continue;  }

                int childIdx1 = 2 * i + 1;
                int childIdx2 = 2 * i + 2;

                nodes[i].Left = childIdx1 < nodes.Length ? nodes[childIdx1] : null;
                nodes[i].Right = childIdx2 < nodes.Length ? nodes[childIdx2] : null;
            }
            return nodes[0];
        }

        public void PrintTree()
        {
            if (this.Value == null) { return; }

            string left = this.Left == null || this.Left.Value == null ? "null" : this.Left.Value.ToString();
            string right = this.Right == null || this.Right.Value == null ? "null" : this.Right.Value.ToString();
            if (left == "null" && right == "null") { return; }

            Console.WriteLine(this.Value.ToString() + $" has children {left} and {right}");
            if (this.Left != null)
            {
                this.Left.PrintTree();
            }
            if (this.Right != null)
            {
                this.Right.PrintTree();
            }
        }
    }
}

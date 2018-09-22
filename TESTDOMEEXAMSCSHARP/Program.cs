using System;

namespace TESTDOMEEXAMSCSHARP
{
    public class Node
    {
        public int Value { get; set; }

        public Node Left { get; set; }

        public Node Right { get; set; }

        public Node(int value, Node left, Node right)
        {
            Value = value;
            Left = left;
            Right = right;
        }
    }

    class Program
    {
        public static bool Contains(Node root, int value)
        {
           return root.Value == value ? 
                      true : 
                      (root.Value < value) ?
                        ((root.Right != null) && Contains(root.Right, value)) :
                            ((root.Left != null) && Contains(root.Left, value));
        }

        static void Main(string[] args)
        {
            Node n1 = new Node(1, null, null);
            Node n3 = new Node(3, null, null);
            Node n2 = new Node(2, n1, n3);
            Console.WriteLine(Contains(n2, 1));
            Console.ReadLine();
        }
    }
}

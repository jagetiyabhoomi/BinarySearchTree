namespace BinarySearchTree
{
    class Program
    {
        public static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();
            tree.Add(10);
            tree.Add(8);
            tree.Add(5);
            tree.Add(15);
            tree.Add(12);
            tree.Add(17);

            tree.TraverseTree();
        }
    }
}

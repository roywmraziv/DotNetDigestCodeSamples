// TESTS FOR BINARY SEARCH TREE
using BinarySearchTree;

var tree = new BinaryTree<int>();
tree.Insert(5);
tree.Insert(3);
tree.Insert(7);
tree.Insert(1);
tree.Insert(9);

Console.WriteLine("In-Order Traversal: " + string.Join(", ", tree.InOrderTraversal()));
Console.WriteLine("Pre-Order Traversal: " + string.Join(", ", tree.PreOrderTraversal()));
Console.WriteLine("Post-Order Traversal: " + string.Join(", ", tree.PostOrderTraversal()));
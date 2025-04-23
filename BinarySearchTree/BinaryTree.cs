namespace BinarySearchTree;

public class BinaryTree<T> where T : IComparable<T>
{
    public Node<T> Root { get; private set; }

    public BinaryTree()
    {
        Root = null;
    }
    
    public void Insert(T value)
    {
        Root = InsertRec(Root, value); // i.e. insert recursive
    }

    private Node<T> InsertRec(Node<T> node, T value)
    {
        if (node == null) 
        {
            return new Node<T>(value);
        }

        if (value.CompareTo(node.Value) < 0)
        {
            node.Left = InsertRec(node.Left, value);
        }
        else if (value.CompareTo(node.Value) > 0)
        {
            node.Right = InsertRec(node.Right, value);
        }

        return node;
    }
    
    public List<T> InOrderTraversal()
    {
        var result = new List<T>();
        InOrderRec(Root, result);
        return result;
    }

    private void InOrderRec(Node<T> node, List<T> result)
    {
        if (node != null)
        {
            InOrderRec(node.Left, result);
            result.Add(node.Value);
            InOrderRec(node.Right, result);
        }
    }

    public List<T> PreOrderTraversal()
    {
        var result = new List<T>();
        PreOrderRec(Root, result);
        return result;
    }

    private void PreOrderRec(Node<T> node, List<T> result)
    {
        if (node != null)
        {
            result.Add(node.Value);
            PreOrderRec(node.Left, result);
            PreOrderRec(node.Right, result);
        }
    }

    public List<T> PostOrderTraversal()
    {
        var result = new List<T>();
        PostOrderRec(Root, result);
        return result;
    }

    private void PostOrderRec(Node<T> node, List<T> result)
    {
        if (node != null)
        {
            PostOrderRec(node.Left, result);
            PostOrderRec(node.Right, result);
            result.Add(node.Value);
        }
    }
}


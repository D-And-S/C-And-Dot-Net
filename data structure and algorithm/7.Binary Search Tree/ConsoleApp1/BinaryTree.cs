
public class Node
{
#nullable disable
    public int value;
    public Node leftChild;
    public Node rightChild;

    public Node(int value)
    {
        this.value = value;
    }
}

public class BinaryTree
{
    private Node root;

    public void Insert(int value)
    {
        var node = new Node(value);

        if (root == null)
        {
            root = node;
            return;
        }

        var current = root;

        while (true)
        {
            if (value < current.value)
            {
                if (current.leftChild == null)
                {
                    current.leftChild = node;
                    break;
                }
                current = current.leftChild;
            }
            else
            {
                if (current.rightChild == null)
                {
                    current.rightChild = node;
                    break;
                }
                current = current.rightChild;
            }
        }
    }

    public bool Find(int value)
    {
        var current = root;

        if (current == null) throw new Exception("Null Value detected");

        while (current != null)
        {
            if (value < current.value)
            {
                current = current.leftChild;
            }
            else if (value > current.value)
            {
                current = current.rightChild;
            }
            else
            {
                return true;
            }
        }
        return false;
    }

    public static int Factorial(int n)
    {
        if (n <= 0) return 1;
        var data = n * Factorial(n - 1);
        return data;
    }


    public void TraversePreOrder()
    {
        TraversePreOrder(root);
    }
    public void TraverseInOrder()
    {
        TraverseInOrder(root);
    }
    public void TraversePostOrder()
    {
        TraversePostOrder(root);
    }

    private void TraversePreOrder(Node root)
    {
        // visit the root first
        // left child
        // right child

        if (root == null) return;
        Console.WriteLine(root.value);
        TraversePreOrder(root.leftChild);
        TraversePreOrder(root.rightChild);
    }

    private void TraverseInOrder(Node node)
    {
        // left child
        // visit the root first
        // right child
        if (root == null) return;
        TraversePreOrder(root.leftChild);
        Console.WriteLine(root.value);
        TraversePreOrder(root.rightChild);
    }

    private void TraversePostOrder(Node node)
    {
        // left child 
        // right child
        // visit the root first
        if (root == null) return;
        TraversePreOrder(root.leftChild);
        TraversePreOrder(root.rightChild);
        Console.WriteLine(root.value);
    }

    public int Height()
    {
        return Height(root);
    }

    private int Height(Node root)
    {
        if (root == null) return -1;

        if(root.leftChild == null && root.rightChild == null) return 0;

        var left = Height(root.leftChild);
        var right = Height(root.rightChild);

        if (left > right)
        {         
            return left + 1;
        }
        else
        {
            return right + 1;
        }

        // var data = 1 + Math.Max(Height(root.leftChild), Height(root.rightChild));
    }
}
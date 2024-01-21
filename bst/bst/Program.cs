using System;

public class Node
{
    public int Data { get; private set; }
    public Node Left { get; set; }
    public Node Right { get; set; }

    public Node(int data)
    {
        Data = data;
        Left = null;
        Right = null;
    }

    public void Insert(int data)
    {
        if (data < Data)
        {
            if (Left == null)
            {
                Left = new Node(data);
            }
            else
            {
                Left.Insert(data);
            }
        }
        else
        {
            if (Right == null)
            {
                Right = new Node(data);
            }
            else
            {
                Right.Insert(data);
            }
        }
    }

    public Node Contains(int data)
    {
        if (data == Data)
        {
            return this;
        }

        if (data < Data && Left != null)
        {
            return Left.Contains(data);
        }
        else if (data > Data && Right != null)
        {
            return Right.Contains(data);
        }
        else
        {
            return null;
        }
    }
}

class Program
{
    static void Main()
    {
        Node root = new Node(10);
        root.Insert(5);
        root.Insert(15);
        root.Insert(17);

        Console.WriteLine(root.Left?.Data);
        Console.WriteLine(root.Right?.Data);

        Node three = root.Left?.Left?.Right;
        if (three != null)
        {
            Console.WriteLine(root.Contains(3) == three);
        }

        Console.WriteLine(root.Contains(9999) == null);
    }
}
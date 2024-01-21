using System;
using System.Collections.Generic;

public class Queue
{
    private Queue<int> elements;

    public Queue()
    {
        elements = new Queue<int>();
    }

    public void Add(int element)
    {
        elements.Enqueue(element);
    }

    public int Remove()
    {
        if (IsEmpty())
        {
            throw new InvalidOperationException("Queue is empty.");
        }
        return elements.Dequeue();
    }

    public bool IsEmpty()
    {
        return elements.Count == 0;
    }
}

class Program
{
    static void Main()
    {
        Queue q = new Queue();
        q.Add(1);
        q.Add(2);

        Console.WriteLine(q.Remove());
        Console.WriteLine(q.Remove());

        try
        {
            Console.WriteLine(q.Remove()); 
        }
        catch (InvalidOperationException e)
        {
            Console.WriteLine(e.Message);
        }
    }
}
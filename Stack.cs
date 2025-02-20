using System;

public class Stack
{
    private Node top;


    public Stack()
    {
        this.top = null;
    }

    public void Push(int block)
    {
        Node newNode = new Node(block, top);

        top = newNode;

    }

    public int Pop()
    {
        if (top == null)
        {
            throw new EmptyERROR(); 
        }
        else
        {
            int block = top.Dato;
            top = top.Next;
            return block;
        }
    }

    public int Peek()
    {
        if (top == null)
        {
            throw new EmptyERROR();
        }
        else
        {
            return top.Dato;
        }

    }

    public bool Empty()
    {
        return top == null;
    }

    public void Print()
    {
        if (top == null)
        {
            Console.WriteLine("The stack is empty.");
            return;
        }

        Node current = top;
        Console.WriteLine("Order of blocks: ");

        while (current != null)
        {
            Console.WriteLine(current.Dato);
            current = current.Next;
        }
        Console.WriteLine("---");
    }


}

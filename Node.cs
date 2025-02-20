using System;

public class Node
{
    private int dato;
    private Node next;


    public Node(int block)
    {
        this.dato = block;
        this.next = null;
    }


    public Node(int block, Node nextNode)
    {
        this.dato = block;
        this.next = nextNode;
    }

    public int Dato
    {
        get { return this.dato; }
        set { this.dato = value; }
    }

    public Node Next
    {
        get { return this.next; }
        set { this.next = value; }
    }
}


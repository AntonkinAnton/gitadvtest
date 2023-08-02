using System;

class Node
{
    public int Data;
    public Node Prev;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Prev = null;
        Next = null;
    }
}

class DoubleLinkedList
{
    private Node head;
    private Node tail;

    public DoubleLinkedList()
    {
        head = null;
        tail = null;
    }

    public void Enqueue(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
            tail = newNode;
        }
        else
        {
            newNode.Prev = tail;
            tail.Next = newNode;
            tail = newNode;
        }
    }

    public void Reverse()
    {
        Node current = head;
        Node temp = null;

        while (current != null)
        {
            temp = current.Prev;
            current.Prev = current.Next;
            current.Next = temp;
            current = current.Prev;
        }

        if (temp != null)
        {
            tail = head;
            head = temp.Prev;
        }
    }

    public void PrintList()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        DoubleLinkedList list = new DoubleLinkedList();
        list.Enqueue(1);
        list.Enqueue(2);
        list.Enqueue(3);
        list.Enqueue(4);

        Console.WriteLine("Оригинальный список:");
        list.PrintList();

        list.Reverse();
        Console.WriteLine("Развернутый список:");
        list.PrintList();
    }
}

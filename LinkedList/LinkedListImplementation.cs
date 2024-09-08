using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingDemo.LinkedList;

public class LinkedListImplementation
{
    public class Node
    {
        internal int Data; //Data to store (could be int,string,object etc)
        internal Node NextElement; //Pointer to next element

        public Node()
        {
            //Constructor to initialize nextElement of newlyCreated Node
            NextElement = null;
        }
    };
    Node Head;

    public LinkedListImplementation()
    {
        Head = null;
    }
    public bool IsEmpty()
    {
        if (Head == null) //Check whether the head points to null
            return true;
        else
            return false;
    }
    //Function inserts a value/new Node as the first Element of list
    public void InsertAtHead(int value)
    {
        Node newNode = new Node(); //creating a new node
        newNode.Data = value;
        newNode.NextElement = Head; //Linking newNode to head's pointer
        Head = newNode; //head pointing to the start of the list
        Console.Write(value + " Inserted !    ");
    }

    public void InsertAtEnd(int value)
    {
        Node newNode = new Node(); //creating a new node
        newNode.Data = value;
        if (Head == null)
        {
            Head = newNode;
            Console.Write(value + " Inserted !    ");
            return;
        }
        Node last = Head;
        while (last.NextElement != null)
        {
            last = last.NextElement;
        }
        last.NextElement = newNode;
        Console.Write(value + " Inserted !    ");
    }
    public bool PrintList()
    {        // Printing the list
        if (IsEmpty())
        {
            Console.Write("List is Empty!");
            return false;
        }
        Node temp = Head;        // starting from head node
        Console.Write("List : ");

        while (temp != null)
        {     // traveresing through the List
            Console.Write(temp.Data + "->");
            temp = temp.NextElement;    // moving on to the temp's nextElement
        }
        Console.WriteLine("null ");    // printing null at the end
        return true;
    }

    public string Elements()
    {
        StringBuilder sb = new StringBuilder();
        Node start = Head;
        while (start != null)
        {
            sb.Append(start.Data.ToString() + "->");
            start = start.NextElement;
        }
        sb.Append("null");
        return sb.ToString();
    }

    public bool Search(int value)
    {
        Node temp = Head;

        while (temp != null)
        {
            if (temp.Data == value)
            {
                Console.WriteLine("Value found in List");
                return true;
            }
            temp = temp.NextElement;
        }
        Console.WriteLine("Value not found in List");
        return false;
    }

    public bool DeleteAtHead()
    {
        if (IsEmpty())
        {
            Console.WriteLine("List is Empty!");
            return false;
        }

        Head = Head.NextElement;
        return true;
    }

    public bool DeleteByValue(int value)
    {
        if (IsEmpty())
        {
            Console.WriteLine("List is Empty!");
            return false;
        }

        Node temp = Head;
        Node prev = null;

        if (temp != null && temp.Data == value)
        {
            Head = temp.NextElement;
            return true;
        }

        while (temp != null && temp.Data != value)
        {
            prev = temp;
            temp = temp.NextElement;
        }

        if (temp == null)
        {
            Console.WriteLine("Value not found in List");
            return false;
        }

        prev.NextElement = temp.NextElement;
        return true;
    }

    public int Length()
    {
        Node cuurent = Head;
        int count = 0;
        while (cuurent != null)
        {
            count++;
            cuurent = cuurent.NextElement;    
        }
        return count;
    }

    public string Reverse()
    {
        Node previous = null;
        Node current = Head;
        Node next = null;

        while (current != null)
        {
            next = current.NextElement;
            current.NextElement = previous!;
            previous = current;
            current = next;
        }

        Head = previous;
        return Elements();
    }

    public bool DetectLoop()
    {
        Node first = Head;
        Node current = Head;

        while (current != null)
        {
            current = current.NextElement;
            if (current == first)
            {
                return true;
            }
        }
        return false;
    }

    //Time Complexity: O(n), where n is the number of nodes in the linked list.
    //Auxiliary Space: O(1)
    public int FindMid()
    {
        if (IsEmpty())
            return 0;

        Node slow = Head;
        Node fast = Head;

        while (fast != null && fast.NextElement != null) 
        {
            // Move the fast pointer by two nodes
            fast = fast.NextElement.NextElement;

            slow = slow.NextElement;

        }

        return slow.Data;
    }

    public int FindMidApproach2()
    {
        //list is empty
        if (IsEmpty())
            return 0;

        //currentNode starts at the head
        Node currentNode = Head;

        if (currentNode.NextElement == null)
        {
            //Only 1 element exist in array so return its value.
            return currentNode.Data;
        }

        Node midNode = currentNode; //midNode starts at head
        currentNode = currentNode.NextElement.NextElement; //currentNode moves two steps forward

        //Move midNode (Slower) one step at a time
        //Move currentNode (Faster) two steps at a time
        //When currentNode reaches at end, midNode will be at the middle of List
        while (currentNode != null)
        {       // traversing from head to end

            midNode = midNode.NextElement;

            currentNode = currentNode.NextElement;     // pointing to current's next
            if (currentNode != null)
                currentNode = currentNode.NextElement;     // pointing to current's next
        }
        if (midNode != null)     // pointing at middle of the list
            return midNode.Data;
        return 0;
    }

    public void RemoveDuplicates()
    {

    }
}


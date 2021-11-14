using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World! Welcome to Stack And Queue");
            StackLinkedList stack = new StackLinkedList();
            stack.Display();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();

            Console.ReadLine();
            Console.WriteLine();
            stack.Peek();
            stack.Pop();
            stack.IsEmpty();
            stack.Display();
        }
    }

    internal class StackLinkedList
    {
        public Node top;
        //creating default constructor
        public StackLinkedList()
        {
            this.top = null;
        }

        //method to push data in to stack
        public void Push(int value)
        {
            Node newNode = new Node(value);
            //condition to check stack is empty or not
            if (this.top == null)
            {
                //Console.WriteLine("stack is empty");
                newNode.next = null;
            }
            else
            {
                //assigning top to newNode.next
                newNode.next = this.top;
            }
            //changing top with newNode 
            this.top = newNode;
            Console.WriteLine("{0} is pushed into the stack", value);
        }

        public void Display()
        {
            //storing top into temp variable
            Node temp = this.top;
            //loop for iterating upto last node 
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;//assigning next node value to temp
            }
        }

        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of the stack ", this.top.data);//NullrefrenceRxception
        }

        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty, Deletion is not possible");
                return;
            }
            Console.WriteLine("Value popped is {0} ", this.top.data);
            this.top = this.top.next;
        }

        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
            //this.top=null;
        }


        internal class Node
        {
            public int data;
            //creating next to store address of next node
            public Node next;
            
            public Node(int d)
            {
                data = d;
                //assigning node next to null
                next = null;
            }

        }
    }
}
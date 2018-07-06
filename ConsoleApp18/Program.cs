using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        public class Node
        {
           public int data;
           public Node next;
           public Node(int d)
            {
                data = d;
                next = null;
            }


        }
        public class mylinkedlist
        {
            Node HeadNode = new Node(0);
            public mylinkedlist(int a)
            {
                HeadNode.data = a;
                HeadNode.next = null;
            }

            public void AddNodeAtTheBeginning(int d)
            {
              

                Node temp = new Node(d);
                temp.next = HeadNode;
                HeadNode = temp;

               
            }

            public void AddNodeAtTheEnd(int d)
            {  
                    if (HeadNode.next == null)
                    {
                   
                    Node temp = new Node(d);
                    HeadNode.next = temp;
                       
                    }
                    else
                    { 
                        Node current = HeadNode;
                        while (current.next != null)
                        {
                        current = current.next;
                      
                        }
                    Node temp = new Node(d);
                    current.next = temp;
                }
            }
            public void PrintlinkedList()
            {
                Node current = HeadNode;
                if (current == HeadNode)
                {
                    Console.Write("{0}|->>", current.data);                    
                }
                while ( current.next != null)
               
                {
                    current = current.next;
                    Console.Write("{0}|->>", current.data);
               
                }
            }

            public void PrintlinkedList2()
            {               
                Node current = HeadNode;
                {                   
                    Console.Write("{0}|->>", current.data);                  
                }
                while (current.next != null)
                {
                    current = current.next;
                    Console.Write("{0}|->>", current.data);

                }
            }



        }

        static void Main(string[] args)
        {
            mylinkedlist a = new mylinkedlist(500);
            a.AddNodeAtTheBeginning(100);
            a.AddNodeAtTheBeginning(200);
            a.AddNodeAtTheBeginning(300);
            a.AddNodeAtTheBeginning(30780);
            a.AddNodeAtTheEnd(3078000);
           // a.PrintlinkedList();
            a.PrintlinkedList2();

        }
    }
}

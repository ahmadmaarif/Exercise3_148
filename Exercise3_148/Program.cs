using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise3_148
{
    class Node
    {
        /*create Nodes for the circular nexted list*/
        public int rollNumber;
        public string name;
        public Node next;

    }
    class CircularList
    {
        Node LAST;
        public CircularList()
        {
            LAST = null;
        }
        public bool Search(int rollNo, ref Node previous, ref Node current)
        /*Search for the specified node*/
        {
            for (previous = current = LAST.next; current != LAST; previous =
                current, current = current.next)
            {
                if (rollNo == current.rollNumber)
                    return (true);/* return true if node is found*/

            }
            if (rollNo == LAST.rollNumber)/*If the node is present at the end*/
                return true;
            else
                return (false);/*returns false if the node is not found*/
        }

        public bool listEmpty()
        {
            if (LAST == null)
                return true;
            else
                return false;
        }


        public void traverse() /*Traverse all the node of the list*/
        {
            if (listEmpty())
                Console.WriteLine("\nList is empty");
            else
            {
                Console.WriteLine("\n Record in the list are : \n");
                Node currentNode;
                currentNode = LAST.next;
                while (currentNode != LAST)
                { }
            }
        }
    }
}
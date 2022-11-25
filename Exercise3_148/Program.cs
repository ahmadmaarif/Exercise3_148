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
        public bool deleteNode(int studentNo)
        {
            Node previous, current;
            previous = current = null;
            if (Search(studentNo, ref previous, ref current) == false)
                return false;
            if (studentNo == LAST.next.rollNumber)
            {
                current = LAST.next;
                LAST.next = current.next;
                return true;
            }
            if (studentNo == LAST.rollNumber)
            {
                current = LAST;
                previous = current.next;
                while (previous.next != LAST)
                    previous = previous.next;
                previous.next = LAST.next;
                LAST = previous;
                return true;
            }
            if (studentNo <= LAST.rollNumber)
            {
                current = LAST.next;
                previous = LAST.next;
                while (studentNo > current.rollNumber || previous == LAST)
                {
                    previous = current;
                    current = current.next;
                }
                previous.next = current.next;
            }
            return true;
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
                {
                    Console.WriteLine(currentNode.rollNumber + " " + currentNode.name + "\n");
                    currentNode = currentNode.next;

                }
                Console.WriteLine(LAST.rollNumber+ " "+ LAST.name +"\n" );

            }
        }
        public void firstNode()
        {
            if (listEmpty())
                Console.WriteLine("\nlist is empty");
            else
                Console.WriteLine("\nthe first second in the list is :\n\n" +
                    LAST.next.rollNumber + " " + LAST.next.name);

        }
        static void Main(string[] args
            )
        {
            CircularList obj = new CircularList();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. Add a record to the list");
                    Console.WriteLine("2. Delete a record from the list");
                    Console.WriteLine("3. View all records in the list");
                    Console.WriteLine("4. Search for a record in the list");
                    Console.WriteLine("5. Display the first record in the list");
                    Console.WriteLine("6. Exit\n");
                    Console.WriteLine("Enter your choice (1-6): ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':

                            {
                                obj.traverse();
                            }
                            break;
                        case '2':
                            {
                                if (obj.listEmpty()==true)
                                {
                                    Console.WriteLine("\n List is empty");
                                    break;

                                }
                                Node prev, curr;
                                prev = curr = null;
                                Console.Write("\nEnter yhe roll number of the " +
                                    "student whose record is to be searched:");
                                int num = Convert.ToInt32(Console.ReadLine());
                                if (obj.Search(num, ref prev, ref curr) == false)
                                    Console.WriteLine("\nRecord not found");
                                else
                                {
                                    Console.WriteLine("\nRecorn found");
                                    Console.WriteLine("\nRoll number;" + curr.rollNumber);
                                    Console.WriteLine("\nName:" + curr.name); 
                                }

                            }
                            break;
                        case '3':
                            {
                                obj.firstNode();

                            }
                            break;
                        case '4':
                            return;
                        default:
                            { Console.WriteLine("\nInvalid option");
                                break;
                            }
                    }
                }
                catch(Exception e)
                { Console.WriteLine(e.ToString()); 
                }

            }

        }
    }
}
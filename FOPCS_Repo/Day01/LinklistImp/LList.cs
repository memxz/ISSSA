using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinklistImp
{
    internal class LList
    {
        public Node Head { set; get; }
        private int numElements;
        public LList()
        {
            Head = null;
            numElements = 0;
        }
        public void Add(string newElement)
        {
            Node newNode = new Node(newElement);
            if (numElements == 0)
            {
                Head = newNode;
            }
            else
            {
                Node lastNode = GetNodeAt(numElements - 1);
                lastNode.Next = newNode;
            }
            numElements++;
        }
        public Node GetNodeAt(int index)
        {
            Node curNode = Head;
            // Traverse the chain to locate the node
            for (int i = 0; i < index; i++)
            {
                curNode = curNode.Next;
            }
            return curNode;
        }
        public void Insert(int index, string newElement)
        {
            if (index >= 0 && index <= numElements)
            {
                Node newNode = new Node(newElement);
                if (index == 0)
                {
                    newNode.Next = Head;
                    Head = newNode;
                }
                else
                {
                    Node nodeBefore = GetNodeAt(index - 1);
                    Node nodeAfter = nodeBefore.Next;
                    nodeBefore.Next = newNode;
                    newNode.Next = nodeAfter;
                }
                numElements++;
            } // else Invalid index
        }
        public void RemoveAt(int index)
        {
            if (index >= 0 && index <= numElements - 1)
            {
                if (index == 0)
                {
                    Head = Head.Next;
                }
                else
                {
                    Node nodeBefore = GetNodeAt(index - 1);
                    Node nodeToRemove = nodeBefore.Next;
                    Node nodeAfter = nodeToRemove.Next;
                    nodeBefore.Next = nodeAfter;
                }
                numElements--;
            }
            // else // Incorrect index
        }
        //Gets the number of elements contained in the list.
        public int Count()
        { 
            if (Head!= null) { return numElements; }
            else return -1;
            
        }
        //Replace with the new element at the specified index.
        public void Replace(int index, string newElement)
        {
            RemoveAt(index);
            Insert(index, newElement);

        }
        // Determines whether an element is in this list.
        public bool Contains(string element) 
        {
            bool isExist = false;
            for(int i=0; i < this.Count(); i++)
            {
                if(this.GetNodeAt(i).Data==element)
                    isExist = true;
                else isExist = false;   
            }
                return isExist;
        }
    }
}

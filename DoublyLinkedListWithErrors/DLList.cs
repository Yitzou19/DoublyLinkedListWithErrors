using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedListWithErrors
{
   public class DLList
    {
        public DLLNode head; // pointer to the head of the list
        public DLLNode tail; // pointer to the tail of the list
       public DLList() { head = null;  tail = null; } // constructor
        /*-------------------------------------------------------------------
        * The methods below includes several errors. Your  task is to write
        * unit test to discover these errors. During delivery the tutor may
        * add or remove errors to adjust the scale of the effort required by
        */
        public void AddToTail(DLLNode p)
        {
            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                p.previous = tail;
                tail.next = p;
                tail = p;
            }
        } // end of AddToTail

        public void AddToHead(DLLNode p)
        {
            if (head == null)
            {
                head = p;
                tail = p;
            }
            else
            {
                p.next = head;
                head.previous = p;
                head = p;
            }
        } // end of AddToHead

        public void RemoveHead()
        {
            if (head == null)
                return;

            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.next;
                head.previous = null;
            }
        } // end of RemoveHead

        public void RemoveTail()
        {
            if (tail == null)
                return;

            if (head == tail)
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.previous;
                tail.next = null;
            }
        } // end of RemoveTail

        /*-------------------------------------------------
         * Return null if the node does not exist.
         * ----------------------------------------------*/
        public DLLNode Search(int num)
        {
            DLLNode p = head;
            while (p != null)
            {
                if (p.num == num)
                    return p;
                p = p.next;
            }
            return null;
        } // end of Search (return pointer to the node)

        public void RemoveNode(DLLNode p)
        {
            if (p == null)
                return;

            if (p.previous == null)
                RemoveHead();
            else if (p.next == null)
                RemoveTail();
            else
            {
                p.previous.next = p.next;
                p.next.previous = p.previous;
            }

            p.next = null;
            p.previous = null;
        } // end of RemoveNode

        public int Total()
        {
            DLLNode p = head;
            int tot = 0;
            while (p != null)
            {
                tot += p.num;
                p = p.next;
            }
            return tot;
        } // end of total
    } // end of DLList class
}

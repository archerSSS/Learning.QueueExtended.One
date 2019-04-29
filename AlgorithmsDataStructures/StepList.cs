using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures
{
    public class StepList<T>
    {

        public Node<T> head;
        public Node<T> tail;
        public int count = 0;

        public StepList()
        {
            head = null;
            tail = null;
        }

        public void AddHead(Node<T> _item)
        {
            if (head == null) tail = _item;
            else
            {
                head.prev = _item;
                _item.next = head;
            }
            head = _item;
            count++;
        }

        public void AddTail(Node<T> _item)
        {
            if (tail == null) head = _item;
            else
            {
                tail.next = _item;
                _item.prev = tail;
            }
            tail = _item;
            count++;
        }

        public T RemoveHead()
        {
            T item = head.item;
            if (head.next != null) head = head.next;
            else
            {
                head = null;
                tail = null;
            }
            count--;
            return item;
        }

        public T RemoveTail()
        {
            T item = tail.item;
            if (tail.prev != null) tail = tail.prev;
            else
            {
                head = null;
                tail = null;
            }
            count--;
            return item;
        }
    }
}

using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{

    // Двусторонняя очередь Deque
    //
    public class Deque<T>
    {

        public StepList<T> list;

        public Deque()
        {
            list = new StepList<T>();
        }

        public void AddFront(T item)
        {
            if (item != null) list.AddHead(new Node<T>(item));
        }

        public void AddTail(T item)
        {
            if (item != null) list.AddTail(new Node<T>(item));
        }

        public T RemoveFront()
        {
            if (list.head != null) return list.RemoveHead();
            return default(T);
        }

        public T RemoveTail()
        {
            if (list.tail != null) return list.RemoveTail();
            return default(T);
        }

        public int Size()
        {
            return list.count;
            return 0;
        }
    }


    // Хранилище для двусторонней очереди. StepList
    //
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


    // Объект для хранения элементов списка StepList. Node.
    //
    public class Node<T>
    {

        public T item;
        public Node<T> prev;
        public Node<T> next;

        public Node(T _item)
        {
            item = _item;
            prev = null;
            next = null;
        }
    }
}

using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
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
}

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
            // инициализация внутреннего хранилища
        }

        public void AddFront(T item)
        {
            if (item != null) list.AddHead(new Node<T>(item));
            // добавление в голову
        }

        public void AddTail(T item)
        {
            if (item != null) list.AddTail(new Node<T>(item));
            // добавление в хвост
        }

        public T RemoveFront()
        {
            if (list.head != null) return list.RemoveHead();
            // удаление из головы
            return default(T);
        }

        public T RemoveTail()
        {
            if (list.tail != null) return list.RemoveTail();
            // удаление из хвоста
            return default(T);
        }

        public int Size()
        {
            return list.count;
            return 0; // размер очереди
        }

    }
}

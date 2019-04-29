using System;
using System.Collections.Generic;

namespace AlgorithmsDataStructures
{
    public class Deque_1<T>
    {

        public List<T> list;

        public Deque_1()
        {
            list = new List<T>();
            // инициализация внутреннего хранилища
        }

        public void AddFront(T item)
        {
            list.Insert(0, item);
            // добавление в голову
        }

        public void AddTail(T item)
        {
            list.Add(item);
            // добавление в хвост
        }

        public T RemoveFront()
        {
            if (list.Count != 0)
            {
                T item = list.Find(delegate (T it)
                {
                    if (it.GetType() == typeof(T)) { return true; }
                    return false;
                });
                list.RemoveAt(0);
                return item;
            }
            // удаление из головы
            return default(T);
        }

        public T RemoveTail()
        {
            if (list.Count != 0)
            {
                list.Reverse();
                T item = list.Find(delegate (T it)
                {
                    if (it.GetType() == typeof(T)) { return true; }
                    return false;
                });
                list.Reverse();
                list.RemoveAt(list.Count - 1);
                return item;
            }
            // удаление из хвоста
            return default(T);
        }


        public int Size()
        {
            return list.Count;
            return 0; // размер очереди
        }
    }

}
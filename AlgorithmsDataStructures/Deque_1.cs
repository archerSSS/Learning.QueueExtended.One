using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace AlgorithmsDataStructures
{
    public class Deque_1<T>
    {
        Node<T> head;
        Node<T> tail;
        public int count = 0;

        public Deque_1()
        {
            // инициализация внутреннего хранилища
        }

        public void AddFront(T item)
        {
            if (item == null) return; 
            if (head == null)
            {
                head = new Node<T>(item);
                tail = head;
            }
            else
            {
                Node<T> node = head;
                head = new Node<T>(item);
                node.prev = head;
                head.next = node;
            }
            count++;
            // добавление в голову
        }

        public void AddTail(T item)
        {
            if (item == null) return;
            if (tail == null)
            {
                tail = new Node<T>(item);
                head = tail;
            }
            else
            {
                tail.next = new Node<T>(item);
                tail.next.prev = tail;
                tail = tail.next;

                /*
                Node<T> node = new Node<T>(item);
                node.prev = tail;
                node.prev.next = node;
                tail = node;
                */
            }
            
            count++;
            // добавление в хвост
        }

        public T RemoveFront()
        {
            if (head != null)
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
            // удаление из головы
            return default(T);
        }

        public T RemoveTail()
        {
            if (tail != null)
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

            // удаление из хвоста
            return default(T);
        }

        public int Size()
        {
            return count;
            return 0; // размер очереди
        }

    }
}

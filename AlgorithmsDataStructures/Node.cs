using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures
{
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

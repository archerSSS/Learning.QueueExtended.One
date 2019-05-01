using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures
{
    public class PalindromeAnalizer
    {
        //Deque<char> deq1 = new Deque<char>();
        public bool GetSort(int itr)
        {
            if (itr != 0) return true;
            return false;
        }


        public bool IsPalindromic(Deque<char> deq)
        {
            if ((deq.Size() % 2) != 0) return false;
            for (int i = 0; i < deq.Size() / 2; i++)
            {
                if (deq.RemoveFront() != deq.RemoveTail()) return false;
            }
            return true;
        }
    }
}

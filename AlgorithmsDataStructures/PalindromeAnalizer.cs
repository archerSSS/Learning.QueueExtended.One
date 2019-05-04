using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures
{
    public class PalindromeAnalizer
    {
        public bool IsPalindromic(Deque<char> deq)
        {
            Deque<char> deq2 = new Deque<char>();
            deq.CopyTo(deq2);

            for (int i = 0; i < deq.Size(); i++)
            {
                if (deq.RemoveFront() != deq2.RemoveTail()) return false;
            }
            return true;
        }

        public Deque<char> StringToDeque(String str)
        {
            Char[] chars = str.ToCharArray();
            Deque<char> deq = new Deque<char>();
            for (int i = 0; i < chars.Length; i++)
            {
                deq.AddTail(chars[i]);
            }
            return deq;
        } 
    }
}

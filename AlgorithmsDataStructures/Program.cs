using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmsDataStructures
{
    public class Program
    {
        public static void Main(String[] args)
        {
            List<int> list = new List<int>();
            for (int i = 0; i < 1000000; i++)
            {
                list.Add(i+1);
            }
            list.Reverse();
        }
    }
}

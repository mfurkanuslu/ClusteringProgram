using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringProgram.Heap
{
    public class Heap
    {
        private static MinHeap Container;

        public static object[] Sort(object[] elements)
        {
            CreateHeap(elements);
            object[] sortedArray = new object[elements.Length];

            for (int i = 0; i < elements.Length; i++)
            {
                sortedArray[i] = Container.DeleteMin();
            }
            return sortedArray;
        }

        private static void CreateHeap(object[] elements)
        {
            Container = new MinHeap((IComparable[])elements);
        }
    }
}

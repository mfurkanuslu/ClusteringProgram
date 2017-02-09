using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClusteringProgram.Heap
{
    public class MinHeap
    {

        #region "Key" Class
        private class Key : IComparable
        {
            IComparable element;

            public Key(IComparable element)
            {
                this.element = element;
            }

            public object Element
            {
                get { return (object)element; }
                set { element = (IComparable)value; }
            }

            public int CompareTo(object obj)
            {
                Key other = (Key)obj;
                return element.CompareTo(other.Element);
            }

            public override string ToString()
            {
                return element.ToString();
            }
        }
        #endregion

        private Key[] keys;
        private int n;

        public MinHeap(int capacity)
        {
            keys = new Key[capacity + 1];
            n = 0;
        }

        public MinHeap() : this(1)
        {
        }

        public MinHeap(IComparable[] elements)
        {
            keys = new Key[elements.Length + 1];
            n = elements.Length;
            for (int i = 0; i < n; i++)
            {
                keys[i + 1] = new Key(elements[i]);
            }
            ConstructHeap();
        }

        public bool IsEmpty()
        {
            if (n == 0) return true;
            return false;
        }

        public int GetSize()
        {
            return n;
        }

        public object GetMin()
        {
            if (IsEmpty())
                throw new NoSuchElementException("No Elements in the heap now!!!");
            return keys[1].Element;
        }

        private void SetCapacity(int newCapacity)
        {
            if (keys.Length >= newCapacity) return;
            keys = CopyElements(newCapacity);
        }

        private void ShrinkCapacity(int newCapacity)
        {
            if (newCapacity < n) return;
            keys = CopyElements(newCapacity);
        }

        private Key[] CopyElements(int newCapacity)
        {
            Key[] tempArr = new Key[newCapacity];
            for (int i = 0; i < n; i++)
            {
                tempArr[i + 1] = keys[i + 1];
            }
            return tempArr;
        }

        public void InsertElement(IComparable element)
        {
            if (n == keys.Length - 1)
                SetCapacity(keys.Length * 2);
            keys[++n] = new Key(element);
            TopDownConstructHeap(n);
        }

        public object DeleteMin()
        {
            if (IsEmpty())
                throw new NoSuchElementException("No Elements in the heap now!!!");
            Swap(1, n);
            Key minKey = keys[n--];
            keys[n + 1] = null;
            Heapify(1);
            if ((n > 0) && (n == (keys.Length - 1) / 4))
                ShrinkCapacity(keys.Length / 2);
            return minKey.Element;
        }

        private void TopDownConstructHeap(int index)
        {
            while ((index > 1) && keys[index / 2].CompareTo(keys[index]) == 1)
            {
                Swap(index, index / 2);
                index = index / 2;
            }
        }

        private void Heapify(int rootIndex)
        {
            while (2 * rootIndex <= n)
            {
                int leftChildIndex = 2 * rootIndex;
                int rightChildIndex = leftChildIndex + 1;
                int elementToChangeIndex = leftChildIndex;
                if (n >= rightChildIndex)
                {
                    if (keys[leftChildIndex].CompareTo(keys[rightChildIndex]) == 1)
                        elementToChangeIndex = rightChildIndex;
                }

                if (keys[elementToChangeIndex].CompareTo(keys[rootIndex]) == 1) break;
                Swap(rootIndex, elementToChangeIndex);
                rootIndex = elementToChangeIndex;
            }
        }

        private void ConstructHeap()
        {
            for (int keyIndex = n / 2; keyIndex >= 1; keyIndex--)
                Heapify(keyIndex);
        }

        private void Swap(int i, int j)
        {
            Key temp = keys[i];
            keys[i] = keys[j];
            keys[j] = temp;
        }


    }

}

using System;

namespace Algorithms.Sort
{
    public class Heap
    {
        public static void Sort<T>(T[] data) where T : IComparable<T>
        {

            if (data == null)
            {
                throw new ArgumentNullException();
            }

            for (var i = 0; i < data.Length; i++)
            {
                Swim(data, i);
            }

            var n = data.Length - 1;
            for (var i = n; i > 0; i--)
            {
                Utils.Exchange(data, 0, i);
                Sink(data, 0, i - 1);
            }
            
        }

        private static void Sink<T>(T[] data, int parentIndex, int size) where T : IComparable<T>
        {
            while (2 * parentIndex + 1 <= size)
            {
                var rightChildIndex = 2 * parentIndex + 1;
                var leftChildIndex = rightChildIndex + 1;

                var maxChildIndex = leftChildIndex <= size
                    ? data[rightChildIndex].CompareTo(data[leftChildIndex]) > 0 ? rightChildIndex : leftChildIndex
                    : rightChildIndex;


                if (data[maxChildIndex].CompareTo(data[parentIndex]) > 0)
                {
                    Utils.Exchange(data, parentIndex, maxChildIndex);
                    parentIndex = maxChildIndex;
                    continue;
                }
                break;
            }
        }

        private static void Swim<T>(T[] data, int n) where T : IComparable<T>
        {
            while ((n - 1) >= 0 && (n - 1) / 2 >= 0)
            {
                var index = (n - 1) / 2;
                if (data[n].CompareTo(data[index]) > 0)
                {
                    Utils.Exchange(data, index, n);
                    n = index;
                    continue;
                }
                break;
            }
        }
    }
}

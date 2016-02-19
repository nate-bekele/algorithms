using System;

namespace Algorithms.Sort
{
    public class Merge
    {
        public static void Sort<T>(T[] data) where T : IComparable<T>
        {
            var aux = new T[data.Length];
            MergeSort(data, aux, 0, data.Length - 1);
        }

        public static int[] IndexSort<T>(T[] data) where T : IComparable<T>
        {
            var aux = new int[data.Length];
            var index = new int[data.Length];

            for (int i = 0; i < index.Length; i++)
            {
                index[i] = i;
            }

            MergeIndexSort(data, index, aux, 0, data.Length - 1);

            return index;
        }

        private static void MergeSort<T>(T[] data, T[] aux, int lo, int hi) where T : IComparable<T>
        {
            if (lo >= hi) return;
            var mid = lo + (hi - lo) / 2;

            MergeSort<T>(data, aux, lo, mid);
            MergeSort<T>(data, aux, mid + 1, hi);
            MergeItem(data, aux, lo, mid, hi);
        }

        private static void MergeIndexSort<T>(T[] data, int[] index, int[] aux, int lo, int hi) where T : IComparable<T>
        {
            if (lo >= hi) return;
            var mid = lo + (hi - lo) / 2;

            MergeIndexSort<T>(data, index, aux, lo, mid);
            MergeIndexSort<T>(data, index, aux, mid + 1, hi);
            MergeIndex(data, index, aux, lo, mid, hi);
        }

        private static void MergeItem<T>(T[] data, T[] aux, int lo, int mid, int hi) where T : IComparable<T>
        {
            int i;
            for (i = lo; i <= hi; i++)
            {
                aux[i] = data[i];
            }

            i = lo;
            var j = mid + 1;
            for (var k = lo; k <= hi; k++)
            {
                if (i > mid) data[k] = aux[j++];
                else if (j > hi) data[k] = aux[i++];
                else if (aux[j].CompareTo(aux[i]) <= 0) data[k] = aux[j++];
                else data[k] = aux[i++];
            }

        }

        private static void MergeIndex<T>(T[] data, int[] index, int[] aux, int lo, int mid, int hi) where T : IComparable<T>
        {
            int i;
            for (i = lo; i <= hi; i++)
            {
                aux[i] = index[i];
            }

            i = lo;
            var j = mid + 1;
            for (var k = lo; k <= hi; k++)
            {
                if (i > mid) index[k] = aux[j++];
                else if (j > hi) index[k] = aux[i++];
                else if (data[aux[j]].CompareTo(data[aux[i]]) <= 0) index[k] = aux[j++];
                else index[k] = index[i++];
            }

        }
    }
}

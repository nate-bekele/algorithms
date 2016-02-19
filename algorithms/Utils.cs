using System;

namespace Algorithms
{
    public class Utils
    {
        public static void Shuffle<T>(T[] data)
        {
            if (data == null)
            {
                throw new ArgumentNullException();
            }

            var radom = new System.Random();
            for (var i = 0; i < data.Length; i++)
            {
                var r = radom.Next(i + 1);
                Exchange(data, i, r);
            }
        }

        public static void Exchange<T>(T[] data, int i, int r)
        {
            var tempObject = data[i];
            data[i] = data[r];
            data[r] = tempObject;
        }


        public static bool IsSorted<T>(T[] data) where T : IComparable<T>
        {
            for (int i = 1; i < data.Length; i++)
            {
                if (data[i - 1].CompareTo(data[i]) <=0)
                {
                    continue;
                }
                return false;
            }

            return true;
        }
    }
}

using System;
using System.Diagnostics;
using System.IO;
using System.Text;
using Algorithms.Sort;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            var csv = new StringBuilder();
            var size = 10;
            while(size <= 10000)
            {
                var data = Data.Data.GetReverseSortedIntegers(size);
                
                var st = new Stopwatch();
                st.Start();
                Shell.Sort(data);
                st.Stop();

                csv.AppendLine($"{size},{st.Elapsed.TotalMilliseconds}");
                size = size + 500;
            }
            var path = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var compindedPath = Path.Combine(path, "ShellSort.csv");
            File.WriteAllText(compindedPath, csv.ToString());
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;

class Program
{
    static List<int> FindDuplicatesOptimized(int[] arr)
    {
        HashSet<int> seen = new HashSet<int>();
        HashSet<int> duplicates = new HashSet<int>();

        foreach (var num in arr)
        {
            if (!seen.Add(num))
            {
                duplicates.Add(num);
            }
        }

        return new List<int>(duplicates);
    }

    static void Main()
    {
        int[] testArray = { 1, 2, 3, 2, 4, 5, 5, 6 };

        Stopwatch sw = Stopwatch.StartNew();
        var duplicates = FindDuplicatesOptimized(testArray);
        sw.Stop();

        Console.WriteLine("Дубликаты: " + string.Join(", ", duplicates));
        Console.WriteLine("Время: " + sw.ElapsedTicks + " тиков");
    }
}

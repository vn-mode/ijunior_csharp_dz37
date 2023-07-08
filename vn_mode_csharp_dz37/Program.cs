using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] array1 = { "1", "2", "1" };
        string[] array2 = { "3", "2" };

        List<string> unionElements = new List<string>();

        MergeWithoutDuplicates(array1, unionElements);
        MergeWithoutDuplicates(array2, unionElements);

        foreach (string element in unionElements)
        {
            Console.WriteLine(element);
        }
    }

    static void MergeWithoutDuplicates(string[] array, List<string> mergedList)
    {
        if (array is null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        if (mergedList is null)
        {
            throw new ArgumentNullException(nameof(mergedList));
        }

        foreach (string element in array)
        {
            if (mergedList.Contains(element) == false)
            {
                mergedList.Add(element);
            }
        }
    }
}

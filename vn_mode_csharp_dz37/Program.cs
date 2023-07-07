using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] array1 = { "1", "2", "1" };
        string[] array2 = { "3", "2" };

        List<string> result = new List<string>();

        MergeWithoutDuplicates(array1, result);
        MergeWithoutDuplicates(array2, result);

        foreach (string item in result)
        {
            Console.WriteLine(item);
        }
    }

    static void MergeWithoutDuplicates(string[] array, List<string> mergedList)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        if (mergedList == null)
        {
            throw new ArgumentNullException(nameof(mergedList));
        }

        foreach (string element in array)
        {
            if (!mergedList.Contains(element))
            {
                mergedList.Add(element);
            }
        }
    }
}

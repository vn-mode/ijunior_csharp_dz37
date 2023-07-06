using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] array1 = { "1", "2", "1" };
        string[] array2 = { "3", "2" };

        List<string> result = new List<string>();

        MergeWithoutDuplicates(array1, array2, result);

        foreach (string item in result)
        {
            Console.WriteLine(item);
        }
    }

    static void MergeWithoutDuplicates(string[] array1, string[] array2, List<string> mergedList)
    {
        if (mergedList == null)
        {
            throw new ArgumentNullException(nameof(mergedList));
        }

        AddUniqueItems(mergedList, array1);
        AddUniqueItems(mergedList, array2);
    }

    static void AddUniqueItems(List<string> list, string[] array)
    {
        if (list == null)
        {
            throw new ArgumentNullException(nameof(list));
        }

        if (array == null)
        {
            throw new ArgumentNullException(nameof(array));
        }

        foreach (string element in array)
        {
            if (list.Contains(element) == false)
            {
                list.Add(element);
            }
        }
    }
}

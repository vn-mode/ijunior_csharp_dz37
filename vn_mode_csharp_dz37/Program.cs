using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        string[] array1 = { "1", "2", "1" };
        string[] array2 = { "3", "2" };

        List<string> result = MergeWithoutDuplicates(array1, array2);

        foreach (string s in result)
        {
            Console.WriteLine(s);
        }
    }

    static List<string> MergeWithoutDuplicates(string[] array1, string[] array2)
    {
        List<string> mergedList = new List<string>();

        AddUniqueItems(mergedList, array1);
        AddUniqueItems(mergedList, array2);

        return mergedList;
    }

    static void AddUniqueItems(List<string> list, string[] array)
    {
        foreach (string item in array)
        {
            if (!list.Contains(item))
            {
                list.Add(item);
            }
        }
    }
}

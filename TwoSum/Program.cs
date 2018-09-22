using System;
using System.Collections.Generic;

class TwoSum
{
    public static Tuple<int, int> FindTwoSum(IList<int> list, int sum)
    {
        
        var i = 0;
        foreach (var item in list)
        {
            var j = 0;
            foreach (var item2 in list)
            {
                if (i == j)
                {
                    continue;
                }

                if ((item + item2) == sum)
                {
                    return Tuple.Create(i, j);
                }

                ++j;
            }
            ++i;
        }

        return null;
    }

    public static void Main(string[] args)
    {
        Tuple<int, int> indices = FindTwoSum(new List<int>() { 3, 1, 5, 7, 5, 9 }, 10);

        if (indices != null)
        {
            Console.WriteLine(indices.Item1 + " " + indices.Item2);
        }

    }
}
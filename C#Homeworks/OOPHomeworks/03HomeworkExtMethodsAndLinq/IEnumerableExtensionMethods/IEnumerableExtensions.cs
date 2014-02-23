using System;
using System.Collections.Generic;
using System.Linq;

public static class IEnumerableExtensions
{
    public static T Sum<T>(this IEnumerable<T> collection)
        where T : IComparable
    {
        dynamic sum = 0;
        foreach (var item in collection)
        {
            sum += item;
        }

        return sum;
    }

    public static T Product<T>(this IEnumerable<T> collection)
        where T : IComparable
    {
        dynamic product = 1;
        foreach (var member in collection)
        {
            product *= member;
        }

        return product;
    }

    public static T Min<T>(this IEnumerable<T> collection)
        where T : IComparable
    {
        dynamic minimum = int.MaxValue;
        foreach (var member in collection)
        {
            if (minimum > member)
            {
                minimum = member;
            }
        }

        return minimum;
    }

    public static T Max<T>(this IEnumerable<T> collection)
        where T : IComparable
    {
        dynamic maximum = int.MinValue;
        foreach (var member in collection)
        {
            if (maximum < member)
            {
                maximum = member;
            }
        }

        return maximum;
    }

    public static decimal Average<T>(this IEnumerable<T> collection)
        where T : IComparable
    {
        dynamic sum = 0;
        decimal count = 0;
        foreach (var member in collection)
        {
            sum += member;
            count++;
        }

        decimal average = sum / count;
        return average;
    }
}


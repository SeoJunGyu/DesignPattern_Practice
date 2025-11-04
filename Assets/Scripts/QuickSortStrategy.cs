using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuickSortStrategy<T> : ISortStrategy<T> where T : IComparable<T>
{
    private readonly IComparer<T> comparer;

    public QuickSortStrategy()
    {
        comparer = Comparer<T>.Default;
    }

    public QuickSortStrategy(IComparer<T> customComparer)
    {
        comparer = customComparer;
    }

    public void Sort(T[] array)
    {
        throw new System.NotImplementedException();
    }
}

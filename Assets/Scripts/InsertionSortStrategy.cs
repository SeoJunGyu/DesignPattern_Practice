using System;
using System.Collections.Generic;
using UnityEngine;

public class InsertionSortStrategy<T> : ISortStrategy<T> where T : IComparable<T>
{
    private readonly IComparer<T> comparer;

    public InsertionSortStrategy()
    {
        comparer = Comparer<T>.Default;
    }

    public InsertionSortStrategy(IComparer<T> customComparer)
    {
        comparer = customComparer;
    }

    public void Sort(T[] array)
    {
        //2 4 3 1 0
        //
        for(int i = 1; i < array.Length; i++)
        {
            if(comparer.Compare(array[i], array[i - 1]) < 0)
            {
                T tmp = array[i];
                array[i] = array[i - 1];
                array[i - 1] = tmp;
            }
        }
    }
}

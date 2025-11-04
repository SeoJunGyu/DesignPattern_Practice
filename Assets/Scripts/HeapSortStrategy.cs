using System;
using UnityEngine;

public class HeapSortStrategy<T> : ISortStrategy<T> where T : IComparable<T>
{
    public void Sort(T[] array)
    {
        throw new System.NotImplementedException();
    }
}

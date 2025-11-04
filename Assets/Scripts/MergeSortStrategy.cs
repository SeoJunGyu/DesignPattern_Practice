using System;
using UnityEngine;

public class MergeSortStrategy<T> : ISortStrategy<T> where T : IComparable<T>
{
    public void Sort(T[] array)
    {
        throw new System.NotImplementedException();
    }
}

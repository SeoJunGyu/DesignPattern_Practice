using UnityEngine;
using System;

public class BubbleSortStrategy<T> : ISortStrategy<T> where T : IComparable<T>
{
    public void Sort(T[] array)
    {
        throw new System.NotImplementedException();
    }
}

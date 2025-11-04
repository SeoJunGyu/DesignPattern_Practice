using System;
using UnityEngine;

public interface ISortStrategy<T> where T : IComparable<T>
{
    void Sort(T[] array);
}

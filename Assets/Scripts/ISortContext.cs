using System;
using UnityEngine;

public interface ISortContext<T> where T : IComparable<T>
{
    void SetStrategy(ISortStrategy<T> strategy);
    void Sort(T[] array);
}

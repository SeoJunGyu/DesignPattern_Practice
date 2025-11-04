using System;
using UnityEngine;

public class SortContext<T> : ISortContext<T> where T : IComparable<T>
{
    private ISortStrategy<T> strategy;

    public void SetStrategy(ISortStrategy<T> strategy)
    {
        this.strategy = strategy;
    }

    public void Sort(T[] array)
    {
        if(strategy != null)
        {
            strategy.Sort(array);
        }
    }
}

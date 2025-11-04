using UnityEngine;
using System;

public class BubbleSortStrategy<T> : ISortStrategy<T> where T : IComparable<T>
{
    public void Sort(T[] array)
    {
        for(int i = 0; i < array.Length - 1; i++)
        {
            for(int j = 0; j < array.Length - i - 1; j++)
            {
                if(array[j].CompareTo(array[j + 1]) > 0)
                {
                    // Swap array[j] and array[j + 1]
                    T temp = array[j];
                    array[j] = array[j + 1];
                    array[j + 1] = temp;
                }
            }
        }
    }
}

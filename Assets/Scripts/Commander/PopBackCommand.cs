using System.Collections.Generic;
using UnityEngine;

public class PopBackCommand : ICommand
{
    private List<int> list;
    private int removeValue;

    public PopBackCommand(List<int> list)
    {
        this.list = list;
    }

    public void Execute()
    {
        removeValue = list[list.Count - 1];
        list.RemoveAt(list.Count - 1);
    }

    public void Undo()
    {
        list.Add(removeValue);
    }
}

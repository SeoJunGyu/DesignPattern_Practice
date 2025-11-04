using System.Collections.Generic;
using UnityEngine;

public class PopFrontCommand : ICommand
{
    private List<int> list;
    private int removeValue;

    public PopFrontCommand(List<int> list)
    {
        this.list = list;
    }

    public void Execute()
    {
        removeValue = list[0];
        list.RemoveAt(0);
    }

    public void Undo()
    {
        list.Insert(0, removeValue);
    }
}

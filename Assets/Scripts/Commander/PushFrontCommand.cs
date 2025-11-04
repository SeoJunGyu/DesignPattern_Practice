using System.Collections.Generic;
using UnityEngine;

public class PushFrontCommand : ICommand
{
    private List<int> list;

    public PushFrontCommand(List<int> list)
    {
        this.list = list;
    }

    public void Execute()
    {
        if (list.Count == 0)
        {
            list.Insert(0, 10);
        }
        else
        {
            int count = list[0] + 10;
            list.Insert(0, count);
        }
    }

    public void Undo()
    {
        list.RemoveAt(0);
    }
}

using System.Collections.Generic;
using UnityEngine;

public class PushBackCommand : ICommand
{
    private List<int> list;

    public PushBackCommand(List<int> list)
    {
        this.list = list;
    }

    public void Execute()
    {
        int count;
        if (list.Count == 0)
        {
            count = 10;
        }
        else
        {
            count = list[list.Count - 1] + 10;
        }
        
        list.Add(count);
    }

    public void Undo()
    {
        list.RemoveAt(list.Count - 1);
    }
}

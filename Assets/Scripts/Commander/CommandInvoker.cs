using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker
{
    private Stack<ICommand> undoStack = new Stack<ICommand>();
    private Stack<ICommand> redoStack = new Stack<ICommand>();

    public void ExecuteCommand(ICommand command)
    {
        command.Execute();
        undoStack.Push(command);
        redoStack.Clear();
    }

    public void Undo()
    {
        if (undoStack.Count > 0)
        {
            var command = undoStack.Pop();
            command.Undo();
            redoStack.Push(command); //Redo 스택에 추가
        }
    }

    public void Redo()
    {
        if (redoStack.Count > 0)
        {
            var command = redoStack.Pop();
            command.Execute();
            undoStack.Push(command); //Undo 스택에 다시 추가
        }
    }

    public bool CanUndo() => undoStack.Count > 0;
    public bool CanRedo() => redoStack.Count > 0;
}

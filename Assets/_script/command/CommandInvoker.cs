using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CommandInvoker : MonoBehaviour
{
    private static Stack<ICommand> UndoCommand = new Stack<ICommand>();

    public static void ExecuteCommand(ICommand command)
    {
        command.Execute();
        UndoCommand.Push(command);
    }

    public static void UndoCommandFn()
    {
        if (UndoCommand.Count > 0)
        {
            ICommand command = UndoCommand.Pop();
            command.Undo();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerApp
{

    #region References

    private Stack<ICommand> _commandList;

    #endregion

    public PlayerApp() => _commandList = new Stack<ICommand>();


    public void AddCommand(ICommand newCommand)
    {
        newCommand.Excecute();
        _commandList.Push(newCommand);
    }

    public void UndoCommand()
    {
        if (_commandList.Count > 0)
        {
            ICommand latestCommand = _commandList.Pop();
            latestCommand.Undo();
        }
    }

}

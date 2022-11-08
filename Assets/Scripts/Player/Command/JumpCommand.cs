using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpCommand : ICommand
{
    #region References

    private  readonly PlayerController _playerController;

    #endregion

    public JumpCommand(PlayerController playerController)
    {
        _playerController = playerController;
    }

    public void Execute()
    {
       _playerController.JumpPlayer();
    }

    public void Undo()
    {
        
    }
}

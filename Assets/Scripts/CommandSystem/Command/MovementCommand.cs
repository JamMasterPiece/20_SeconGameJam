using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.PlayerLoop;

public class MovementCommand : ICommand
{
    #region References

    private readonly PlayerController _playerController;

    private readonly float _xValue;


    #endregion

    #region Strings

    private const string Horizontal = "Horizontal";
    
    #endregion

    public MovementCommand(PlayerController playerController)
    {
        _playerController = playerController;
        _xValue = Input.GetAxis(Horizontal);
    }

    public void Execute()
    {
        _playerController.MovementPlayer(_xValue);
        _playerController.FlipPlayer(_xValue);
    }

    public void Undo()
    {
       
    }
}

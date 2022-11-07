using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementCommand : ICommand
{
    #region References

    private Player _player;

    private float _xValue;

    private float _yValue;

    #endregion

    #region Strings

    private const string Horizontal = "Horizontal";
    private const string Vertical = "Vertical";

    #endregion

    public MovementCommand(Player player)
    {
        _player = player;
        _xValue = Input.GetAxis(Horizontal);
        _yValue = Input.GetAxis(Vertical);
    }

    public void Excecute() => _player.MovementPlayer(_xValue,_yValue);

    public void Undo()
    {

    }
}

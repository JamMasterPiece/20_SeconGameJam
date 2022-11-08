using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    #region References

    private CommandRecorder _commandRecorder;

    [SerializeField] private PlayerController _playerController;

    #endregion


    private void Start() => _commandRecorder = new CommandRecorder();

    void FixedUpdate()
    {
        CheckInput();
    }

    private void CheckInput()
    {
        ICommand movementCommand = CommandFactory.GetCommand(nameof(CommandType.MovementCommand), _playerController);
        _commandRecorder.AddCommand(movementCommand);

        if (Input.GetKey(KeyCode.Space))
        {
            ICommand jumpCommand = CommandFactory.GetCommand(nameof(CommandType.JumpCommand), _playerController);
            _commandRecorder.AddCommand(jumpCommand);
        }

        if (Input.GetKey(KeyCode.Z))
        {
            _commandRecorder.UndoCommand();
        }

    }

}

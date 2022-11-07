using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using TMPro.EditorUtilities;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    #region References

    private PlayerApp _playerApp;

    [SerializeField] private Player _player;

    #endregion


    private void Start() => _playerApp = new PlayerApp();

    void FixedUpdate()
    {
        CheckInput();
    }

    private void CheckInput()
    {
        ICommand movementCommand = new MovementCommand(_player);
        movementCommand.Excecute();

        if (Input.GetKey(KeyCode.Z))
        {
            _playerApp.UndoCommand();
        }

      
    }
    
    
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class CommandFactory : MonoBehaviour
{
    public  static ICommand GetCommand(string commandType,PlayerController player)
    {
        switch (commandType)
        {
            case nameof(CommandType.MovementCommand):
                return new MovementCommand(player);
            case nameof(CommandType.JumpCommand):
                return new JumpCommand(player);
            default:
                return null;
        }
    }
}

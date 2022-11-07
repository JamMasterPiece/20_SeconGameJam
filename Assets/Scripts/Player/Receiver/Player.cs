using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    #region Serialize

    [Tooltip("You can set the speed of your player  as you want.")]
    [SerializeField] [Range(2,20)] private int _playerSpeed;

     #endregion


    public void MovementPlayer(float xValue , float yValue)
    {
        xValue = xValue * _playerSpeed * Time.deltaTime;
        yValue = yValue * _playerSpeed * Time.deltaTime;
        transform.Translate(xValue, yValue, 0);
    }
}


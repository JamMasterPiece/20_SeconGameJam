using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    #region Serialize

    [Tooltip("You can set the speed of your player  as you want.")]
    [SerializeField] [Range(2, 20)] private int _playerSpeed;


    [SerializeField] private Rigidbody2D _rigidbody2D;

    [Tooltip("Determine how forcefully you will jump.")]
    [SerializeField] [Range(2, 10)] private int _jumpPower;

    #endregion


    public void MovementPlayer(float xValue)
    {
        xValue = xValue * _playerSpeed * Time.deltaTime;
        transform.Translate(xValue, 0, 0);
    }

    public void JumpPlayer()
    {
        _rigidbody2D.velocity = Vector2.zero; ;
        _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x,_jumpPower);
        
    }
}


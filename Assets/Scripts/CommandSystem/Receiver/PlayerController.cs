using System;
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

    [Header("FlipSettings")]
    [SerializeField]
    private SpriteRenderer _characterSprite;

    [SerializeField] private SpriteRenderer _ufoSprite;

    #endregion

    #region References

    private CollisionHandler _collisionHandler;

    private bool _isJump = false;

    #endregion

    private void Awake() => _collisionHandler = GetComponentInChildren<CollisionHandler>();

    public void MovementPlayer(float xValue)
    {
        xValue = xValue * _playerSpeed * Time.deltaTime;
        transform.Translate(xValue, 0, 0);
    }

    public void JumpPlayer()
    {
        if (_collisionHandler.IsGrounded())
        {
            if (_isJump) return;

            _isJump = true;
            _rigidbody2D.velocity = Vector2.zero;
            _rigidbody2D.velocity = new Vector2(_rigidbody2D.velocity.x, _jumpPower);
        }
        else
        {
            _isJump = false;
        }
    }

    public void FlipPlayer(float xValue)
    {
        if ((xValue > 0))
        {
            _characterSprite.flipX = false;
            _ufoSprite.flipX = false;
        }
        else if ((xValue < 0))
        {
            _characterSprite.flipX = true;
            _ufoSprite.flipX = true;
        }
    }
}


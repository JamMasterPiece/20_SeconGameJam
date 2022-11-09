using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{

    #region Tags

    private const string _groundTag = "Ground";
    private const string _enemyTag = "Enemy";
    private const string _finishTag = "Finish";

    #endregion

    #region References

    private bool _isGround;

    public static event Action OnDamageable;

    #endregion


    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(_groundTag))
        {
            _isGround = true;
        }
        else if (collision.gameObject.CompareTag(_enemyTag))
        {
            OnDamageable?.Invoke();
        }
        else if (collision.gameObject.CompareTag(_finishTag))
        {
            LevelManager.Instance.NextLevel();
        }
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(_groundTag))
        {
            _isGround = false;
        }
    }

    public bool IsGrounded() => _isGround;
}

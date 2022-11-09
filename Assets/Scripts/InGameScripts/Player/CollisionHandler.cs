using System;
using System.Collections;
using System.Collections.Generic;
using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;

public class CollisionHandler : MonoBehaviour
{

    #region Tags

    private const string GroundTag = "Ground";
    private const string EnemyTag = "Enemy";
    private const string FinishTag = "Finish";
  

    #endregion

    #region References

    private bool _isGround;

    public static event Action OnDamageable;
   

    #endregion

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GroundTag))
        {
            _isGround = true;
        }
        else if (collision.gameObject.CompareTag(EnemyTag))
        {
            OnDamageable?.Invoke();
        }
        else if (collision.gameObject.CompareTag(FinishTag))
        {
            GameManager.Instance.GameFinish();
        }
       
    }
    void OnCollisionExit2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag(GroundTag))
        {
            _isGround = false;
        }
    }

    public bool IsGrounded() => _isGround;
}

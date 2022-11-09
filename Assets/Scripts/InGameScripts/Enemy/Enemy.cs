using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Enemy", menuName = "EnemyType")]
public class Enemy : ScriptableObject
{
    #region Serialize

    [SerializeField] private int _damageAmount;
    public int DamageAmount { get { return _damageAmount; } set { } }


    #endregion
}

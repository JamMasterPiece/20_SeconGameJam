using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamage : MonoBehaviour
{
    #region Serialize

    [SerializeField]
    private Enemy _enemy;


    #endregion

    #region References

    private int _damageAmount;

    private PlayerOxygen _playerOxygen;

    #endregion

    private void Awake() => _playerOxygen = FindObjectOfType<PlayerOxygen>();
    private void OnEnable() => CollisionHandler.OnDamageable += Damage;

    private void Start() => _damageAmount = _enemy.DamageAmount;

    private void Damage()
    {
        if (_playerOxygen == null || _playerOxygen.TotalOxygen < 0) return;

        _playerOxygen.TotalOxygen -= _damageAmount;

    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerOxygen : MonoBehaviour
{

    #region Serialize

    [Tooltip("You can set custom player health")]
    [SerializeField] private float _totalOxygen = 20f;

    public float TotalOxygen 
    {
        get => _totalOxygen;
        set => _totalOxygen = value;
    }

    #endregion

    void Update()
    {
        ReduceHealth();
    }

    private void ReduceHealth()
    {
        if (_totalOxygen > 0)
        {
            _totalOxygen -= Time.deltaTime;
        }
    }

}

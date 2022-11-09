using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
public class TriggerHandler : MonoBehaviour
{

    #region References

    public static event Action OnActiveZone;
    public static event Action OnDeactiveZone;

    #endregion

    #region Tags

    private const string AcidTag = "AcidZone";

    #endregion

    private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.CompareTag(AcidTag))
        {
            OnActiveZone?.Invoke();
        }
    }

    private void OnTriggerExit2D(Collider2D col)
    {
        if (col.CompareTag(AcidTag))
        {
            OnDeactiveZone?.Invoke();
        }
    }
}

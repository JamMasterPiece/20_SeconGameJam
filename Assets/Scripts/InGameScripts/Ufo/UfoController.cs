using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.VisualScripting;

public class UfoController : MonoBehaviour
{

    #region Serialize

    [Tooltip("You can set maxiumum ufo size.")]
    [SerializeField] private float _ufoSize = 1.4f;

    [Tooltip("You can set spesific time for scaleUp and scaleDown.")]
    [SerializeField] private float _sizeTimer = 1f;


    #endregion

    #region References

    private Vector3 _previousScale;

    #endregion

    void Start() => _previousScale = transform.localScale;

    private void OnEnable()
    {
        TriggerHandler.OnActiveZone += ScaleUpUfo;
        TriggerHandler.OnDeactiveZone += ScaleDownUfo;
    }

    private void OnDisable()
    {
        TriggerHandler.OnActiveZone -= ScaleUpUfo;
        TriggerHandler.OnDeactiveZone -= ScaleDownUfo;
    }


    private void ScaleUpUfo()
    {
        var endScale = new Vector2(_ufoSize, _ufoSize);
        gameObject.transform.DOScale(endScale, _sizeTimer).SetEase(Ease.InSine);
    }

    private void ScaleDownUfo()
    {
       gameObject.transform.DOScale(_previousScale, _sizeTimer).SetEase(Ease.InOutSine);
    }


}

using UnityEngine;
using UnityEngine.UI;

public class PlayerOxygen : MonoBehaviour
{
    #region Serialize

    [Tooltip("You can set custom player health")] [SerializeField]
    private float _totalOxygen = 20f;

    public float TotalOxygen
    {
        get => _totalOxygen;
        set => _totalOxygen = value;
    }

    [SerializeField] private Image akciger;
    #endregion

    void Update()
    {
        ReduceHealth();
        CheckTotalOxygen();
    }

    private void ReduceHealth()
    {
        if (_totalOxygen > 0)
        {
            _totalOxygen -= Time.deltaTime;
            akciger.fillAmount -= Time.deltaTime*0.05f;
        }
    }

    private void CheckTotalOxygen()
    {
        if (!(_totalOxygen > 0))
        {
            GameManager.Instance.GameOver();
        }
    }
}
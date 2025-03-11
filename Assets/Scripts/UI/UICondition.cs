using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICondition : MonoBehaviour
{
    public Condition playerCondition;  // 플레이어의 Condition 스크립트
    public Image uiBar;  // 체력 바 UI
    public float minValue = 0f; // 최소값
    public float maxValue = 100f; // 최대값

    private void Start()
    {
        
        playerCondition = GameObject.FindGameObjectWithTag("Player").GetComponent<Condition>();

        if (playerCondition != null )
        {
            Debug.LogError("안됐음");
        }
    }

    private void Update()
    {
        
        if (playerCondition != null)
        {
            UpdateHealthBar(playerCondition.curValue);
        }
    }

    // 체력 값을 기반으로 UI 갱신
    private void UpdateHealthBar(float currentHealth)
    {
        float healthPercentage = Mathf.InverseLerp(minValue, maxValue, currentHealth);
        uiBar.fillAmount = healthPercentage;
    }
}

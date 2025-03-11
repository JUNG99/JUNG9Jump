using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UICondition : MonoBehaviour
{
    public Condition playerCondition;  // �÷��̾��� Condition ��ũ��Ʈ
    public Image uiBar;  // ü�� �� UI
    public float minValue = 0f; // �ּҰ�
    public float maxValue = 100f; // �ִ밪

    private void Start()
    {
        
        playerCondition = GameObject.FindGameObjectWithTag("Player").GetComponent<Condition>();

        if (playerCondition != null )
        {
            Debug.LogError("�ȵ���");
        }
    }

    private void Update()
    {
        
        if (playerCondition != null)
        {
            UpdateHealthBar(playerCondition.curValue);
        }
    }

    // ü�� ���� ������� UI ����
    private void UpdateHealthBar(float currentHealth)
    {
        float healthPercentage = Mathf.InverseLerp(minValue, maxValue, currentHealth);
        uiBar.fillAmount = healthPercentage;
    }
}

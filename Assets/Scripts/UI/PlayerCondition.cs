using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCondition : MonoBehaviour
{
    public Condition playerCondition; // Condition�� ���� (ü�� ����)

    public float healthRecoveryAmount = 20f;    
    void Start()
    {
      
        playerCondition = GetComponent<Condition>();
    }


    // ü���� ȸ���ϴ� �Լ�
    void RecoverHealth()
    {
        if (playerCondition != null)
        {
            playerCondition.Add(healthRecoveryAmount); // ȸ�� ������ ��� �� ü�� ȸ��
            Debug.Log("ü�� ȸ��: " + healthRecoveryAmount);
        }
    }

}

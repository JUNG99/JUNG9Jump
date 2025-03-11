using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCondition : MonoBehaviour
{
    public Condition playerCondition; // Condition을 참조 (체력 관리)

    public float healthRecoveryAmount = 20f;    
    void Start()
    {
      
        playerCondition = GetComponent<Condition>();
    }


    // 체력을 회복하는 함수
    void RecoverHealth()
    {
        if (playerCondition != null)
        {
            playerCondition.Add(healthRecoveryAmount); // 회복 아이템 사용 시 체력 회복
            Debug.Log("체력 회복: " + healthRecoveryAmount);
        }
    }

}

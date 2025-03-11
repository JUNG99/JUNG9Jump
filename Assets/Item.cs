using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{

    public float recoveryAmount = 30f; //È¸º¹

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
            {
        Condition playerCondition = other.GetComponent<Condition>();
            if (playerCondition != null)
            {
                playerCondition.Add(recoveryAmount);
                Destroy(gameObject);
            }

        }
    }
  
}

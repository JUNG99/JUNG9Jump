using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f; // 점프대에서 나오는 힘의 크기

    private void OnTriggerEnter(Collider other)
    {
        // 캐릭터가 점프대에 닿았을 때
        if (other.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();

            if (rb != null)
            {
                // ForceMode.Impulse로 순간적인 힘을 위로 가함
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}

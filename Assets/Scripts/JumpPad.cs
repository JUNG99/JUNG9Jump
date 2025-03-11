using UnityEngine;

public class JumpPad : MonoBehaviour
{
    public float jumpForce = 10f; // �����뿡�� ������ ���� ũ��

    private void OnTriggerEnter(Collider other)
    {
        // ĳ���Ͱ� �����뿡 ����� ��
        if (other.CompareTag("Player"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();

            if (rb != null)
            {
                // ForceMode.Impulse�� �������� ���� ���� ����
                rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            }
        }
    }
}

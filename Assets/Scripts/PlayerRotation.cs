using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float mouseSensitivity = 3.0f; // ���콺 ����
    private float rotationY = 0f; // ���� Y�� ȸ����

    void Update()
    {
        // ���콺 �Է°� �ޱ�
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;

        // Y�� ȸ���� ������Ʈ
        rotationY += mouseX;

        // �÷��̾� ȸ�� ���� (Y�� ȸ��)
        transform.rotation = Quaternion.Euler(0, rotationY, 0);
    }
}

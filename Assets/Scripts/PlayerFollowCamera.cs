using UnityEngine;

public class PlayerFollowCamera : MonoBehaviour
{
    public Transform target;  // �÷��̾ ���� ���
    public Vector3 offset = new Vector3(0, 5, -20); // ī�޶� ��ġ ������
    public float rotationSpeed = 3.0f; // ���콺�� ȸ�� �ӵ�

    private float currentX = 0f; // ���콺 X ȸ����
    private float currentY = 0f; // ���콺 Y ȸ����
    private float minY = -20f, maxY = 60f; // Y�� ȸ�� ����

    void Update()
    {
        // ���콺 �Է� �޾Ƽ� ȸ�� �� ����
        currentX += Input.GetAxis("Mouse X") * rotationSpeed;
        currentY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        currentY = Mathf.Clamp(currentY, minY, maxY); // Y�� ȸ�� ����
    }

    void LateUpdate()
    {
        // ī�޶� ȸ�� ����
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        transform.position = target.position + rotation * offset; // �÷��̾��� ��ġ�� ī�޶� ������ ����
        transform.LookAt(target.position); // ī�޶� �÷��̾ �ٶ󺸵��� ����
    }
}

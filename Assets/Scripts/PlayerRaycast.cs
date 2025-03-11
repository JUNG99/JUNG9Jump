using UnityEngine;
using UnityEngine.UI;

public class PlayerRaycast : MonoBehaviour
{
    public Camera playerCamera; // �÷��̾��� ������ ���󰡴� ī�޶�
    public float raycastDistance = 5f; // Ray�� Ž���ϴ� �Ÿ�
    public LayerMask interactableLayer; // ������ ������Ʈ�� �ִ� ���̾�
    public Text infoText; // UI���� ������ ǥ���� �ؽ�Ʈ

    public float heightOffset = 1.8f; // �Ӹ� ��ġ�� ���� �߻� ���� ����

    private void Update()
    {
        RaycastForObjects();
    }

    private void RaycastForObjects()
    {
        // �÷��̾��� �Ӹ� ��ġ�� ��� (heightOffset�� ���)
        Vector3 rayOrigin = transform.position + Vector3.up * heightOffset; // �÷��̾� ������ ��ġ���� ���� �̵��Ͽ� �Ӹ� ��ġ

        // ī�޶��� �������� �ٶ󺸴� ������ �������� Raycast ������ ����
        Vector3 rayDirection = playerCamera.transform.forward;

        // ������ ��θ� ȭ�鿡 ���� ������ ǥ��
        Debug.DrawRay(rayOrigin, rayDirection * raycastDistance, Color.red);

        // Ray�� �浹�ߴ��� Ȯ��
        Ray ray = new Ray(rayOrigin, rayDirection); // Ray ����
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, raycastDistance, interactableLayer))
        {
            string objectName = hit.collider.name; // ������Ʈ �̸� ��������
            string objectDescription = hit.collider.GetComponent<InteractableObject>()?.GetDescription(); // ������Ʈ ���� ��������

            // UI�� ���� ��� ǥ��
            infoText.text = "���� ��: " + objectName + "\n" + (objectDescription ?? "���� ����");
        }
        else
        {
            // �ƹ��͵� ������� �ʾ��� �� UI�� ���
            infoText.text = "";
        }
    }
}

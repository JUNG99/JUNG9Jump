using UnityEngine;

public class PlayerRotation : MonoBehaviour
{
    public float mouseSensitivity = 3.0f; // 마우스 감도
    private float rotationY = 0f; // 현재 Y축 회전값

    void Update()
    {
        // 마우스 입력값 받기
        float mouseX = Input.GetAxis("Mouse X") * mouseSensitivity;

        // Y축 회전값 업데이트
        rotationY += mouseX;

        // 플레이어 회전 적용 (Y축 회전)
        transform.rotation = Quaternion.Euler(0, rotationY, 0);
    }
}

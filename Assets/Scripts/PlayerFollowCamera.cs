using UnityEngine;

public class PlayerFollowCamera : MonoBehaviour
{
    public Transform target;  // 플레이어를 따라갈 대상
    public Vector3 offset = new Vector3(0, 5, -20); // 카메라 위치 오프셋
    public float rotationSpeed = 3.0f; // 마우스로 회전 속도

    private float currentX = 0f; // 마우스 X 회전값
    private float currentY = 0f; // 마우스 Y 회전값
    private float minY = -20f, maxY = 60f; // Y축 회전 제한

    void Update()
    {
        // 마우스 입력 받아서 회전 값 변경
        currentX += Input.GetAxis("Mouse X") * rotationSpeed;
        currentY -= Input.GetAxis("Mouse Y") * rotationSpeed;
        currentY = Mathf.Clamp(currentY, minY, maxY); // Y축 회전 제한
    }

    void LateUpdate()
    {
        // 카메라 회전 적용
        Quaternion rotation = Quaternion.Euler(currentY, currentX, 0);
        transform.position = target.position + rotation * offset; // 플레이어의 위치에 카메라 오프셋 적용
        transform.LookAt(target.position); // 카메라가 플레이어를 바라보도록 설정
    }
}

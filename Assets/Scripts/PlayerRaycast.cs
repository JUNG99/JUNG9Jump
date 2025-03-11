using UnityEngine;
using UnityEngine.UI;

public class PlayerRaycast : MonoBehaviour
{
    public Camera playerCamera; // 플레이어의 시점을 따라가는 카메라
    public float raycastDistance = 5f; // Ray가 탐색하는 거리
    public LayerMask interactableLayer; // 조사할 오브젝트가 있는 레이어
    public Text infoText; // UI에서 정보를 표시할 텍스트

    public float heightOffset = 1.8f; // 머리 위치로 레이 발사 높이 조정

    private void Update()
    {
        RaycastForObjects();
    }

    private void RaycastForObjects()
    {
        // 플레이어의 머리 위치를 계산 (heightOffset을 사용)
        Vector3 rayOrigin = transform.position + Vector3.up * heightOffset; // 플레이어 몸통의 위치에서 위로 이동하여 머리 위치

        // 카메라의 시점에서 바라보는 방향을 기준으로 Raycast 방향을 설정
        Vector3 rayDirection = playerCamera.transform.forward;

        // 레이의 경로를 화면에 빨간 선으로 표시
        Debug.DrawRay(rayOrigin, rayDirection * raycastDistance, Color.red);

        // Ray가 충돌했는지 확인
        Ray ray = new Ray(rayOrigin, rayDirection); // Ray 생성
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, raycastDistance, interactableLayer))
        {
            string objectName = hit.collider.name; // 오브젝트 이름 가져오기
            string objectDescription = hit.collider.GetComponent<InteractableObject>()?.GetDescription(); // 오브젝트 설명 가져오기

            // UI에 조사 결과 표시
            infoText.text = "조사 중: " + objectName + "\n" + (objectDescription ?? "설명 없음");
        }
        else
        {
            // 아무것도 조사되지 않았을 때 UI를 비움
            infoText.text = "";
        }
    }
}

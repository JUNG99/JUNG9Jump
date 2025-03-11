using UnityEngine;

public class InteractableObject : MonoBehaviour
{
    public string description = "돌"; // 오브젝트 설명

    public string GetDescription()
    {
        return description;
    }
}

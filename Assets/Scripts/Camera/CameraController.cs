using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset = new Vector3(0, 10, -7);

    // LateUpdate: Player의 FixedUpdate/Update가 모두 끝난 뒤 실행
    // → 카메라가 이동 완료된 위치를 추적하므로 떨림 없음
    private void LateUpdate()
    {
        if (target == null) return;
        transform.position = target.position + offset;
        transform.LookAt(target);
    }
}

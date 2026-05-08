using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offset = new Vector3(0, 10, -7);

    // LateUpdate: 모든 Update 끝난 후 실행 → 카메라가 이동 완료된 위치를 추적
    private void LateUpdate()
    {
        if (_target == null)
        {
            return;
        }

        transform.position = _target.position + _offset;
        transform.LookAt(_target);
    }
}

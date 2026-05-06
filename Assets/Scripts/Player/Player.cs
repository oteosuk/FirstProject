using UnityEngine;

public class Player : Entity
{
    [SerializeField] private float moveSpeed = 5f;
    private Rigidbody _rb;

    protected override void Awake()
    {
        base.Awake(); // Entity.Awake() 호출 (currentHp 초기화)
        _rb = GetComponent<Rigidbody>();
    }

    // FixedUpdate: 물리 연산은 반드시 여기서 — 프레임률과 무관하게 고정 간격 실행
    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(h, 0, v).normalized;
        _rb.MovePosition(_rb.position + dir * moveSpeed * Time.fixedDeltaTime);
    }

    // Entity.Die() Override: Player만의 사망 처리
    protected override void Die()
    {
        Debug.Log("Player 사망 — Game Over");
        gameObject.SetActive(false);
    }
}

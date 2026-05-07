using UnityEngine;

public class Player : Entity
{
    [SerializeField] private float _moveSpeed = 5f;
    private Rigidbody _rb;

    protected override void Awake()
    {
        base.Awake();
        _rb = GetComponent<Rigidbody>();
    }

    private void FixedUpdate()
    {
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(h, 0, v).normalized;
        _rb.MovePosition(_rb.position + dir * _moveSpeed * Time.fixedDeltaTime);
    }

    protected override void Die()
    {
        Debug.Log("Player 사망 — Game Over");
        gameObject.SetActive(false);
    }
}

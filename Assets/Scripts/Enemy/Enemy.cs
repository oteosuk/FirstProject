using UnityEngine;

public class Enemy : Entity
{
    // TakeDamage Override: 적은 피격 시 색상 변화 추가
    public override void TakeDamage(float damage)
    {
        // 추가 처리 후 부모 로직 실행
        base.TakeDamage(damage);
    }

    // Entity.Die() Override: Enemy만의 사망 처리
    protected override void Die()
    {
        Debug.Log($"{gameObject.name} 사망");
        Destroy(gameObject);
    }
}

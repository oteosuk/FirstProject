using UnityEngine;

// 모든 살아있는 오브젝트(Player, Enemy)의 공통 기반
// abstract: 직접 인스턴스화 불가, 반드시 상속해서 사용
public abstract class Entity : MonoBehaviour, IDamageable
{
    [SerializeField] protected float maxHp = 100f;
    protected float currentHp;

    protected virtual void Awake()
    {
        currentHp = maxHp;
    }

    // Overloading: 피해량만 받는 버전
    public virtual void TakeDamage(float damage)
    {
        currentHp -= damage;
        if (currentHp <= 0)
            Die();
    }

    // Overloading: 피해량 + 출처를 받는 버전
    public virtual void TakeDamage(float damage, string damageSource)
    {
        Debug.Log($"[{gameObject.name}] {damageSource}로부터 {damage} 피해");
        TakeDamage(damage);
    }

    // abstract: 하위 클래스에서 반드시 구현해야 함
    protected abstract void Die();
}

using UnityEngine;

public abstract class Entity : MonoBehaviour, IDamageable
{
    [SerializeField] protected float _maxHp = 100f;
    protected float _currentHp;

    protected virtual void Awake()
    {
        _currentHp = _maxHp;
    }

    public virtual void TakeDamage(float damage)
    {
        _currentHp -= damage;
        if (_currentHp <= 0)
        {
            Die();
        }
    }

    public virtual void TakeDamage(float damage, string damageSource)
    {
        Debug.Log($"[{gameObject.name}] {damageSource}로부터 {damage} 피해");
        TakeDamage(damage);
    }

    protected abstract void Die();
}

public interface IDamageable
{
    void TakeDamage(float damage);
    void TakeDamage(float damage, string damageSource); // Overloading: 같은 메서드명, 다른 매개변수
}

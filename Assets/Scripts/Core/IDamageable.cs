public interface IDamageable
{
    void TakeDamage(float damage);
    void TakeDamage(float damage, string damageSource); // Overloading
}

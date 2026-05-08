using UnityEngine;

public class Enemy : Entity
{
    // Override: Entity.Die()를 Enemy에 맞게 재정의
    protected override void Die()
    {
        Debug.Log($"{gameObject.name} 사망");
        Destroy(gameObject);
    }
}

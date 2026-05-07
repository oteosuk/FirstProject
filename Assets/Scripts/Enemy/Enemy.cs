using UnityEngine;

public class Enemy : Entity
{
    protected override void Die()
    {
        Debug.Log($"{gameObject.name} 사망");
        Destroy(gameObject);
    }
}

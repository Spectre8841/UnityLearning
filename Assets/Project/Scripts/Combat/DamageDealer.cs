using UnityEngine;

public class DamageDealer : MonoBehaviour
{
    public int damage = 1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        Health health = other.GetComponent<Health>();
        if (health != null)
        {
            health.TakeDamage(damage);
        }
    }
}

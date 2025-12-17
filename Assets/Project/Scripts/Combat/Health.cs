using UnityEngine;

public class Health : MonoBehaviour
{
    public int maxHealth = 5;
    public int currentHealth;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;

        if (currentHealth <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        Debug.Log($"{gameObject.name} died");
        Destroy(gameObject);
    }
}

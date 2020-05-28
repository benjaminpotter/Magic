using UnityEngine;

// all things that have health in the world have this component
public class Living : MonoBehaviour
{
    // this might use a scriptable object in the future
    [SerializeField] private float maxHealth;
    private float health;

    void Start()
    {
        health = maxHealth;
    }

    public void Hurt(float damage)
    {
        health -= damage;

        if (health <= 0)
            Die();
    }

    private void Die()
    {
        Debug.Log(name + " died.");

        // destroy this enemy
        Destroy(gameObject);
    }
}

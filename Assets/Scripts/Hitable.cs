using UnityEngine;

// all things that can take damage from external sources have this component

[RequireComponent(typeof(Living))] // if it can take damage it needs to be "living"
public class Hitable : MonoBehaviour
{
    private Living living;

    private void Start()
    {
        living = GetComponent<Living>();
    }

    public void Hit(float damage)
    {
        living.Hurt(damage);
        Debug.Log(name + " took " + damage + " damage.");
    }
}

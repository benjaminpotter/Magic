using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private SpriteRenderer sprite;

    void Start()
    {
        sprite = GetComponentInChildren<SpriteRenderer>();
    }

    public void FlipSprite(bool facingRight)
    {
        sprite.flipX = !facingRight;
    }

    public void Move(float target)
    {
        transform.Translate(new Vector2(target, transform.position.y));
    }
}

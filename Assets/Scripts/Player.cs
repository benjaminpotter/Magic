using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private InputAction controls;
    private PlayerController controller;

    void Start()
    {
        controller = GetComponent<PlayerController>();
    }

    void OnEnable()
    {
        controls.Enable();
    }

    void Update()
    {
        float move = controls.ReadValue<float>();

        if (move != 0.0f)
        {
            controller.Move(move * speed * Time.deltaTime);
            controller.FlipSprite(move > 0);
        }
    }

    void OnDisable()
    {
        controls.Disable();
    }
}
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
        controller.Move(move * speed * Time.deltaTime);

        if (move != 0.0f)
            controller.FlipSprite(move > 0);

        Debug.Log(move);
    }

    void OnDisable()
    {
        controls.Disable();
    }
}
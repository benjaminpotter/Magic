using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(PlayerController))]
[RequireComponent(typeof(Combatant))]
public class Player : MonoBehaviour
{
    [SerializeField] private float speed;

    [SerializeField] private InputAction controls;
    private PlayerController controller;

    [SerializeField] private InputAction attack;
    private Combatant combatant;

    void Start()
    {
        controller = GetComponent<PlayerController>();
        combatant = GetComponent<Combatant>();
    }

    void OnEnable()
    {
        controls.Enable();

        attack.performed += HandleAttack;
        attack.Enable();
    }
    
    void HandleAttack(InputAction.CallbackContext context)
    {
        combatant.Attack();
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
        attack.Disable();
    }
}
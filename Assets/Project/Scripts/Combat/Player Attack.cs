using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerAttack : MonoBehaviour
{
    private PlayerControls controls;
    public GameObject attackHitbox;
    public float attackDuration = 0.2f;

    private void Awake()
    {
        controls = new PlayerControls();
    }

    private void OnEnable()
    {
        controls.Enable();
        controls.Player.Attack.performed += _ => Attack();
    }

    private void OnDisable()
    {
        controls.Player.Attack.performed -= _ => Attack();
        controls.Disable();
    }

    private void Attack()
    {
        attackHitbox.SetActive(true);
        Invoke(nameof(DisableHitbox), attackDuration);
    }

    private void DisableHitbox()
    {
        attackHitbox.SetActive(false);
    }
}

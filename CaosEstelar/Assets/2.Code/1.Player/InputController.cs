using System.Collections;
using UnityEngine.InputSystem;
using UnityEngine;

public class InputController : MonoBehaviour
{
    [SerializeField] private InputAction _moveInput = null;
    [SerializeField] private InputAction _jumpInput = null;

    private void OnEnable()
    {
        _moveInput.Enable();
        _jumpInput.Enable();
    }

    private void OnDisable()
    {
        _moveInput.Disable();
        _jumpInput.Disable();
    }

    public Vector2 GetMoveInput()
    {
        return _moveInput.ReadValue<Vector2>();
    }

    public bool IsJumpInput()
    {
        return _jumpInput.triggered;
    }
}

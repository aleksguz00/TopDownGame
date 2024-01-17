using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.UIElements;

public class GameInput : MonoBehaviour
{
    private PlayerInputActions _playerInputActions;

    public static GameInput Instance { get; private set; }

    private void Awake()
    {
        Instance = this;

        _playerInputActions = new PlayerInputActions();
        _playerInputActions.Enable();
    }

    public Vector2 GetMovementVector()
    {
        Vector2 inputVector = _playerInputActions.Player.Move.ReadValue<Vector2>();

        return inputVector;
    }

    public Vector3 GetMousePosition()
    {
        Vector3 mousePos = Mouse.current.position.ReadValue();

        return mousePos;
    }
}

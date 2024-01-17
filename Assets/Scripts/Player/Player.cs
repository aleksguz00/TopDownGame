using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private float _speed = 10f;
    
    private Rigidbody2D _rb;

    private float _minMovementSpeed = 0.1f;
    private bool _isRunning = false;

    public static Player Instance { get; private set; }

    private void Awake()
    {
        Instance = this;
        _rb = GetComponent<Rigidbody2D>();        
    }
    
    private void FixedUpdate()
    {
        HandleMovement();
    }

    private void HandleMovement()
    {
        Vector2 inputVector = GameInput.Instance.GetMovementVector();
        // inputVector = inputVector.normalized;     
        _rb.MovePosition(_rb.position + inputVector * (_speed * Time.fixedDeltaTime));

        if (Mathf.Abs(inputVector.x) > _minMovementSpeed || Mathf.Abs(inputVector.y) > _minMovementSpeed)
        {
            _isRunning = true;
        }
        else
        {
            _isRunning = false;
        }
    }

    public bool IsRunning()
    {
        return _isRunning;
    }

    public Vector3 GetPlayerScreenPosition()
    {
        Vector3 playerScreenPosition = Camera.main.WorldToScreenPoint(transform.position);

        return playerScreenPosition;
    }
}

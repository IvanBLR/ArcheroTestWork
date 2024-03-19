using UnityEngine;

[RequireComponent(typeof(PlayerFireController))]
public class PlayerMovementController : MonoBehaviour
{
    public bool IsPlayerMoving => _isMoving;

    [SerializeField] private float _speed;

    private Rigidbody _rigidBody;
    private PlayerInputActions _input;
    private bool _isMoving;

    private void Awake()
    {
        _rigidBody = transform.GetComponent<Rigidbody>();
        _input = new PlayerInputActions();
    }

    private void OnEnable()
    {
        _input.Enable();
    }

    private void OnDisable()
    {
        _input.Disable();
    }

    private void Update()
    {
        if (_input.Player.Move.IsPressed())
        {
            _isMoving = true;
            var inputValue = _input.Player.Move.ReadValue<Vector2>();

            Vector3 moveDirection = new Vector3(inputValue.x, 0, inputValue.y).normalized;

            _rigidBody.velocity = moveDirection * _speed;
            if (moveDirection != Vector3.zero)
            {
                transform.rotation = Quaternion.LookRotation(moveDirection);
            }
        }
        else
        {
            _isMoving = false;
        }
    }
}
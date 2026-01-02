using UnityEngine;

public class PhysicsMovement : MonoBehaviour
{
    [SerializeField] private float _speed = 4f;
    [SerializeField] private float _jumpForce = 8f;
    [SerializeField] private float _fallMultiplier = 2.5f;
    [SerializeField] private float _lowJumpMultiplier = 12f;
    [SerializeField] private Rigidbody2D _rigidbody;

    private Direction _direction = Direction.Left;

    public bool IsGrounded;
    public Transform GroundCheck;
    public float CheckRadius;
    public LayerMask GroundLayerMask;

    public float Speed => _rigidbody.velocity.magnitude;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        Move();
        Jump();
        
        // 调整角色方向，根据速度进行调整
        if (_rigidbody.velocity.x < -0.1f) _direction = Direction.Left;
        else if (_rigidbody.velocity.x > 0.1f) _direction = Direction.Right;

        Vector3 scale = transform.localScale;
        scale.x = Mathf.Abs(scale.x) * (int)_direction;
        this.transform.localScale = scale;
    }

    /// <summary>
    /// Day3：rb.velocity 位移方法，通过修改刚体速度让物理引擎进行位移
    /// </summary>
    private void Move()
    {
        Vector2 input = new Vector2(Input.GetAxis("Horizontal") * _speed, _rigidbody.velocity.y);
        _rigidbody.velocity = input;
    }

    private void Jump()
    {
        if (_rigidbody == null) return;

        IsGrounded = Physics2D.OverlapCircle(GroundCheck.position, CheckRadius, GroundLayerMask);

        if (Input.GetButtonDown("Jump") && IsGrounded)
        {
            _rigidbody.velocity = new Vector2(_rigidbody.velocity.x, _jumpForce);
        }

        ControlJumpHeight();
    }

    private void ControlJumpHeight()
    {
        if (_rigidbody.velocity.y < 0)
        {
            _rigidbody.velocity += Physics2D.gravity.y * (_fallMultiplier - 1) * Time.deltaTime * Vector2.up;
        }
        else if (_rigidbody.velocity.y > 0 && !Input.GetButton("Jump"))
        {
            _rigidbody.velocity += Physics2D.gravity.y * (_lowJumpMultiplier - 1) * Time.deltaTime * Vector2.up;
        }
    }

    /// <summary>
    /// Day4：2D 物理系统，碰撞体部分（刚体撞上碰撞体）
    /// </summary>
    /// <param name="other"></param>
    private void OnCollisionEnter2D(Collision2D other)
    {
        // 使用 CompareTag 进行比较而不是 other.tag == "Ground"
        if (other.gameObject.CompareTag("Ground"))
        {
            Debug.Log(other.gameObject.name);
        }
    }
}
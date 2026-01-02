using UnityEngine;

public class CatBehaviour : MonoBehaviour
{
    private Animator _animator;
    private PhysicsMovement _movement;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _movement = GetComponent<PhysicsMovement>();
    }

    /// <summary>
    /// Day5：修改动画机中的 speed 变量来驱动动画
    /// </summary>
    private void Update()
    {
        _animator.SetFloat("speed", _movement.Speed);
    }
}
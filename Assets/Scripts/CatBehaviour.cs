using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatBehaviour : MonoBehaviour
{
    [SerializeField] private Animator _animator;
    [SerializeField] private PhysicsMovement _movement;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        _movement = GetComponent<PhysicsMovement>();
    }

    private void Update()
    {
        _animator.SetFloat("speed", _movement.Speed);
    }
}
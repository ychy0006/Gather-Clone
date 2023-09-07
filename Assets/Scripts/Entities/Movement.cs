using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Movement : MonoBehaviour
{
    private GameCharacterController _controller;
    public Animator anim;

    private Vector2 _movementDirection = Vector2.zero;
    private Rigidbody2D _rigidbody;

    private void Awake()
    {
        _controller = GetComponent<GameCharacterController>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }
    private void Start()
    {
        _controller.OnMoveEvent += Move;
        _controller.OnMoveEvent += Run;
    }
    private void Move(Vector2 direction)
    {
        _movementDirection = direction;
    }
    private void FixedUpdate()
    {
        ApplyMovement(_movementDirection);
    }
    private void ApplyMovement(Vector2 direction)
    {
        direction = direction * 5;
        _rigidbody.velocity = direction;
    }
    private void Run(Vector2 direction)
    {
        if (direction != Vector2.zero) anim.SetBool("running", true);
        else anim.SetBool("running", false);
    }
}

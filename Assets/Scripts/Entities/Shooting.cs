using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hooting : MonoBehaviour
{
    private GameCharacterController _contoller;

    [SerializeField] private Transform projectileSpawnPosition;
    private Vector2 _aimDirection = Vector2.right;

    public GameObject testPrefab;

    private void Awake()
    {
        _contoller = GetComponent<GameCharacterController>();
    }

    // Start is called before the first frame update
    void Start()
    {
        _contoller.OnLookEvent += OnAim;
        _contoller.OnAttackEvent += OnShoot;
    }

    private void OnAim(Vector2 newAimDirection)
    {
        _aimDirection = newAimDirection;
    }

    private void OnShoot()
    {
        CreateProjectile();
    }

    private void CreateProjectile()
    {
        float rotZ = Mathf.Atan2(_aimDirection.y, _aimDirection.x) * Mathf.Rad2Deg;
        projectileSpawnPosition.rotation = Quaternion.Euler(0, 0, rotZ);

        Instantiate(testPrefab, projectileSpawnPosition.position, Quaternion.Euler(0, 0, rotZ - 90));
    }
}
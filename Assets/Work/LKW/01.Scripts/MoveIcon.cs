using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveIcon : MonoBehaviour
{
    private Rigidbody2D _rigidbody;
    private Vector3 _moveDir;
    [SerializeField] private float _moveSpeed = 4;

    private void Awake()
    {
        _rigidbody = GetComponent<Rigidbody2D>();

    }

    private void Start()
    {
        RandomDir();
    }

    private void FixedUpdate()
    {
        _rigidbody.velocity = _moveDir * _moveSpeed;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        RandomDir();
    }

    private void RandomDir()
    {
        _moveDir =  Random.insideUnitCircle;
    }
    
}


using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float moveSpeed = 15f;

    private Vector3 delta;
    private Vector3 direction;
    private void Update()
    {
        delta = _target.position - transform.position;
        direction = delta.normalized;
        
        transform.LookAt(_target);
    }

    private void Move(Vector3 direction)
    {
        _rigidbody.velocity = direction * Time.fixedDeltaTime * moveSpeed;
    }
    private void FixedUpdate()
    {
        Move(direction);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            Time.timeScale = 0;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Bullet"))
        {
            gameObject.SetActive(false);
            other.gameObject.SetActive(false);
        }
    }
}

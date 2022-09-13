using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletController : MonoBehaviour
{
    [SerializeField] private float speed = 15f;
    private Vector3 _movement;

    public void Fire(Vector3 direction)
    {
        _movement = direction * Time.deltaTime * speed;
    }

    private void Update()
    {
        transform.position += _movement;
    }

    private void OnEnable()
    {
        StartCoroutine(Deactive());
    }

    IEnumerator Deactive()
    {
        yield return new WaitForSeconds(5f);
        gameObject.SetActive(false);
    }
}

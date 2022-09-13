using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    [SerializeField] private Transform _target;
    [SerializeField] private Vector3 _offet;

    private void Start()
    {
        _offet = transform.position - _target.position;
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position,_target.position + _offet, 25f * Time.deltaTime);
    }
}

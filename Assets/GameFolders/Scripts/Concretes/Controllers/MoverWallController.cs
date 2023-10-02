using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoverWallController : WallController
{
    [SerializeField] Vector3 _direction;
    [SerializeField]float _speed;
    [SerializeField] float _factor;

    Vector3 _startPosition;
    private const float full_circle = Mathf.PI * 2f;

    private void Awake()
    {
        _startPosition = transform.position;
    }

    private void Update()
    {
        float cycle = Time.time / _speed;
        float sinWawe=  Mathf.Sin(cycle * full_circle);
        _factor = Mathf.Abs(sinWawe);
         Vector3 offset = _direction * _factor;
        transform.position = offset + _startPosition;
    }
}

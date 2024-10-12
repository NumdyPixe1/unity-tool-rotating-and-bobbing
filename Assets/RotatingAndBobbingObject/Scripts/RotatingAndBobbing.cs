using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatingAndBobbing : MonoBehaviour
{
    public float _rotateSpeed;
    public float _bobSpeed;//ความเร็ว
    public float _amplitude;//ความสูงของคลื่น
    float _sineValue;
    Vector3 _startPos;
    Vector3 _startRotate;
    private void Start()
    {
        _startPos = transform.position;
    }
    private void Update()
    {
        Rotating();
        Bobbing();
    }
    private void Rotating()
    {
        transform.rotation *= Quaternion.Euler(0, _rotateSpeed, 0);
    }
    private void Bobbing()
    {     
        _sineValue = _startPos.y + Mathf.Sin(Time.time * _bobSpeed) * _amplitude;
        transform.position = _startPos + Vector3.up *_sineValue;
    }
}

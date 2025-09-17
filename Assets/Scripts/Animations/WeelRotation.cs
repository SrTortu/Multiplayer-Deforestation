using System;
using System.Collections;
using System.Collections.Generic;
using DG.Tweening;
using UnityEngine;

public class WeelRotation : MonoBehaviour
{
    
    [SerializeField] private Rigidbody _rigidbody;
    [SerializeField] private float _rotationSpeed;
    

    void FixedUpdate()
    {
        if (_rigidbody.velocity.magnitude > 1f)
        {
            transform.Rotate(0,3f,0);
        }
    }
}

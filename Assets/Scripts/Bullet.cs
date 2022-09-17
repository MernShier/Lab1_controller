using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    [SerializeField] private float lifeTime, speed;
    private Rigidbody _rb;
    private float _lifeTimer;

    private void Start()
    {
        _rb = gameObject.GetComponent<Rigidbody>();
    }

    private void Update()
    {
        _lifeTimer += Time.deltaTime;
        if (_lifeTimer >= lifeTime)
        {
            Destroy(gameObject);
        }
        _rb.AddForce(_rb.transform.forward*speed,ForceMode.Acceleration);
    }
     private void OnCollisionEnter(Collision collision)
     {
         Destroy(gameObject);
     }
}

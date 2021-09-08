using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missle : ProjectileBase
{
    [SerializeField] float _travelSpeed = 10f;

    protected float TravelSpeed => _travelSpeed;
    protected override void ShootProjectile(GameObject missle)
    {
        Debug.Log("Missle");
        Rigidbody rb;
        rb = missle.GetComponent<Rigidbody>();
        rb.velocity = Vector3.forward * _travelSpeed;
    }
}

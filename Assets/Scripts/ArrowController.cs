using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEngine;
using UnityEngine.UI;

public class ArrowController : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rb;
    void Update()
    {
        Movement();
    }

    void Movement()
    {
        Vector2 direction = rb.velocity;

        float angle = Mathf.Atan2(direction.y, direction.x)*Mathf.Rad2Deg;
        
        transform.rotation = Quaternion.AngleAxis(angle,Vector3.forward);
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "Target")
        {
            rb.isKinematic = true;
            rb.velocity = Vector2.zero;
        }
    }
}

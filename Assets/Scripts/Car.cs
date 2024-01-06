using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField]  private float speed;

    private void FixedUpdate()
    {
        transform.position += transform.forward * speed;
    }
}

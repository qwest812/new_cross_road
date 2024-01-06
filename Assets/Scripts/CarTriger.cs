using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarTriger : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Car"))
        {
            other.transform.position -= other.transform.forward * 25;
        }
    }
}

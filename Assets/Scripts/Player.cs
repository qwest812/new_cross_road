using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    [SerializeField] private Vector3 targetPosition;
    [SerializeField] private float speed;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition = transform.position; // Initialize targetPosition to current position
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
           this.Step();
        }
    }

    private void FixedUpdate()
    {
        // Smoothly move towards the target position
        transform.position = Vector3.MoveTowards(transform.position, targetPosition, speed * Time.fixedDeltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Car"))
        {
            SceneManager.LoadScene(0);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(0);
    }

    public void Step()
    {
        targetPosition = transform.position + transform.forward;
    }
}
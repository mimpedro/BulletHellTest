using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Decelerate : MonoBehaviour {

    public float deceleration;
    public UnityEvent eventWhenFullStop;

    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate () {
        float speed = rb.velocity.magnitude;
        speed -= deceleration * Time.fixedDeltaTime;

		if (speed < 0)
        {
            eventWhenFullStop.Invoke();
        }

        rb.velocity = rb.velocity.normalized * speed;

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour {
    public float timeOut = 20f;

    private Rigidbody rb;
    private float timer;
    
    void Awake () {
        rb = GetComponent<Rigidbody>();
	}
	
	void Update () {
        timer += Time.deltaTime;
        if (timer > timeOut)
        {
            Destroy(this.gameObject);
        }
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Limits"))
        {
            Destroy(this.gameObject);
        }
    }

    public void Shoot(float v)
    {
        rb.velocity = transform.forward * v;
    }
}

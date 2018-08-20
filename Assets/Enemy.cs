using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {
    public GameObject bullet;
    public float shotSpeed = 0.1f;

	void Start () {
        Shoot();
    }
	
	void Shoot () {
        foreach (Vector3 p in GeometricPatterns.GetIcosphereVertices(1))
        {
            GameObject b = GameObject.Instantiate(bullet);
            b.transform.position = transform.position;
            b.transform.forward = p;
            b.GetComponent<Bullet>().Shoot(shotSpeed);
        }

        GeometricPatterns.CreateIcosphere(1);
    }
}

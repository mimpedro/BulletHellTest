using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public GameObject bullet;
    public float shootInterval;
    public float shootSpeed;

    private float shootingTimer;

    void Start () {
		//SteamVR.hand
	}
	
	void Update () {
        shootingTimer += Time.deltaTime;
        if (shootingTimer > shootInterval)
        {
            shootingTimer -= shootInterval;
            GameObject b = GameObject.Instantiate(bullet, transform.position, transform.rotation);
            Bullet bulletScript = b.GetComponent<Bullet>();
            bulletScript.Shoot(shootSpeed);
            //b.GetComponent<Rigidbody>().velocity = transform.forward * shootSpeed;
        }
	}
}

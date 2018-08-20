using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireConstantly : MonoBehaviour {
    public GameObject bullet;
    public float shotSpeed = 0.1f;

    private Vector3 [] shotDirections;
    //public enum direction
	void Start () {
        shotDirections = new Vector3[]
        {
            Vector3.forward,
            Vector3.back,
            Vector3.up,
            Vector3.down,
            Vector3.right,
            Vector3.left
        };
        StartCoroutine("FireRoutine");
	}
	
	void Update () {
		
	}

    void Fire()
    {
        for (int i = 0; i < shotDirections.Length; i++)
        {
            GameObject b = GameObject.Instantiate(bullet);
            b.transform.position = transform.position;
            b.transform.forward = transform.rotation * shotDirections[i];
            b.transform.parent = null;
            Bullet bulletScript = b.GetComponent<Bullet>();
            bulletScript.Shoot(shotSpeed);
        }
    }

    IEnumerator FireRoutine()
    {
        while (true)
        {
            Fire();
            yield return new WaitForSeconds(0.2f);

        }
    }
}

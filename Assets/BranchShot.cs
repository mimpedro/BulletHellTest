using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BranchShot : MonoBehaviour {
    public GameObject shot;
    public int amount;
    public float angle;

    public bool destroyOriginalBullet = true;

    public void Branch()
    {
        Vector3[] branches = GeometricPatterns.BranchVector(transform.forward, amount, angle);
        Debug.Log(branches.Length);
        for (int i = 0; i < amount; i++)
        {
            GameObject b = GameObject.Instantiate(shot);
            b.transform.position = transform.position;
            b.transform.forward = branches[i];
            b.GetComponent<Bullet>().Shoot(0.5f);
        }
        Destroy(this.gameObject);
    }
}

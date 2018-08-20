using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {
    float angularSpeed;

	void FixedUpdate () {
        transform.Rotate(transform.forward, angularSpeed * Time.fixedDeltaTime);
	}
}

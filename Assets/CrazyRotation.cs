using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrazyRotation : MonoBehaviour {
    public float speed;
    public float maxAngularSpeed;

    Quaternion rotation;
    float angularTilt;
    float previousTiltValue;
    float targetTiltValue;

	void Update ()
    {
        Vector3 angle = transform.localEulerAngles;

        int direction = (targetTiltValue > angularTilt ? 1 : -1);
        angularTilt += direction * 0.1f * Time.deltaTime;

        if ((angularTilt >= targetTiltValue) == (direction >= 0))
        {
            targetTiltValue = Random.Range(-1, 1) * maxAngularSpeed;
        }
        //angle.y += angularTilt;
        //angle.x += speed;

        transform.rotation = Quaternion.Euler(speed * Time.deltaTime, angularTilt * Time.deltaTime, 0) * transform.rotation;
        
        //rotation = Quaternion. Time.deltaTime;
    }
}

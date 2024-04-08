using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerInput : MonoBehaviour
{
    private Rigidbody rigid;
    public float speed;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();

        Vibration.Init();
    }
    private void Update()
    {
        Vector3 tilt = Input.acceleration;

        tilt = Quaternion.Euler(-90, 0, 0) * tilt;

        rigid.AddForce(tilt * speed);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Box"))
        {
            Vibration.Vibrate();
        }
    }
}

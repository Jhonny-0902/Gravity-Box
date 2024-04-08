using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerInput : MonoBehaviour
{
    private Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();

        Vibration.Init();
    }
    private void Update()
    {
        rigid.AddForce(Input.acceleration.x, 0, -Input.acceleration.z);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Box"))
        {
            Vibration.Vibrate();
        }
    }
}

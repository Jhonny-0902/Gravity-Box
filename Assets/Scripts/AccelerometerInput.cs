using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AccelerometerInput : MonoBehaviour
{
    private Rigidbody rigid;

    private void Start()
    {
        rigid = GetComponent<Rigidbody>();
    }
    private void Update()
    {
        rigid.AddForce(Input.acceleration.x, 0, -Input.acceleration.z);
    }
}

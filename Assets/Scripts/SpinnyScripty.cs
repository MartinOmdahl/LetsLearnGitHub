using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnyScripty : MonoBehaviour
{
    float spinSpeed = -1;

    ConstantForce constForce;
    void Start()
    {
        constForce = GetComponent<ConstantForce>();
    }

    void Update()
    {
        //constForce.relativeTorque = new Vector3(0, 0, constForce.relativeTorque.z - Time.deltaTime);

        spinSpeed -= Time.deltaTime;
        transform.Rotate(0, 0, spinSpeed * Time.deltaTime);
    }
}

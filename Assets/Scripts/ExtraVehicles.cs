using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExtraVehicles : MonoBehaviour
{
    private float speed = 9;

    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRotator : MonoBehaviour
{
    public Vector3 Axis = Vector3.up;

    public float Speed = 10;
    
    void Update()
    {
        transform.Rotate(Axis, Speed * Time.deltaTime);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Galaxy_Motion : MonoBehaviour
{
    public float Speed;

    void Update()
    {
        transform.Rotate(Vector3.up, Speed*Time.deltaTime);
    }
}

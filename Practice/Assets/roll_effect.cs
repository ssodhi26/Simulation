using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class roll_effect : MonoBehaviour
{
    Rigidbody rb;
    public float speedr;
    public float speedt;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.forward*speedr*Time.deltaTime);
        transform.Translate(Vector3.forward * speedt * Time.deltaTime);
    }
}

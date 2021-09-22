using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitController : MonoBehaviour
{
    public Rigidbody rb;
    public float speed = 0.9f;
    //int counter = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
        //if (counter!=0)
        //{
          //counter--;
       // break;
        //}
        if (Input.GetKey(KeyCode.Space))
        //if (counter==0)
        //else
        {
            Rigidbody instantiatedrb = Instantiate(rb, transform.position, transform.rotation) as Rigidbody;
            instantiatedrb.velocity = transform.TransformDirection(new Vector3(0, 0, speed));
        }
       
    }
}

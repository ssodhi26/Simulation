using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Asteroid_Controller : MonoBehaviour
{
    //GameObject asteroid;
    Vector3 motion;
    //Vector3 limit;
    float speed = 0.9f;
    
    void Start()
    {
        //myAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //limit = new Vector3(10.0f, -4.0f, 0.0f);
        //myAnim.SetFloat(("VSpeed"), Input.GetAxis("Vertical"));
        //myAnim.SetFloat(("HSpeed"), Input.GetAxis("HoriZontal"));
        //myAnim.SetFloat(("DSpeed"), Input.GetAxis("Vertical")+Input.GetAxis("Horizontal"));
        //while (asteroid.transform.position==limit)
        //{
            motion = new Vector3(0.5f, -0.2f, 0.0f);
            transform.Translate(motion * speed);
            //break;
        //}
        
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loop : MonoBehaviour
{
    Vector3 motion;
    float speed = 0.9f;
    // Start is called before the first frame update
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.CompareTag("asteroid"))
        {
            motion = new Vector3(0.5f, -0.2f, 0.0f);
            transform.Translate(motion * speed);
        }
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

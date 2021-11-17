using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carScript : ObsticleClass
{
    

    void Start()
    {
        objectSpeed = Random.Range(minSpeed,maxSpeed);
    }


    void FixedUpdate() {
        Vector2 forward = new Vector2(transform.right.x, transform.right.y);
        rb.MovePosition(rb.position + forward * Time.fixedDeltaTime* objectSpeed);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}

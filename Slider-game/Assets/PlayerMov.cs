using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerMov : MonoBehaviour {


    public float fowardForce;
    public float sideForce;
    public float jump;
    public Rigidbody rb;

    void Start()
    {
        //rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        //rb.AddForce(transform.forward * thrust* Time.deltaTime);
        rb.AddForce(0,0,1 * fowardForce * Time.deltaTime);
        //if (Input.GetKey("space"))
          //  rb.AddForce(0, 1 * jump * Time.deltaTime, 0);
        if (Input.GetKey("a"))
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0,ForceMode.VelocityChange);
        if (Input.GetKey("d"))
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);

    }


}

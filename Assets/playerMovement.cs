using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMovement : MonoBehaviour
{

    public Rigidbody rb;

    public float forwardForce=500f;
    public float sidewaysForce=500f;
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0,0,forwardForce*Time.deltaTime);

        if(Input.GetKey("d"))
        {
            rb.AddForce(sidewaysForce*Time.deltaTime,0,0);
        }
        
        if(Input.GetKey("a"))
        {
            rb.AddForce(-sidewaysForce*Time.deltaTime,0,0);
        }
        //if(rb.position.y<-1f)
        //{
          //  FindObjectOfType<GameManager>().EndGame();
        //}

    }
}

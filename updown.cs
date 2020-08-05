
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class updown : MonoBehaviour
{
    public float speed;

    void Update()
    {
        //누르는 동안 hold
        if ( 
               (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.S))
            || (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.D))
            || (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.J))
            || (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.K))
            || (Input.GetKeyDown(KeyCode.A) && Input.GetKeyDown(KeyCode.L))

            || (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.D))
            || (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.J))
            || (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.K))
            || (Input.GetKeyDown(KeyCode.S) && Input.GetKeyDown(KeyCode.L))

            || (Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.J))
            || (Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.K))
            || (Input.GetKeyDown(KeyCode.D) && Input.GetKeyDown(KeyCode.L))

            || (Input.GetKeyDown(KeyCode.J) && Input.GetKeyDown(KeyCode.K))
            || (Input.GetKeyDown(KeyCode.J) && Input.GetKeyDown(KeyCode.L))

            || (Input.GetKeyDown(KeyCode.K) && Input.GetKeyDown(KeyCode.L))
            )
        {
            //   transform.position += Vector3.up;
            transform.position += new Vector3(0, 0.5f, 0);
        }

        
        else
            //    transform.position += Vector3.down;
            transform.position -= new Vector3(0, 0.01f, 0);

    
    }
}

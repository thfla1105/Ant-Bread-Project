using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveAnt : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 vec = new Vector3(
            Input.GetAxis("Vertical"), 
            0,
            0
        );
        transform.Translate(vec);

       // Vector3 target = new Vector3(-13.7f, 22.8f, 6.3f);

      // transform.position = Vector3.MoveTowards(transform.position, target, 1f);
    }
}
 
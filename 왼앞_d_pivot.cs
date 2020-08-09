using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 왼앞_d_pivot : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.D))   //누르는 동안 hold
        {
            transform.localRotation = Quaternion.Euler(-60.3f, 0, -180);
        }
        if (Input.GetKeyUp(KeyCode.D))  //손 떼면 복구
        {
            transform.localRotation = Quaternion.Euler(-90.00001f, 0, -180);



        }
    }
}

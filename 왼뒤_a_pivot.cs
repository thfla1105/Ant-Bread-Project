using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 왼뒤_a_pivot : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))   //누르는 동안 hold
        {
            transform.localRotation = Quaternion.Euler(-76.7f, 0, -180);
        }
        if (Input.GetKeyUp(KeyCode.A))  //손 떼면 복구
        {
            transform.localRotation = Quaternion.Euler(-90.00001f, 0, -180);



        }
    }

}

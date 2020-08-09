using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 왼가_s_pivot : MonoBehaviour
{

    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))   //누르는 동안 hold
        {
            transform.localRotation = Quaternion.Euler(-69f, 0, -180);
        }
        if (Input.GetKeyUp(KeyCode.S))  //손 떼면 복구
        {
            transform.localRotation = Quaternion.Euler(-90.00001f, 0, -180);



        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 오앞_j_pivot : MonoBehaviour
{

    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.J))   //누르는 동안 hold
        {
            transform.localRotation = Quaternion.Euler(-120.1f, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.J))  //손 떼면 복구
        {
            transform.localRotation = Quaternion.Euler(-89.98f, 0, 0);

        }
    }
}

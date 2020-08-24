using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftLeg_S : MonoBehaviour
{
    void Start()
    {
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))   //누르는 동안 hold
        {
            transform.localRotation = Quaternion.Euler(-40f, 15f, -180);
        }
        if (Input.GetKeyUp(KeyCode.S))  //손 떼면 복구
        {
            transform.localRotation = Quaternion.Euler(-90.00001f, 0, -180);
            
        }
    }
}
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightLeg_L : MonoBehaviour
{
    void Start()
    {

    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))   //누르는 동안 hold
        {
            transform.localRotation = Quaternion.Euler(-135f, 15f, 0);

        }
        if (Input.GetKeyUp(KeyCode.L))  //손 떼면 복구
        {

            transform.localRotation = Quaternion.Euler(-89.98f, 0, 0);

        }
    }
}
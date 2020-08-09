using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 오가_k_pivot : MonoBehaviour
{
    public int speed;
    // public int count = 0; //다리 개수 카운트


    void Start()
    {
        speed = 200;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))   //누르는 동안 hold
        {
            transform.localRotation = Quaternion.Euler(-110.6f, 0, 0);
        }
        if (Input.GetKeyUp(KeyCode.K))  //손 떼면 복구
        {
            transform.localRotation = Quaternion.Euler(-89.98f, 0, 0);

        }
    }

}

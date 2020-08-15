using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTg_D : MonoBehaviour
{
    AntMove antmove;

    void Awake()
    {
        antmove = GameObject.Find("ant").GetComponent<AntMove>();
    }
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Bark" || col.tag == "Worm" || col.tag == "Hole" || col.tag == "AntFriend")
        {
            antmove.btn[2, 0] = 0;
        }
    }
    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Bark" || col.tag == "Worm" || col.tag == "Hole" || col.tag == "AntFriend")
        {
            antmove.btn[2, 0] = 0;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Bark" || col.tag == "Worm" || col.tag == "Hole" || col.tag == "AntFriend")
        {
            if (Input.GetKey(KeyCode.D))
            {
                antmove.btn[2, 0] = 1;
            }
        }
    }
}

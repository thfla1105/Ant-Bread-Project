using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleTg_J : MonoBehaviour
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
            antmove.btn[3, 0] = 0;
        }
    }
    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Bark" || col.tag == "Worm" || col.tag == "Hole" || col.tag == "AntFriend")
        {
            antmove.btn[3, 0] = 0;
        }
    }
    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Bark" || col.tag == "Worm" || col.tag == "Hole" || col.tag == "AntFriend")
        {
            if (Input.GetKey(KeyCode.J))
            {
                antmove.btn[3, 0] = 1;
            }
        }
    }
}

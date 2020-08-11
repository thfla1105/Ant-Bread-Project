using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingBar : MonoBehaviour
{
    GameObject Ant;
    GameObject Bread;
    Transform tr;
    public float minPoint = 1.0f;
    void Start()
    {
        Ant = GameObject.Find("ant");
        Bread = GameObject.Find("BreadImage");
        tr = Ant.GetComponent<Transform>();
    }

    void Update()
    {
        //Debug.Log(tr.rotation.x);
        if (tr.eulerAngles.y == 90.0f)
        {
            Bread.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}

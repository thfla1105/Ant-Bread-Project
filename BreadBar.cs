using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadBar : MonoBehaviour
{
    AntMove Antmove;
    GameObject Ant;
    GameObject King;
    Transform tr;
    public float maxPoint = 38.0f;

    void Start()
    {
        Ant = GameObject.Find("ant");
        Antmove = Ant.GetComponent<AntMove>();
        King = GameObject.Find("KingImage");
        tr = Ant.GetComponent<Transform>();
    }

    void Update()
    {
        if (tr.eulerAngles.y == 270.0f)
        {
            King.SetActive(true);
            gameObject.SetActive(false);
        }   
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialMove : MonoBehaviour
{
    GameObject ant;
    Transform tr;
    // Start is called before the first frame update
    void Awake()
    {
        ant = GameObject.Find("ant");
        tr = ant.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        float height = tr.position.y;
        if(height >= -1.0f)
        {
            gameObject.SetActive(false);
        }
    }
}

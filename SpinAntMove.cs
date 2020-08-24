using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinAntMove : MonoBehaviour
{
    GameObject ht;

    float time;
    public float blinkTime = 0.5f;

    void Awake()
    {
        ht = GameObject.Find("SpinAntImage2");
    }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        ht.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (time < blinkTime)
        {
            ht.SetActive(true);
        }
        else
        {
            ht.SetActive(false);
            if (time > blinkTime * 2)
            {
                time = 0.0f;
            }
        }
        time += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.Find("Canvas").GetComponent<PopupLoad>().chkSpin = false;
            GameObject.Find("Canvas").GetComponent<PopupLoad>().chkBread2 = true;
            gameObject.SetActive(false);
            ht.SetActive(false);
        }
    }
}

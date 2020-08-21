using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tu13Move : MonoBehaviour
{
    public GameObject Tutorial13, Tutorial;
    public int tuOrder = 1;

    Tu2Move tu2;
    Tu48Move tu48;

    AntMove antmove;
    int btncnt = 0;

    float time;
    public float blinkTime = 0.5f;

    void Start()
    {
        Tutorial13.SetActive(false);
        antmove = GameObject.Find("ant").GetComponent<AntMove>();
        tu2 = gameObject.GetComponent<Tu2Move>();
        tu48 = gameObject.GetComponent<Tu48Move>();
    }


    void Update()
    {
        if (Tutorial.activeSelf == false)
        {
            Tutorial13.SetActive(false);
        }
        if (Tutorial.activeSelf == true && (tuOrder == 1 || tuOrder == 3))
        {
            if (time < blinkTime)
            {
                Tutorial13.SetActive(true);
            }
            else
            {
                Tutorial13.SetActive(false);
                if (time > blinkTime * 2)
                {
                    time = 0.0f;
                }
            }
            time += Time.deltaTime;

            btncnt = 0;
            for (int i = 0; i < 6; i++)
            {
                if (antmove.btn[i, 0] == 1) btncnt++;
            }
            if (btncnt < 2)
            {
                tuOrder = 1;
            }

            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.K) && tuOrder == 1)
            {
                tuOrder = 2;
                Tutorial13.SetActive(false);
            }

            else if (Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.K) && Input.GetKeyDown(KeyCode.D) && tuOrder == 3)
            {
                tuOrder = 4;
                Tutorial13.SetActive(false);
            }
        }
    }

}

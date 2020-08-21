using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tu2Move : MonoBehaviour
{
    public GameObject Tutorial2, Tutorial;
    Tu13Move tu13;
    Tu48Move tu48;

    AntMove antmove;

    bool check = false;
    int btncnt = 0;

    float time;
    public float blinkTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        Tutorial2.SetActive(false);
        antmove = GameObject.Find("ant").GetComponent<AntMove>();
        tu13 = gameObject.GetComponent<Tu13Move>();
        tu48 = gameObject.GetComponent<Tu48Move>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Tutorial.activeSelf == false)
        {
            Tutorial2.SetActive(false);
        }
        if (Tutorial.activeSelf == true && tu13.tuOrder == 2)
        {
            if (time < blinkTime)
            {
                Tutorial2.SetActive(true);
            }
            else
            {
                Tutorial2.SetActive(false);
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
                tu13.tuOrder = 1;
                Tutorial2.SetActive(false);
            }

            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.K))
            {
                check = true;
            }

            if (check && Input.GetKeyUp(KeyCode.D) && Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.K))
            {
                check = false;
                tu13.tuOrder = 3;
                Tutorial2.SetActive(false);
            }
        }
    }
}

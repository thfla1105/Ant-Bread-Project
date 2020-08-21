using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tu48Move : MonoBehaviour
{
    public GameObject tu48, Tutorial;

    Tu13Move tu13;
    AntMove antmove;
    bool check = false;
    int btncnt = 0;

    float time;
    public float blinkTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        tu48.SetActive(false);
        antmove = GameObject.Find("ant").GetComponent<AntMove>();
        tu13 = gameObject.GetComponent<Tu13Move>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Tutorial.activeSelf == false)
        {
            tu48.SetActive(false);
        }
        if (Tutorial.activeSelf == true && (tu13.tuOrder == 4 || tu13.tuOrder == 8))
        {
            if (time < blinkTime)
            {
                tu48.SetActive(true);
            }
            else
            {
                tu48.SetActive(false);
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
                if (tu13.tuOrder == 4)
                {
                    tu13.tuOrder = 1;
                    tu48.SetActive(false);
                }
                else
                {
                    tu13.tuOrder = 5;
                    tu48.SetActive(false);
                }
            }

            if (Input.GetKey(KeyCode.K) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.J))
            {
                check = true;
            }

            else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.A))
            {
                check = true;
            }

            if (check && Input.GetKeyUp(KeyCode.K) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.J))
            {
                tu13.tuOrder = 5;
                check = false;
                tu48.SetActive(false);
            }

            else if (check && Input.GetKeyUp(KeyCode.A) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.J))
            {
                tu13.tuOrder = 9;
                check = false;
                tu48.SetActive(false);
            }
        }

    }
}
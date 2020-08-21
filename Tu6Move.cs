using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tu6Move : MonoBehaviour
{
    public GameObject Tutorial6, Tutorial;

    bool check = false;
    AntMove antmove;
    Tu13Move tu13;
    int btncnt = 0;

    float time;
    public float blinkTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        Tutorial6.SetActive(false);
        antmove = GameObject.Find("ant").GetComponent<AntMove>();
        tu13 = gameObject.GetComponent<Tu13Move>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Tutorial.activeSelf == false)
        {
            Tutorial6.SetActive(false);
        }
        if (Tutorial.activeSelf == true && tu13.tuOrder == 6)
        {
            if (time < blinkTime)
            {
                Tutorial6.SetActive(true);
            }
            else
            {
                Tutorial6.SetActive(false);
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
                tu13.tuOrder = 5;
                Tutorial6.SetActive(false);
            }
            
            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.A))
            {
                check = true;
            }

            if (check && Input.GetKeyUp(KeyCode.J) && Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.A))
            {
                check = false;
                tu13.tuOrder = 7;
                Tutorial6.SetActive(false);
            }
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tu57Move : MonoBehaviour
{
    public GameObject Tutorial57, Tutorial;

    AntMove antmove;
    Tu13Move tu13;
    int btncnt = 0;

    float time;
    public float blinkTime = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        Tutorial57.SetActive(false);
        antmove = GameObject.Find("ant").GetComponent<AntMove>();
        tu13 = gameObject.GetComponent<Tu13Move>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Tutorial.activeSelf == false)
        {
            Tutorial57.SetActive(false);
        }
        if (Tutorial.activeSelf == true && (tu13.tuOrder == 5 || tu13.tuOrder == 7))
        {
            if (time < blinkTime)
            {
                Tutorial57.SetActive(true);
            }
            else
            {
                Tutorial57.SetActive(false);
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
            }

            if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.J) && Input.GetKey(KeyCode.A) && tu13.tuOrder == 5)
            {
                tu13.tuOrder = 6;
                Tutorial57.SetActive(false);
            }

            else if (Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.A) && Input.GetKeyDown(KeyCode.J) && tu13.tuOrder == 7)
            {
                tu13.tuOrder = 8;
                Tutorial57.SetActive(false);
            }
        }
    }
}

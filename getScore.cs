using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getScore : MonoBehaviour
{

    public static int isAntUpSideDown = 0;     //뒤집어질때 사용할 변수 

    public int finalBread = 0;     //breadCount 에서 true 개수 count할 변수

    public bool goalCollide; //땅바닥에 충돌했는지 확인하는 변수

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Goal")
        {
            Debug.Log("개미가 골대에 닿음");
            goalCollide = true;
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Goal")
        {
            Debug.Log("개미가 골대에서 떨어짐!");
            goalCollide = false;
        }

    }

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && goalCollide)   //누르는 동안 hold
        {
            for (int i = 0; i < 4; i++)
            {
                if (GameObject.Find("ant").GetComponent<Player>().breadCount[i] == true)
                {
                    finalBread++;
                }
            }
            score.scoreValue += finalBread;


            if (isAntUpSideDown % 2 == 0)
            //개미가 정방향일때 
            {
                transform.eulerAngles = new Vector3(0.0f, 270.0f, 270.0f);
                isAntUpSideDown++;
            }
            else
            //개미가 역방향일때 
            {
                transform.eulerAngles = new Vector3(0.0f, 90.0f, 90.0f);
                isAntUpSideDown++;
            }

            



        }

    }
}
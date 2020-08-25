using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getScore : MonoBehaviour
{
    Player player;

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
        player = GameObject.Find("ant").GetComponent<Player>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && goalCollide && isAntUpSideDown % 2 == 1)   //누르는 동안 hold //바닥에 닿았을 때 //개미가 역방향일 때 -> 정방향
        {
            GameObject.Find("Canvas").GetComponent<PopupLoad>().chkSpace = false;

            Player.isParent_A = false;
            Player.isParent_S = false;
            Player.isParent_K = false;
            Player.isParent_L = false;

            transform.eulerAngles = new Vector3(0.0f, 90.0f, 90.0f);
            isAntUpSideDown++;

            finalBread = 0;

            for (int i = 0; i < 4; i++)
            {
                if (GameObject.Find("ant").GetComponent<Player>().breadCount[i] == true)
                {
                    finalBread++;
                    GameObject.Find("ant").GetComponent<Player>().breadCount[i] = false;
                }
            }
            score.scoreValue += finalBread;
            SoundManager.PlaySound("pointsound");

        }

        else if (Input.GetKeyDown(KeyCode.Space) && player.isPlayerEnter && isAntUpSideDown % 2 == 0) //식빵 닿았을 때 //개미가 정방향일 때 -> 역방향
        {
            transform.eulerAngles = new Vector3(0.0f, 270.0f, 270.0f);
            transform.position = new Vector3(transform.position.x, 37.99f, transform.position.z);
            isAntUpSideDown++;
        }

    }
}
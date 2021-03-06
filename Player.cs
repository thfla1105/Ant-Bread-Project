﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    Transform tr_A;
    Transform tr_S;
    Transform tr_K;
    Transform tr_L;

    AntMove antmove;

    public GameObject prefabBread;
    public bool isPlayerEnter;       //개미랑 빵이 충돌했는지 확인하는 변수
    private float inputLate = 0.03f;

    public static bool start = false;

    public bool[] breadCount = new bool[4];

    public static bool isParent_A = false;
    public static bool isParent_S = false;
    public static bool isParent_K = false;
    public static bool isParent_L = false;


    Vector3 pos;

    Vector3 vec; //식빵의 로컬위치

    void Awake()
    {
        antmove = GameObject.Find("ant").GetComponent<AntMove>();
        pos = antmove.transform.position;
    }
    void Start()
    {
        tr_A = GameObject.FindGameObjectWithTag("EquipPoint_A").GetComponent<Transform>();
        tr_S = GameObject.FindGameObjectWithTag("EquipPoint_S").GetComponent<Transform>();
        tr_K = GameObject.FindGameObjectWithTag("EquipPoint_K").GetComponent<Transform>();
        tr_L = GameObject.FindGameObjectWithTag("EquipPoint_L").GetComponent<Transform>();


    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(KeyDown_A());
        StartCoroutine(KeyDown_S());
        StartCoroutine(KeyDown_K());
        StartCoroutine(KeyDown_L());

    }




    private IEnumerator KeyDown_A()
    {

        float y = this.inputLate;

        while (y > 0)
        {
            //A키 눌리고 && 식빵이랑 충돌했고 && 개미가 정방향일때
            if (Input.GetKeyDown(KeyCode.A) && isPlayerEnter && (getScore.isAntUpSideDown % 2 == 0))

            //if (Input.GetKeyDown(KeyCode.A) && isPlayerEnter && pos.y==90 )
            {
                tr_A.localRotation = Quaternion.Euler(-90.00001f, 0, -180);
                GameObject.FindGameObjectWithTag("EquipPoint_A").GetComponent<LeftLeg_A>().enabled = false;

                isParent_A = true;
                start = true;
                vec = new Vector3(tr_A.position.x + 0.8f, tr_A.position.y, tr_A.position.z - 0.05f);


                Instantiate(prefabBread, vec, Quaternion.identity); //빵생성
                SoundManager.PlaySound("pickupsound");


                breadCount[0] = true;
            }

            if (Input.GetKeyUp(KeyCode.A))
            {
                isParent_A = false;
                GameObject.FindGameObjectWithTag("EquipPoint_A").GetComponent<LeftLeg_A>().enabled = true;
                breadCount[0] = false;

            }

            if (isParent_A)
            {
                antmove.btn[0, 0] = 0;
            }

            y -= Time.deltaTime;
            yield return null;
        }
        yield return null;
    }

    private IEnumerator KeyDown_S()
    {

        float y = this.inputLate;

        while (y > 0)
        {
            if (Input.GetKeyDown(KeyCode.S) && isPlayerEnter && (getScore.isAntUpSideDown % 2 == 0))
            {
                tr_S.localRotation = Quaternion.Euler(-90.00001f, 0, -180);
                GameObject.FindGameObjectWithTag("EquipPoint_S").GetComponent<LeftLeg_S>().enabled = false;

                isParent_S = true;
                start = true;
                vec = new Vector3(tr_S.position.x + 0.8f, tr_S.position.y, tr_S.position.z - 0.05f);

                Instantiate(prefabBread, vec, Quaternion.identity);
                breadCount[1] = true;

                SoundManager.PlaySound("pickupsound");
            }

            if (Input.GetKeyUp(KeyCode.S))
            {
                isParent_S = false;
                GameObject.FindGameObjectWithTag("EquipPoint_S").GetComponent<LeftLeg_S>().enabled = true;
                breadCount[1] = false;

            }
            if (isParent_S)
            {
                antmove.btn[1, 0] = 0;
            }


            y -= Time.deltaTime;
            yield return null;
        }
        yield return null;
    }
    private IEnumerator KeyDown_K()
    {


        float y = this.inputLate;

        while (y > 0)
        {
            if (Input.GetKeyDown(KeyCode.K) && isPlayerEnter && (getScore.isAntUpSideDown % 2 == 0))
            {
                isParent_K = true;
                start = true;
                vec = new Vector3(tr_K.position.x - 0.8f, tr_K.position.y, tr_K.position.z - 0.05f);
                GameObject.FindGameObjectWithTag("EquipPoint_K").GetComponent<RightLeg_K>().enabled = false;
                tr_K.localRotation = Quaternion.Euler(-89.98f, 0, 0);

                Instantiate(prefabBread, vec, Quaternion.identity);

                breadCount[2] = true;

                SoundManager.PlaySound("pickupsound");
            }

            if (Input.GetKeyUp(KeyCode.K))
            {
                isParent_K = false;
                GameObject.FindGameObjectWithTag("EquipPoint_K").GetComponent<RightLeg_K>().enabled = true;
                breadCount[2] = false;

            }
            if (isParent_K)
            {
                antmove.btn[4, 0] = 0;
            }


            y -= Time.deltaTime;
            yield return null;
        }
        yield return null;
    }
    private IEnumerator KeyDown_L()
    {


        float y = this.inputLate;

        while (y > 0)
        {
            if (Input.GetKeyDown(KeyCode.L) && isPlayerEnter && (getScore.isAntUpSideDown % 2 == 0))
            {
                isParent_L = true;
                start = true;
                vec = new Vector3(tr_L.position.x - 0.8f, tr_L.position.y, tr_L.position.z - 0.05f);
                GameObject.FindGameObjectWithTag("EquipPoint_L").GetComponent<RightLeg_L>().enabled = false;
                tr_L.localRotation = Quaternion.Euler(-89.98f, 0, 0);

                Instantiate(prefabBread, vec, Quaternion.identity);
                breadCount[3] = true;

                SoundManager.PlaySound("pickupsound");

            }

            if (Input.GetKeyUp(KeyCode.L))
            {
                isParent_L = false;
                GameObject.FindGameObjectWithTag("EquipPoint_L").GetComponent<RightLeg_L>().enabled = true;
                breadCount[3] = false;

            }
            if (isParent_L)
            {
                antmove.btn[5, 0] = 0;
            }

            y -= Time.deltaTime;
            yield return null;
        }
        yield return null;
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Bread")
        {
            Debug.Log("개미가 빵에 닿음");
            isPlayerEnter = true;
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "Bread")
        {
            Debug.Log("개미가 빵에서 떨어짐!");
            isPlayerEnter = false;
        }

    }
}
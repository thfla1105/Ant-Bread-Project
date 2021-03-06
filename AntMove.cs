﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class AntMove : MonoBehaviour
{
    GameObject LeftLeg;  //앞다리 오브젝트 호출
    GameObject RightLeg;


    private Coroutine inputForwardRout;

    private float inputLate = 0.01f;


    public int[,] btn = new int[6, 2];
    public int pre_move = 0;


    [Header("Speed")]
    public float speedMovement = 0.5f;
    public float speedRotation = 30f;
    public float speedAnimation = 3f;

    float verticalAxis;
    float horizontalAxis;
    float rotationalAxis;

    public float startPoint = -7.0f;
    public int chk = 0;
    void OnTriggerEnter(Collider col)
    {
        if (col.tag == "Bread")
        {
            chk = 1;
            GameObject.Find("GameManager").GetComponent<ObstacleCreate>().chkObs = true;
        }
    }

    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Bread")
        {
            chk = 1;
        }
    }

    void OnTriggerExit(Collider col)
    {
        if (col.tag == "Bread")
        {
            chk = 0;
        }
    }


    void Awake()
    {
        LeftLeg = GameObject.Find("L1.001");  //앞다리 오브젝트 호출
        RightLeg = GameObject.Find("R1.001");

    }


    void Update()
    {

        StartCoroutine(this.BtnState());

        StartCoroutine(this.Forward());
        StartCoroutine(this.FallDown());



    }


    private IEnumerator BtnState()
    {

        float t = this.inputLate;

        while (t > 0)
        {

            if (Input.GetKeyDown(KeyCode.A))
            {
                btn[0, 0] = 1;
                string array = "";
                for (int i = 0; i < 6; i++)
                {
                    array += btn[i, 0].ToString();
                }
                Debug.Log(array);
            }


            if (Input.GetKeyDown(KeyCode.S))
            {
                btn[1, 0] = 1;
                string array = "";
                for (int i = 0; i < 6; i++)
                {
                    array += btn[i, 0].ToString();
                }
                Debug.Log(array);
            }


            if (Input.GetKeyDown(KeyCode.D))
            {
                btn[2, 0] = 1;
                string array = "";
                for (int i = 0; i < 6; i++)
                {
                    array += btn[i, 0].ToString();
                }
                Debug.Log(array);
            }



            if (Input.GetKeyDown(KeyCode.J))
            {
                btn[3, 0] = 1;
                string array = "";
                for (int i = 0; i < 6; i++)
                {
                    array += btn[i, 0].ToString();
                }
                Debug.Log(array);
            }



            if (Input.GetKeyDown(KeyCode.K))
            {
                btn[4, 0] = 1;
                string array = "";
                for (int i = 0; i < 6; i++)
                {
                    array += btn[i, 0].ToString();
                }
                Debug.Log(array);
            }

            if (Input.GetKeyDown(KeyCode.L))
            {
                btn[5, 0] = 1;
                string array = "";
                for (int i = 0; i < 6; i++)
                {
                    array += btn[i, 0].ToString();
                }
                Debug.Log(array);
            }

            t -= Time.deltaTime;
            yield return null;
        }



        float p = this.inputLate;

        while (p > 0)
        {


            if (Input.GetKeyUp(KeyCode.A))
            {
                btn[0, 0] = 0;
                string array = "";
                for (int i = 0; i < 6; i++)
                {
                    array += btn[i, 0].ToString();
                }
                Debug.Log(array);

            }

            if (Input.GetKeyUp(KeyCode.S))
            {
                btn[1, 0] = 0;
                string array = "";
                for (int i = 0; i < 6; i++)
                {
                    array += btn[i, 0].ToString();
                }
                Debug.Log(array);
            }

            if (Input.GetKeyUp(KeyCode.D))
            {
                LeftLeg.transform.localScale = new Vector3(2.5f, 60, 2.5f);    //!!!!!!!!!!!!!!!!!!!
                btn[2, 0] = 0;
                string array = "";
                for (int i = 0; i < 6; i++)
                {
                    array += btn[i, 0].ToString();
                }
                Debug.Log(array);
            }

            if (Input.GetKeyUp(KeyCode.J))
            {
                RightLeg.transform.localScale = new Vector3(2.5f, 60, 2.5f);   //!!!!!!!!!!!!!!!!!!!
                btn[3, 0] = 0;
                string array = "";
                for (int i = 0; i < 6; i++)
                {
                    array += btn[i, 0].ToString();
                }
                Debug.Log(array);
            }

            if (Input.GetKeyUp(KeyCode.K))
            {
                btn[4, 0] = 0;
                string array = "";
                for (int i = 0; i < 6; i++)
                {
                    array += btn[i, 0].ToString();
                }
                Debug.Log(array);
            }

            if (Input.GetKeyUp(KeyCode.L))
            {
                btn[5, 0] = 0;
                string array = "";
                for (int i = 0; i < 6; i++)
                {
                    array += btn[i, 0].ToString();
                }
                Debug.Log(array);
            }

            p -= Time.deltaTime;
            yield return null;

        }


        yield return null;

    }


    private IEnumerator Forward()
    {
        while (true)
        {
            if (btn[2, 0] == 1 && btn[3, 0] == 1)
            {
                if (btn[0, 0] == 1 && btn[0, 1] == 0)
                {
                    if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.J))
                    {
                        btn[0, 1] = 1;
                        Debug.Log("A: " + btn[0, 1]);
                    }
                }
                if (btn[1, 0] == 1 && btn[1, 1] == 0)
                {
                    if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.J))
                    {
                        btn[1, 1] = 1;
                        Debug.Log("S: " + btn[1, 1]);
                    }
                }
                if (btn[4, 0] == 1 && btn[4, 1] == 0)
                {
                    if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.J))
                    {
                        btn[4, 1] = 1;
                        Debug.Log("K: " + btn[4, 1]);
                    }
                }
                if (btn[5, 0] == 1 && btn[5, 1] == 0)
                {
                    if (Input.GetKeyUp(KeyCode.D) || Input.GetKeyUp(KeyCode.J))
                    {
                        btn[5, 1] = 1;
                        Debug.Log("L: " + btn[5, 1]);
                    }
                }
                ///////////////d,j+다른 버튼 키 처음 눌렀을 때 ///////////////
                if (inputForwardRout == null)
                {
                    this.inputForwardRout = StartCoroutine(this.Forward_act());

                }
                //////////////moveforward////////////////////////

            }


            //d>j일때 j
            if ((btn[2, 0] == 1 && btn[2, 1] >= btn[3, 1]) && (btn[0, 1] == 1 || btn[1, 1] == 1 || btn[4, 1] == 1 || btn[5, 1] == 1))
            {
                if (Input.GetKeyDown(KeyCode.J))
                {
                    btn[3, 1] = 2;
                    btn[2, 1] = 0;
                    Debug.Log("j->" + btn[3, 1]);
                    RightLeg.transform.localScale = new Vector3(4.0f, 60, 2.5f);   //!!!!!!!!!!!!!!!!!!!
                    LeftLeg.transform.localScale = new Vector3(2.5f, 60, 2.5f);    //!!!!!!!!!!!!!!!!!!!

                }

            }

            //j>d일때 d
            if ((btn[3, 0] == 1 && btn[2, 1] <= btn[3, 1]) && (btn[0, 1] == 1 || btn[1, 1] == 1 || btn[4, 1] == 1 || btn[5, 1] == 1))
            {
                if (Input.GetKeyDown(KeyCode.D))
                {
                    btn[2, 1] = 2;
                    btn[3, 1] = 0;
                    Debug.Log("d->" + btn[2, 1]);
                    RightLeg.transform.localScale = new Vector3(2.5f, 60, 2.5f);   //!!!!!!!!!!!!!!!!!!!
                    LeftLeg.transform.localScale = new Vector3(4.0f, 60, 2.5f);     //!!!!!!!!!!!!!!!!!!!

                }


            }
            yield return null;
        }

    }

    private IEnumerator Forward_act()
    {
        //float o = this.inputLate;
        float o = 0.0001f;
        bool h = false;
        int backleg = 0;
        while (o > 0)
        {

            if (btn[0, 1] == 1)
            {

                if (Input.GetKeyUp(KeyCode.A))
                {
                    h = true;
                    btn[0, 1] = 0;

                }
            }
            if (btn[1, 1] == 1)
            {

                if (Input.GetKeyUp(KeyCode.S))
                {
                    h = true;
                    btn[1, 1] = 0;

                }
            }
            if (btn[4, 1] == 1)
            {

                if (Input.GetKeyUp(KeyCode.K))
                {
                    h = true;
                    btn[4, 1] = 0;

                }
            }
            if (btn[5, 1] == 1)
            {

                if (Input.GetKeyUp(KeyCode.L))
                {
                    h = true;
                    btn[5, 1] = 0;

                }
            }
            int[] back = new int[4] { 0, 1, 4, 5 };

            foreach (int i in back)
            {
                if (btn[i, 0] == 1)
                {
                    backleg++;
                }
            }
            o -= Time.deltaTime;
            yield return null;
        }
        if (h == true && backleg == 0)
        {
            if (pre_move != (btn[2, 1] - btn[3, 1]) && transform.position.y <= 38)
            {

                if ((btn[2, 0] == 1 && btn[3, 0] == 1) && (btn[2, 1] - btn[3, 1] > 0))
                {
                    RightLeg.transform.localScale = new Vector3(1.5f, 60, 2.5f);   //!!!!!!!!!!!!!!!!!!!
                    LeftLeg.transform.localScale = new Vector3(3.0f, 60, 2.5f);    //!!!!!!!!!!!!!!!!!!!
                }
                else if ((btn[2, 0] == 1 && btn[3, 0] == 1) && (btn[2, 1] - btn[3, 1] < 0))
                {
                    RightLeg.transform.localScale = new Vector3(3.0f, 60, 2.5f);   //!!!!!!!!!!!!!!!!!!!
                    LeftLeg.transform.localScale = new Vector3(1.5f, 60, 2.5f);    //!!!!!!!!!!!!!!!!!!!
                }



                Debug.Log("forward!!" + pre_move);
                horizontalAxis = 5f;
                transform.position += (transform.forward * verticalAxis + transform.right * horizontalAxis) * Time.deltaTime * speedMovement;
                pre_move = btn[2, 1] - btn[3, 1];


            }

        }
        else if (transform.position.y > 38)
        {
            Debug.Log("Cant move!");
        }
        else
        {
            horizontalAxis = 0f;
            transform.position += (transform.forward * verticalAxis + transform.right * horizontalAxis) * Time.deltaTime * speedMovement;
        }

        this.inputForwardRout = null;

    }


    bool telCheck = false;

    private IEnumerator FallDown()
    {
        float w = 0.0001f;

        float checkTime = 0.5f;

        int num = 0;

        while (w > 0)
        {

            for (int i = 0; i < 6; i++)
            {

                if (btn[i, 0] == 1) //버튼이 눌러져있을 때 && 식빵을 자식으로 갖고 있지 않을때
                {
                    num++;  //num에 하나씩 더하기
                    Debug.Log("num:" + num);
                }

            }


            w -= Time.deltaTime;
            yield return null;
        }

        //눌러진 버튼이 두개보다 적을때
        //다리가 두개 미만 붙어있을때
        if (transform.position.y > startPoint && num < 2 && !telCheck)
        {
            RightLeg.transform.localScale = new Vector3(2.5f, 60, 2.5f);   //!!!!!!!!!!!!!!!!!!!
            LeftLeg.transform.localScale = new Vector3(2.5f, 60, 2.5f);    //!!!!!!!!!!!!!!!!!!!

            Debug.Log("falling down");

            SoundManager.PlaySound("falling");

            btn[2, 1] = 0; //D키가 뻗어져있는걸로 변경
            btn[3, 1] = 0; //J키가 뻗어져있는걸로 변경
            pre_move = 0;
            float time = 1f;
            float timeSpan = 0.0f;

            if (getScore.isAntUpSideDown % 2 == 0)
            {
                while (time > 0)
                {
                    horizontalAxis = -0.05f;
                    transform.position += (transform.forward * verticalAxis + transform.right * horizontalAxis) * Time.deltaTime * speedMovement;
                    time -= Time.deltaTime;

                    SoundManager.PlaySound("falling");

                }
            }


            else if (getScore.isAntUpSideDown % 2 == 1) //역방향일때 
            {

                timeSpan += Time.deltaTime;
                while (timeSpan > 0)
                {
                    timeSpan += Time.deltaTime;
                    horizontalAxis = +0.05f;
                    transform.position += (transform.forward * verticalAxis + transform.right * horizontalAxis) * Time.deltaTime * speedMovement;

                    if (timeSpan > checkTime)
                    {
                        Player.isParent_A = false;
                        Player.isParent_S = false;
                        Player.isParent_K = false;
                        Player.isParent_L = false;

                        Invoke("teleport", 0.5f); //0.5
                        break;
                    }


                }
            }


            for (int i = 0; i < 6; i++)
            {
                btn[i, 1] = 0;
            }
        }

        else if (num >= 2)  //btn[2, 1] == 0 && btn[3, 1] == 0)
        {
            telCheck = false;
            horizontalAxis = 0f;
            transform.position += (transform.forward * verticalAxis + transform.right * horizontalAxis) * Time.deltaTime * speedMovement;
        }

        else if (num < 2 && telCheck)
        {
            Invoke("stop4moment", 0.8f); //1f
            for (int i = 0; i < 6; i++)
            {
                btn[i, 0] = 0;
            }
            telCheck = false;
            getScore.isAntUpSideDown = 0;
        }

        if (transform.position.y < startPoint) //
        {
            transform.position = new Vector3((float)-11.95, startPoint, (float)5.24); //
            btn[2, 1] = 0;
            btn[3, 1] = 0;
            pre_move = 0;

        }


        yield return null;
    }



    void teleport()
    {
        Debug.Log("식빵위치로 텔레포트");
        transform.eulerAngles = new Vector3(0.0f, 90.0f, 90.0f); //개미정방향으로  
        transform.position = new Vector3(-11.95f, 36.00f, 5.24f);



        telCheck = true;

        getScore.isAntUpSideDown = 0;


    }
    void stop4moment()
    {
        for (int i = 2; i < 4; i++)
        {
            btn[i, 0] = 1;

        }
    }

}
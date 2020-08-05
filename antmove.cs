using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class antmove : MonoBehaviour
{

    private Coroutine inputKeyRoutine;
    private Coroutine inputBtnRoutine;
    private Coroutine inputForwardRout;
    private Coroutine inputBackwardRout;
    private float inputLate = 0.03f;

    int[,] btn = new int[6, 2];
    int pre_move = 0;

   
    [Header("Speed")]
    public float speedMovement = 0.3f;
    public float speedRotation = 30f;
    public float speedAnimation = 3f;


    [Header("Inverse Kinematics")]
    public bool isIKEnabled = true;
    public float IKFactor = 20f;
    float IKAngle = 0f;

    float verticalAxis;
    float horizontalAxis;
    float rotationalAxis;

    Rigidbody rigidbody3D;



    void Awake()
    {

        rigidbody3D = GetComponent<Rigidbody>();


    }


    void Update()
    {
        //StartCoroutine(this.StartButton());
        StartCoroutine(this.BtnState());
        StartCoroutine(this.Forward());
        StartCoroutine(this.FallDown());
        AxesUpdate();
        

    }

    void AxesUpdate()
    {
        // verticalAxis = Input.GetAxis("Horizontal");
        // horizontalAxis = Input.GetAxis("Vertical");

        

        if (Input.GetKey(KeyCode.Q))
        {
            rotationalAxis = -1f;
        }
        else if (Input.GetKey(KeyCode.E))
        {
            rotationalAxis = 1f;
        }
        else
        {
            rotationalAxis = 0f;
        }

        transform.position += (transform.forward * verticalAxis + transform.right * horizontalAxis) * Time.deltaTime * speedMovement;
        transform.rotation *= Quaternion.Euler(Vector3.up * rotationalAxis * Time.deltaTime * speedRotation);
    }


   

    private IEnumerator BtnState()
    {

        float t = this.inputLate;

        while (t > 0)
        {

            if (Input.GetKey(KeyCode.A))
            {
                btn[0, 0] = 1;
                string array = "";
                for (int i = 0; i < 6; i++)
                {
                    array += btn[i, 0].ToString();
                }
                Debug.Log(array);
            }


            if (Input.GetKey(KeyCode.S))
            {
                btn[1, 0] = 1;
                string array = "";
                for (int i = 0; i < 6; i++)
                {
                    array += btn[i, 0].ToString();
                }
                Debug.Log(array);
            }


            if (Input.GetKey(KeyCode.D))
            {
                btn[2, 0] = 1;
                string array = "";
                for (int i = 0; i < 6; i++)
                {
                    array += btn[i, 0].ToString();
                }
                Debug.Log(array);
            }



            if (Input.GetKey(KeyCode.J))
            {
                btn[3, 0] = 1;
                string array = "";
                for (int i = 0; i < 6; i++)
                {
                    array += btn[i, 0].ToString();
                }
                Debug.Log(array);
            }



            if (Input.GetKey(KeyCode.K))
            {
                btn[4, 0] = 1;
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
            if (Input.GetKey(KeyCode.L))
            {
                btn[5, 0] = 1;
                string array = "";
                for (int i = 0; i < 6; i++)
                {
                    array += btn[i, 0].ToString();
                }
                Debug.Log(array);
            }


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


        this.inputBtnRoutine = null;

    }


    private IEnumerator Forward()
    {
        while (true) {
            if (this.inputBackwardRout == null)
            {
                this.inputBackwardRout = StartCoroutine(this.FallDown());
            }

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
                    btn[3, 1] = btn[2, 1] + 2;
                    Debug.Log("j->" + btn[3, 1]);
                }
            }

            //j<d일때 d
            if ((btn[3, 0] == 1 && btn[2, 1] <= btn[3, 1]) && (btn[0, 1] == 1 || btn[1, 1] == 1 || btn[4, 1] == 1 || btn[5, 1] == 1))
            {
                if (Input.GetKeyDown(KeyCode.D))
                {
                    btn[2, 1] = btn[3, 1] + 2;
                    Debug.Log("d->" + btn[2, 1]);
                    
                }
            }
            yield return null;
        }
        

        }
    
    private IEnumerator Forward_act()
    {
        float o = this.inputLate;
        bool h = false;
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
            o -= Time.deltaTime;
            yield return null;
        }
        if (h == true)
        {
            if (pre_move != (btn[2, 1] - btn[3, 1]))
            {
                Debug.Log("forward!!"+pre_move);
                horizontalAxis =10f;
                transform.position += (transform.forward * verticalAxis + transform.right * horizontalAxis) * Time.deltaTime * speedMovement;
                pre_move = btn[2, 1] - btn[3, 1];
                
            }
        }
        else
        {
            horizontalAxis = 0f;
            transform.position += (transform.forward * verticalAxis + transform.right * horizontalAxis) * Time.deltaTime * speedMovement;
        }
    
        this.inputForwardRout = null;

    }

  

    private IEnumerator FallDown()
    {
        float w = this.inputLate;
        
        int num = 0;

        while (w > 0)
        {
            
                for (int i = 0; i < 6; i++)
                {
                    if (btn[i, 0] == 1)
                    {
                        num++;
                    }
                }

            
            w -= Time.deltaTime;
            yield return null;
        }

        if ((btn[2, 1] != 0 || btn[3, 1] != 0)&&num < 2)
        {
            Debug.Log("falling down");
            float time = 3f;
            while (time > 0)
            {
                horizontalAxis = -1f;
                transform.position += (transform.forward * verticalAxis + transform.right * horizontalAxis) * Time.deltaTime * speedMovement;
                time -= Time.deltaTime;
            }
            btn[2, 1] = 0;
            btn[3, 1] = 0;

            
        }
        else if(btn[2, 1] == 0 && btn[3, 1] == 0)
        {
            horizontalAxis = 0f;
            transform.position += (transform.forward * verticalAxis + transform.right * horizontalAxis) * Time.deltaTime * speedMovement;
        }

        this.inputBackwardRout = null;

    }



    

}
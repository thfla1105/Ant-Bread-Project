using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftLeg_D : MonoBehaviour
{
    AntMove move;

    void start()
    {

    }
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.D))
        {
            transform.localRotation = Quaternion.Euler(-24.5f, -13f, -180);

        }

        if (Input.GetKeyUp(KeyCode.D))  //손 떼면 복구
        {
            transform.localRotation = Quaternion.Euler(-90.00001f, 0, -180);


        }
        

    }
    

} 

/*
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeftLeg_D : MonoBehaviour
{
    AntMove move;
    private float inputLate = 0.00001f;

    void start()
    {

    }
    void Update()
    {
        move = GameObject.Find("ant").GetComponent<AntMove>();
       
        StartCoroutine(Leftupdown());

        StartCoroutine(leftleg());

    }


    private IEnumerator leftleg()
    {
        move = GameObject.Find("ant").GetComponent<AntMove>();

        float z = this.inputLate;
        while (z > 0)
        {
            if ((move.btn[2, 0] == 1 && move.pre_move >= 0) && (move.btn[0, 1] == 1 || move.btn[1, 1] == 1 || move.btn[4, 1] == 1 || move.btn[5, 1] == 1))
            {
                if (Input.GetKeyDown(KeyCode.J))
                {
                    transform.localScale = new Vector3(2.5f, 60, 2.5f);
                }
            }

            else if ((move.btn[3, 0] == 1 && move.pre_move <= 0) && (move.btn[0, 1] == 1 || move.btn[1, 1] == 1 || move.btn[4, 1] == 1 || move.btn[5, 1] == 1))
            {
                if (Input.GetKeyDown(KeyCode.D))
                {

                    transform.localScale = new Vector3(4.0f, 60, 2.5f);
                }
            }
            else if (move.pre_move == 0)
            {
                transform.localScale = new Vector3(2.5f, 60, 2.5f);
            }
            else
            {
                transform.localScale = new Vector3(2.5f, 60, 2.5f);
            }



            z -= Time.deltaTime;
            yield return null;
        }

    }

    private IEnumerator Leftupdown()
    {
        float e = this.inputLate;
        while (e > 0)
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                transform.localRotation = Quaternion.Euler(-60.3f, 0, -180);

            }

            if (Input.GetKeyUp(KeyCode.D))  //손 떼면 복구
            {
                transform.localRotation = Quaternion.Euler(-90.00001f, 0, -180);
                //transform.localScale = new Vector3(2.5f, 60, 2.5f);

            }
            e -= Time.deltaTime;
            yield return null;
        }
    }

}
*/
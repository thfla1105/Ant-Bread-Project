using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 왼뒤_a : MonoBehaviour
{

    public int speed;

    void Start()
    {
        speed = 200;
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))   //누르는 동안 hold
        {
            // 단순히 위로 이동하는 것 ... 잘 작동됨 !
            // transform.position += Vector3.up;

            // 회전하는 것.... 잘 작동됨!
            //   transform.Rotate(Vector3.up * speed * Time.deltaTime);
            transform.localScale += new Vector3(50, 25, 25);

        }
        if (Input.GetKeyUp(KeyCode.A))  //손 떼면 복구
        {
            // 회전하는 것.... 잘 작동됨!
            // transform.Rotate(Vector3.down * speed * Time.deltaTime);
            transform.localScale -= new Vector3(50, 25, 25);


        }
    }

}

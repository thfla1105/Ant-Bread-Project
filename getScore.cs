using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getScore : MonoBehaviour
{
    //식빵 잡으면 true로 바뀌도록
    //왼앞 왼가 왼뒤 오앞 오가 오뒤
    public bool[] breadBool = new[] { false, false, false, false, false, false };

    //뒤집어질때 사용할 변수 
    public static int isAntUpSideDown = 0 ;

    //breadBool 에서 true 개수 count할 변수
    int breadCount = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))   //누르는 동안 hold
        {

            for (int i = 0; i < 6; i++)
            {
                if (breadBool[i] == true)
                    breadCount++;
            }

            //스페이스바 누르면 개미뒤집힘
            // transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);

            if(isAntUpSideDown %2 == 0)
                //개미가 정방향일때 
            {
                transform.eulerAngles = new Vector3 (0.0f, 270.0f, 270.0f);
                isAntUpSideDown++;
            }
            else 
            //개미가 역방향일때 
            {
                transform.eulerAngles = new Vector3(0.0f, 90.0f, 90.0f);
                isAntUpSideDown++;
            }

            score.scoreValue += breadCount;

           

        }

    }
}

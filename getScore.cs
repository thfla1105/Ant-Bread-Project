using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getScore : MonoBehaviour
{
    //식빵 잡으면 true로 바뀌도록
    //왼앞 왼가 왼뒤 오앞 오가 오뒤
    public bool[] breadBool = new[] { false, false, false, false, false, false };

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

            for(int i = 0; i < 6; i++)
            {
                if (breadBool[i] == true)
                    breadCount++;
            }
            transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);
            score.scoreValue+=breadCount;



        }

    }
}

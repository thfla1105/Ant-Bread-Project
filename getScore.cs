using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getScore : MonoBehaviour
{
    //식빵 잡으면 true로 바뀌도록
    //왼앞 왼가 왼뒤 오앞 오가 오뒤

    int finalBread = 0;     //breadCount 에서 true 개수 count할 변수


    public float smooth = 0.3f;
    private Quaternion targetRotation;

    
    

    void Start()
    {
        targetRotation = transform.rotation;
    }




    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown(KeyCode.Space))   //누르는 동안 hold
        {

            for (int i = 0; i < 4; i++)
            {
                if (Player.breadCount[i] == true)
                {
                    finalBread++;
                }
            }

            // transform.localScale = new Vector3(transform.localScale.x * -1, transform.localScale.y, transform.localScale.z);

            score.scoreValue += finalBread;

            targetRotation *= Quaternion.AngleAxis(180, Vector3.up);



        }
        transform.rotation = Quaternion.Lerp(transform.rotation, targetRotation, 5 * smooth * Time.deltaTime);
    }
}
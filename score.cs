//Main 상단에 표시되는 코드
//End 씬에서 쓰이는 코드
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class score : MonoBehaviour
{
    public static int scoreValue = 0;
    Text Score;

    void Start()
    {
        Score = GetComponent<Text>();

    }

    void Update()
    {
        Score.text = "Score  " + scoreValue;

        //scoreValue += GameObject.Find("ant").GetComponent<getScore>().finalBread;
    }
} 



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class finalScore : MonoBehaviour
{
    public Text finalScore1;
    public Text highScore;

    void Start()
    {
        finalScore1 = GetComponent<Text>();
        highScore.text = "최고기록 " + PlayerPrefs.GetInt("highScore",0).ToString() + "개";

    }

    void Update()
    {
        finalScore1.text = score.scoreValue.ToString() + "개를 가져왔구나";

        if(score.scoreValue > PlayerPrefs.GetInt("highScore", 0))
        {
            PlayerPrefs.SetInt("highScore", score.scoreValue);
            highScore.text = score.scoreValue.ToString();
        }



    }
}

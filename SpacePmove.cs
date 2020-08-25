using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpacePmove : MonoBehaviour
{
    GameObject ht, ant;
    AntMove antmove;

    float time;
    public float blinkTime = 0.5f;

    void Awake()
    {
        ht = GameObject.Find("SpaceImage2");
        ant = GameObject.Find("ant");
        antmove = ant.GetComponent<AntMove>();
    }
    // Start is called before the first frame update
    void Start()
    {
        gameObject.SetActive(false);
        ht.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (time < blinkTime)
        {
            ht.SetActive(true);
        }
        else
        {
            ht.SetActive(false);
            if (time > blinkTime * 2)
            {
                time = 0.0f;
            }
        }
        time += Time.deltaTime;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject.Find("Canvas").GetComponent<PopupLoad>().chkBread = true;
            gameObject.SetActive(false);
            ht.SetActive(false);
        }
    }
}

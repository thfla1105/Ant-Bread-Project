﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BreadPmove : MonoBehaviour
{
    Player player;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.Find("ant").GetComponent<Player>();
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Player.isParent_A || Player.isParent_K || Player.isParent_L || Player.isParent_S)
        {
            GameObject.Find("Canvas").GetComponent<PopupLoad>().chkBread = false;
            gameObject.SetActive(false);
        }
        
    }
}

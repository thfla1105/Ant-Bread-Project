using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupLoad : MonoBehaviour
{
    AntMove antmove;
    Player player;
    GameObject SpacePopup, SpacePopup2, BreadPopup, BreadPopup2, SpinAnt, SpinAnt2, ant;

    public bool chkBread = true;
    public bool chkBread2 = false;
    public bool chkSpace = true;
    public bool chkSpin = true;

    void Awake()
    {
        SpacePopup = GameObject.Find("SpaceImage");
        SpacePopup2 = GameObject.Find("SpaceImage2");
        BreadPopup = GameObject.Find("BreadPickup");
        BreadPopup2 = GameObject.Find("BreadPickup2");
        SpinAnt = GameObject.Find("SpinAntImage");
        SpinAnt2 = GameObject.Find("SpinAntImage2");
        ant = GameObject.Find("ant");
        antmove = ant.GetComponent<AntMove>();
        player = ant.GetComponent<Player>();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if ((!chkBread2) && score.scoreValue == 0)
        {
            if (player.isPlayerEnter && !Player.isParent_A && !Player.isParent_K && !Player.isParent_L && !Player.isParent_S)
            {
                BreadPopup.SetActive(true);
            }   
            else
            {
                BreadPopup.SetActive(false);
            }
        }

        if (chkBread2 && getScore.isAntUpSideDown % 2 == 0 && score.scoreValue == 0)
        {
            if (player.isPlayerEnter && !Player.isParent_A && !Player.isParent_K && !Player.isParent_L && !Player.isParent_S)
            {
                BreadPopup2.SetActive(true);
            }
            else
            {
                BreadPopup2.SetActive(false);
            }
        }

        if (score.scoreValue == 0 && getScore.isAntUpSideDown % 2 == 0)
        {
            if ((Player.isParent_A || Player.isParent_K || Player.isParent_L || Player.isParent_S) && player.isPlayerEnter)
            {
                SpinAnt.SetActive(true);
            }
            else
            {
                SpinAnt.SetActive(false);
                SpinAnt2.SetActive(false);
            }
        }
     
        if (score.scoreValue == 0)
        {
            if (ant.transform.eulerAngles.y == 270.0f && ant.transform.position.y == -7.0f)
            {
                SpacePopup.SetActive(true);
            }

            else
            {
                SpacePopup.SetActive(false);
                SpacePopup2.SetActive(false);
            }
        }
        
    }
}

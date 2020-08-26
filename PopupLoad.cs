using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PopupLoad : MonoBehaviour
{
    AntMove antmove;
    Player player;
    
    GameObject SpacePopup, SpacePopup2, BreadPopup, BreadPopup2, SpinAnt, SpinAnt2, ant,timer,startpopup;

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

        ///////////
        startpopup = GameObject.Find("startpopup");
        timer= GameObject.Find("Timer");

    }

    // Start is called before the first frame update
    void Start()
    {
        startpopup.SetActive(true);
        timer.SetActive(false);
        Invoke("letgopop", 1);
        Invoke("letgo", 2);
        Invoke("timergo", 2.3f);

    }

    void letgopop()
    {
        startpopup.transform.localScale = new Vector3(1.5f, 1.5f,1.5f);
    }

    void letgo()
    {
        startpopup.SetActive(false);
        
    }
    void timergo()
    {
        timer.SetActive(true);
    }
    
    // Update is called once per frame
    void Update()
    {

        
        if (!chkSpin && chkSpace) chkBread2 = true;

        else chkBread2 = false;

        if ((!chkBread2) && getScore.isAntUpSideDown % 2 == 0)
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

        if (chkBread2 && getScore.isAntUpSideDown % 2 == 0)
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

        if (getScore.isAntUpSideDown % 2 == 0)
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

        if (ant.transform.eulerAngles.y == 270.0f)
        {
            if (ant.transform.position.y == -7.0f)
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

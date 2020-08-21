using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject prefabMenu;
    GameObject menu;
    GameObject canvas;

    void Awake()
    {
        menu = GameObject.Find("MenuButton");
        canvas = GameObject.Find("Canvas");
    }

    public void StartMainChange()
    {
        SceneManager.LoadScene("Main");
    }

    public void MenuLoad()
    {
        GameObject.Find("ant").GetComponent<AntMove>().enabled = false;
        GameObject.Find("L1.001").GetComponent<LeftLeg_D>().enabled = false;
        GameObject.Find("L2.001").GetComponent<LeftLeg_S>().enabled = false;
        GameObject.Find("L3.001").GetComponent<LeftLeg_A>().enabled = false;
        GameObject.Find("R1.001").GetComponent<RightLeg_J>().enabled = false;
        GameObject.Find("R2.001").GetComponent<RightLeg_K>().enabled = false;
        GameObject.Find("R3.001").GetComponent<RightLeg_L>().enabled = false;
        GameObject.Find("Timer").GetComponent<timer>().enabled = false;
        canvas.GetComponent<Tu13Move>().enabled = false;
        canvas.GetComponent<Tu2Move>().enabled = false;
        canvas.GetComponent<Tu48Move>().enabled = false;
        canvas.GetComponent<Tu57Move>().enabled = false;
        canvas.GetComponent<Tu6Move>().enabled = false;
        Vector3 creatingpoint = canvas.transform.localPosition;
        Instantiate(prefabMenu, creatingpoint, Quaternion.identity);
        menu.SetActive(false);
        
    }

    public void MenuDelete()
    {
        GameObject.Find("ant").GetComponent<AntMove>().enabled = true;
        GameObject.Find("L1.001").GetComponent<LeftLeg_D>().enabled = true;
        GameObject.Find("L2.001").GetComponent<LeftLeg_S>().enabled = true;
        GameObject.Find("L3.001").GetComponent<LeftLeg_A>().enabled = true;
        GameObject.Find("R1.001").GetComponent<RightLeg_J>().enabled = true;
        GameObject.Find("R2.001").GetComponent<RightLeg_K>().enabled = true;
        GameObject.Find("R3.001").GetComponent<RightLeg_L>().enabled = true;
        GameObject.Find("Timer").GetComponent<timer>().enabled = true;
        canvas.GetComponent<Tu13Move>().enabled = true;
        canvas.GetComponent<Tu2Move>().enabled = true;
        canvas.GetComponent<Tu48Move>().enabled = true;
        canvas.GetComponent<Tu57Move>().enabled = true;
        canvas.GetComponent<Tu6Move>().enabled = true;
        Destroy(prefabMenu);
        menu.SetActive(true);
    }

    public void StartLoad()
    {
        SceneManager.LoadScene("Start");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public GameObject prefabMenu;
    public void StartMainChange()
    {
        SceneManager.LoadScene("Main");
    }

    public void MenuLoad()
    {
        GameObject.Find("ant").GetComponent<AntMove>().enabled = false;
        GameObject.Find("L1").GetComponent<LeftLeg_D>().enabled = false;
        GameObject.Find("L2").GetComponent<LeftLeg_S>().enabled = false;
        GameObject.Find("L3").GetComponent<LeftLeg_A>().enabled = false;
        GameObject.Find("R1").GetComponent<RightLeg_J>().enabled = false;
        GameObject.Find("R2").GetComponent<RightLeg_K>().enabled = false;
        GameObject.Find("R3").GetComponent<RightLeg_L>().enabled = false;
        GameObject canvas = GameObject.Find("Canvas");
        Vector3 creatingpoint = canvas.transform.localPosition;
        Instantiate(prefabMenu, creatingpoint, Quaternion.identity);
    }

    public void MenuDelete()
    {
        GameObject.Find("ant").GetComponent<AntMove>().enabled = true;
        GameObject.Find("L1").GetComponent<LeftLeg_D>().enabled = true;
        GameObject.Find("L2").GetComponent<LeftLeg_S>().enabled = true;
        GameObject.Find("L3").GetComponent<LeftLeg_A>().enabled = true;
        GameObject.Find("R1").GetComponent<RightLeg_J>().enabled = true;
        GameObject.Find("R2").GetComponent<RightLeg_K>().enabled = true;
        GameObject.Find("R3").GetComponent<RightLeg_L>().enabled = true;
        Destroy(prefabMenu);
    }

    public void StartLoad()
    {
        SceneManager.LoadScene("Start");
    }
}

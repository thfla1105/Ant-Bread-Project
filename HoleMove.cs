using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleMove : MonoBehaviour
{
    AntMove Ant;
    public float time = 60.0f;
    void Start()
    {
        Ant = GameObject.Find("ant").GetComponent<AntMove>();
        this.gameObject.transform.eulerAngles = new Vector3(0.0f, 0.0f, 0.0f);
        //StartCoroutine(DestroySelf());
    }

    // Update is called once per frame
    void Update()
    {
        if (Ant.chk == 1)
        {
            Destroy(gameObject);
        }
    }
    void OnTriggerStay(Collider col)
    {
        if (col.tag == "Hole" || col.tag == "AntFriend")
        {
            Destroy(gameObject);
        }
    }
    IEnumerator DestroySelf()
    {
        yield return new WaitForSeconds(time);
        Destroy(this.gameObject);
    }
}

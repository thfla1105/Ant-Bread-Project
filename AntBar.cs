using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntBar : MonoBehaviour
{
    RectTransform rt;
    Transform tr;

    public float upPoint;
    public float downPoint;
    public float barLength;

    float Ant2Dx, Ant2Dy, Ant2Dht, curAntPosition, treeLength, curLength, ratio, plusLength;

    // Start is called before the first frame update
    void Start()
    {
        treeLength = upPoint - downPoint;

        rt = (RectTransform)gameObject.transform;
        tr = GameObject.Find("ant").GetComponent<Transform>();

        Ant2Dx = rt.localPosition.x;
        Ant2Dy = rt.localPosition.y;
        Ant2Dht = rt.rect.height;

        barLength -= Ant2Dht;

        ratio = barLength / treeLength;
    }

    // Update is called once per frame
    void Update()
    {
        curAntPosition = tr.position.y;
        curLength = curAntPosition - downPoint;

        plusLength = curLength * ratio;

        rt.anchoredPosition = new Vector2(Ant2Dx, Ant2Dy + plusLength);
    }
}

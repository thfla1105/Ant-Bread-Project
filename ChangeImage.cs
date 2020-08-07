using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeImage: MonoBehaviour
{
    public void StartButtonEnterImage()
    {
        RectTransform rt = (RectTransform)gameObject.transform;
        rt.sizeDelta = new Vector2(350,148);
        rt.anchoredPosition = new Vector2(-70, -21);
    }

    public void StartButtonExitImage()
    {
        RectTransform rt = (RectTransform)gameObject.transform;
        rt.sizeDelta = new Vector2(350, 100);
        rt.anchoredPosition = new Vector2(-70, -45);
    }
}

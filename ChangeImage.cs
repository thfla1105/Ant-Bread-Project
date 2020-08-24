using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeImage: MonoBehaviour
{
    public void StartButtonEnterImage()
    {
        RectTransform rt = (RectTransform)gameObject.transform;
        rt.sizeDelta = new Vector2(400f, 194f);
        rt.anchoredPosition = new Vector2(0f, -238.5f);
    }

    public void StartButtonExitImage()
    {
        RectTransform rt = (RectTransform)gameObject.transform;
        rt.sizeDelta = new Vector2(400f, 130f);
        rt.anchoredPosition = new Vector2(0f, -270f);
    }
}

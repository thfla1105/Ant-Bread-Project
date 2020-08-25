using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rightArm : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(handSwing());

    }


    private IEnumerator handSwing()
    {
        while (true)
        {
            float t = 0.2f;
            while (t > 0)
            {
                transform.localPosition = new Vector3(1.72f, -1.09f, 0.25f);
                transform.localRotation = Quaternion.Euler(180.3f, 13f, -90f);
                t -= Time.deltaTime;
                yield return null;
            }

            float h = 0.2f;
            while (h > 0)
            {
                transform.localPosition = new Vector3(1.61f, -1.03f, 0.27f);
                transform.localRotation = Quaternion.Euler(180.3f, 13f, -50f);
                h -= Time.deltaTime;
                yield return null;
            }
            yield return null;
        }
    }


}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip fallingsound, pointsound, pickupsound, obstaclesound;
    static AudioSource audioSrc;

    void Start()
    {
        fallingsound = Resources.Load<AudioClip>("fallingsound");
        pointsound = Resources.Load<AudioClip>("pointsound");
        pickupsound = Resources.Load<AudioClip>("pickupsound");
        obstaclesound = Resources.Load<AudioClip>("obstaclesound");


        audioSrc = GetComponent<AudioSource>();

    }

    void Update()
    {
    }

    public static void PlaySound(string clip)
    {
        switch (clip)
        {
            case "fallingsound":
                audioSrc.PlayOneShot(fallingsound);
                break;

            case "pointsound":
                audioSrc.PlayOneShot(pointsound);
                break;

            case "pickupsound":
                audioSrc.PlayOneShot(pickupsound);
                break;
            case "obstaclesound":
                audioSrc.PlayOneShot(obstaclesound);
                break;

        }
    }
}

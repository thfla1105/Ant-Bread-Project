using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{

    public static AudioClip fallingsound, pointsound, pickupsound, obstaclesound, falling, descendingsound;
    static AudioSource audioSrc;

    static AudioSource audioSrc2;

    void Start()
    {
        fallingsound = Resources.Load<AudioClip>("fallingsound");
        pointsound = Resources.Load<AudioClip>("pointsound");
        pickupsound = Resources.Load<AudioClip>("pickupsound");
        obstaclesound = Resources.Load<AudioClip>("obstaclesound");
        falling = Resources.Load<AudioClip>("falling");
        descendingsound = Resources.Load<AudioClip>("descendingsound");

        audioSrc = GetComponent<AudioSource>();
        audioSrc2 = GetComponent<AudioSource>();

        audioSrc2.clip = falling;
        audioSrc2.volume = 0.02f;
        //audioSrc2.time = 2;
        //audioSrc2.loop = true;


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
            case "falling":
                audioSrc.PlayOneShot(falling);
                break;
            case "descendingsound":
             //   audioSrc.PlayDelayed(2);
                audioSrc.PlayOneShot(descendingsound);
                break;

        }
    }
}

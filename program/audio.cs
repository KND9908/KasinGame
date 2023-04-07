using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audio : MonoBehaviour
{
    private AudioSource AudioS;
    public AudioClip loopSounds;
    // Start is called before the first frame update
    void Start()
    {
        AudioS = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (AudioS.isPlaying == false)
        {
            AudioS.clip = loopSounds;
            AudioS.loop = true;
            AudioS.Play() ;
        }
    }
}

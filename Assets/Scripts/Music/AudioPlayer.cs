using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioClip[] audioClips;
    public AudioSource audioSource;

    // Start is called before the first frame update
    void Start()
    {
        PlayRandomMusic();   
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F9))
        {
            AudioClip randomClip = audioClips[Random.Range(0, audioClips.Length)];
            audioSource.Stop();
            audioSource.PlayOneShot(randomClip);
        }
    }
    void PlayRandomMusic()
    {
        if (audioClips.Length == 0) return;
        audioSource.clip = audioClips[Random.Range(0, audioClips.Length)];
        audioSource.Play();
        Invoke("PlayRandomMusic", audioSource.clip.length);
    }
}

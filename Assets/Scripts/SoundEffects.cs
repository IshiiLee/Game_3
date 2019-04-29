//Top of the script
#pragma warning disable 0649
#pragma warning disable 0108

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class SoundEffects : MonoBehaviour
{
    [SerializeField] private AudioClip[] stepSounds;
    [SerializeField] private AudioSource audio;

    // Start is called before the first frame update

    private void Awake()
    {
        audio = GetComponent<AudioSource>();
    }
    void Start()
    {
        audio.clip = stepSounds[Random.Range(0, stepSounds.Length)];
        audio.PlayOneShot(audio.clip);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void Footstep()
    {
        if (audio)
        {
            audio.PlayOneShot(stepSounds[Random.Range(0, stepSounds.Length)]);
            Debug.Log("playFootstepsss" + audio.clip.name);

        }
    }
}

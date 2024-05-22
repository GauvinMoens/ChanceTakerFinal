using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance { get; private set; }

    [SerializeField] AudioSource audioSrc, UISrc;
    [SerializeField] AudioClip doorOpenedClip,playClip,exitClip;

    private void Awake()
    {
        instance = this;
    }

    public void DoorOpened()
    {
        audioSrc.clip = doorOpenedClip;
        audioSrc.Play();
    }

    public void PlaySoundButton()
    {
        UISrc.clip = playClip;
        UISrc.Play();
    }

    public void ExitButtonSound()
    {
        UISrc.clip = exitClip;
        UISrc.Play();
    }
}

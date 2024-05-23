using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    public static AudioManager instance { get; private set; }

    [SerializeField] AudioSource audioSrc, UISrc, p1AudioSource, p2AudioSource;
    [SerializeField] AudioClip doorOpenedClip,playClip,exitClip,selectionClip,unselectionClip;
    [SerializeField] AudioClip[] _diceSounds;

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

    public void P1D4Sound()
    {
        p1AudioSource.clip = _diceSounds[Random.Range(0, 6)];
        p1AudioSource.Play();
    }
    public void P1D6Sound()
    {
        p1AudioSource.clip = _diceSounds[Random.Range(7, 16)];
        p1AudioSource.Play();
    }
    public void P1D8Sound()
    {
        p1AudioSource.clip = _diceSounds[Random.Range(17, 28)];
        p1AudioSource.Play();
    }
    public void P1D10Sound()
    {
        p1AudioSource.clip = _diceSounds[Random.Range(29, 38)];
        p1AudioSource.Play();
    }
    public void P1D12Sound()
    {
        p1AudioSource.clip = _diceSounds[Random.Range(39, 48)];
        p1AudioSource.Play();
    }
    public void P1D20Sound()
    {
        p1AudioSource.clip = _diceSounds[Random.Range(49, 58)];
        p1AudioSource.Play();
    }


    public void P2D4Sound()
    {
        p2AudioSource.clip = _diceSounds[Random.Range(0, 6)];
        p2AudioSource.Play();
    }
    public void P2D6Sound()
    {
        p2AudioSource.clip = _diceSounds[Random.Range(7, 16)];
        p2AudioSource.Play();
    }
    public void P2D8Sound()
    {
        p2AudioSource.clip = _diceSounds[Random.Range(17, 28)];
        p2AudioSource.Play();
    }
    public void P2D10Sound()
    {
        p2AudioSource.clip = _diceSounds[Random.Range(29, 38)];
        p2AudioSource.Play();
    }
    public void P2D12Sound()
    {
        p2AudioSource.clip = _diceSounds[Random.Range(39, 48)];
        p2AudioSource.Play();
    }
    public void P2D20Sound()
    {
        p2AudioSource.clip = _diceSounds[Random.Range(49, 58)];
        p2AudioSource.Play();
    }

    public void SelectionSound()
    {
        audioSrc.clip = selectionClip;
        audioSrc.Play();
    }
    public void UnselectionSound()
    {
        audioSrc.clip = unselectionClip;
        audioSrc.Play();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReproducirSonidoDeActivos: MonoBehaviour
{
    [SerializeField] AudioSource audioSource; 
    public void ReproducirAudioActivos(AudioClip audioClip)
    {
        audioSource.PlayOneShot(audioClip);
    }
}

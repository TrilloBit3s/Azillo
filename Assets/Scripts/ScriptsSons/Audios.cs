using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Audios : MonoBehaviour
{
    private BoxCollider[] Colisores;
    public AudioSource Audio;
    public AudioClip suspense;

    void Start()
    {
        Colisores = gameObject.GetComponents<BoxCollider>();
        Audio = gameObject.GetComponent<AudioSource>();
    }

    void OnTriggerEnter()
    {
        Audio.PlayOneShot(Audio.clip);
        GetComponent<AudioSource>().PlayOneShot(suspense);
        foreach (BoxCollider BoxColl in Colisores)
        {
            BoxColl.enabled = false;
        }
        //Destroi o Colisor apos tocar o som por inteiro
        Destroy(gameObject, Audio.clip.length); 
    }
}
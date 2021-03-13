using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class EventProtaFantasma : MonoBehaviour
{
    public GameObject porta;
    public AudioClip audioPorta;
    private BoxCollider[] colisores;

    void Start()
    {
        GetComponent<AudioSource>().clip = audioPorta;
        colisores = gameObject.GetComponents<BoxCollider>();
    }

    void OnTriggerEnter()
    {
        foreach(BoxCollider BoxColl in colisores)
        {
            BoxColl.enabled = false;
        }
        GetComponent<AudioSource>().PlayOneShot(GetComponent<AudioSource>().clip);
        porta.GetComponent<Animation>().Play("portaFantasma");
        Destroy(GetComponent<BoxCollider>());
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class EventoLuzPiscante : MonoBehaviour
{
    private AudioSource Audio;
    public GameObject Garotinha;
    public GameObject meshGarotinha;
    public Light LuzPiscante, luzDaLanternaDoPlayer, lucCimaLanterna, luzCentroLanterna ;
    public AudioClip somLuz, risoGarota;
    private BoxCollider[] colisores; 

    void Start()
    {
        GetComponent<AudioSource>().clip = somLuz;
        LuzPiscante.enabled = true;
        meshGarotinha.GetComponent<Renderer>().enabled = false;
        colisores = gameObject.GetComponents<BoxCollider>();
        Audio = gameObject.GetComponent<AudioSource>();
    }

    IEnumerator OnTriggerEnter()
    {
        luzDaLanternaDoPlayer.enabled = false;
        lucCimaLanterna.enabled = false;
        luzCentroLanterna.enabled = false;
        GetComponent<AudioSource>().PlayOneShot(Audio.clip);
        GetComponent<AudioSource>().PlayOneShot(risoGarota);
        foreach (BoxCollider BoxColl in colisores)
        {
            BoxColl.enabled = false;
        }

        yield return new WaitForSeconds (0.3f);
        LuzPiscante.enabled = false;

        yield return new WaitForSeconds (0.3f);
        LuzPiscante.enabled = true;

        yield return new WaitForSeconds (0.2f);
        LuzPiscante.enabled = false;

        yield return new WaitForSeconds (0.2f);
        LuzPiscante.enabled = true;

        yield return new WaitForSeconds (0.1f);
        LuzPiscante.enabled = false;

        yield return new WaitForSeconds (0.3f);
        LuzPiscante.enabled = true;

        meshGarotinha.GetComponent<Renderer>().enabled = true;
        yield return new WaitForSeconds (0.1f);
        LuzPiscante.enabled = false;
        meshGarotinha.GetComponent<Renderer>().enabled = false;
        yield return new WaitForSeconds (0.4f);

        Destroy(LuzPiscante);
        Destroy(Garotinha);
        Destroy(gameObject);
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Teleporte : MonoBehaviour
{
    public string nomeDaCena;

    void OnTriggerEnter(Collider hit)
    {
        if(hit.tag == "Player")
        {
            SceneManager.LoadScene(nomeDaCena);
        }
    }    
}
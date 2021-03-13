using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PLAYER : MonoBehaviour 
{
	public static float VIDA = 100f;
	public string nomeDaCena;

	void Start()
	{	
		VIDA=100;
	}

	void Update ()
	{
		if (VIDA <= 0) 
		{
		    VIDA=100;
			Debug.Log ("Morreu");
			SceneManager.LoadScene(nomeDaCena);	
		}
	}
}
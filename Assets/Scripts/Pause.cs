using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;

public class Pause : MonoBehaviour
{ 
	public GameObject textoPause;

	void Update()
	{		
		//caso queira usar a tecla Esc
		//if(Input.GetKeyDown(KeyCode.Escape)) 
		//if(Input.GetKey("p") == true)
		if(Input.GetKeyDown("p") == true)
		{
			if(Time.timeScale == 1)
			{
				textoPause.SetActive(true);
				Time.timeScale = 0;
				GetComponent<FirstPersonController>().enabled = false;
			}
			else
			{
				textoPause.SetActive(false);
				Time.timeScale = 1;	
				GetComponent<FirstPersonController>().enabled = true;
			}
		}
	}
}
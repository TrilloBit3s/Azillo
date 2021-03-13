using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]

public class Lamparina : MonoBehaviour
{
	public AudioClip ClickLamparina;

	void Update()
	{
        if(Input.GetKeyDown("f"))
		{
        	if(GetComponent<Light>().enabled == true)
			{
        		GetComponent<Light>().enabled = false;
				GetComponent<AudioSource>().PlayOneShot(ClickLamparina);
        	}
			else if (GetComponent<Light>().enabled == false)
			{
        		GetComponent<Light>().enabled = true;
				GetComponent<AudioSource>().PlayOneShot(ClickLamparina);
        	}
        }
    }
}
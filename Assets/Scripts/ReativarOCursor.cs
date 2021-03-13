using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ReativarOCursor : MonoBehaviour
{
	void Start()
    {
        Cursor.visible = true;
    }

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
         Cursor.lockState = CursorLockMode.None;	
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraCreadle : MonoBehaviour {


    public float speed = 20; 


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(
            Input.GetAxis("Horizontal") * speed * Time.deltaTime, 
            Input.GetAxis("Vertical") * speed * Time.deltaTime, 
            0);	
	}
}

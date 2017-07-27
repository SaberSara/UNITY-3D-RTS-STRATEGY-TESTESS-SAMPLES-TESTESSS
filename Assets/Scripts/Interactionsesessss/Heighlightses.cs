using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Heighlightses : Interactions {


    public GameObject displayItem;

    public override void deSelect()
    {
        displayItem.SetActive(false);
    }

    public override void select()
    {
        displayItem.SetActive(true);
    }

    // Use this for initialization
    void Start () {
        displayItem.SetActive(false);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

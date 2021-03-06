﻿using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapsBlips : MonoBehaviour {

    private GameObject blip;

    public GameObject Blip { get { return blip; } }


	// Use this for initialization
	void Start () {




        blip = GameObject.Instantiate(Map.current.blipPrefab);
        blip.transform.parent = Map.current.transform;
        var color = GetComponent<Players>().infos.accentColor;
        blip.GetComponent<Image>().color = color;
		
	}

    // Update is called once per frame
    void Update()
    {

        blip.transform.position = Map.current.WorldPositionToMap(transform.position);
    }
    private void OnDestroy()
    {
        GameObject.Destroy(blip);
    }
}

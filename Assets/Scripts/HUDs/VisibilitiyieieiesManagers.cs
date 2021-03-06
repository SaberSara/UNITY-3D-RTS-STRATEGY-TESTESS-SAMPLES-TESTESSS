﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VisibilitiyieieiesManagers : MonoBehaviour {

    public float timeBetweenChecks = 1;
    public float visibleRange = 100;

    private float waited = 10000;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        waited += Time.deltaTime;
        if (waited <= timeBetweenChecks)
            return;

        waited = 0;
        List<MapsBlips> pBlips = new List<MapsBlips>();
        List<MapsBlips> oBlips = new List<MapsBlips>();

        foreach(var p in RTSMaanager.current.players)
        {
            foreach(var u in p.ActiveUnits)
            {
                var blip = u.GetComponent<MapsBlips>();
                if (p == Players.defaults) pBlips.Add(blip);
                else oBlips.Add(blip);
            }
        }


        foreach (var o in oBlips)
        {
            bool active = false; 
            foreach(var p in pBlips)
            {
                var distance = Vector3.Distance(o.transform.position, p.transform.position);
                if(distance <=visibleRange)
                {
                    active = true;
                    break;
                }
            }
            o.Blip.SetActive(active);
            foreach (var r in o.GetComponentsInChildren<Renderer>()) r.enabled = active;/*)*/
        }
	}
}

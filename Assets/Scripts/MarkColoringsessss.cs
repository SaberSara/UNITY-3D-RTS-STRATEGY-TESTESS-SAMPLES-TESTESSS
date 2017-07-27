using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarkColoringsessss : MonoBehaviour {

    public MeshRenderer[] renderers;

	// Use this for initialization
	void Start () {



        var color = GetComponent<Players>().infos.accentColor;
        foreach(var r in renderers)
        {
            r.material.color=color;
        }
		
	}
}

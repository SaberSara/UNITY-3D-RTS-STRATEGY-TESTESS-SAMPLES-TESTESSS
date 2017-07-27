using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Players : MonoBehaviour {

    public PlayerSetupDefinitions infos;

    

    public static PlayerSetupDefinitions defaults;

	// Use this for initialization
	void Start () {



        infos.ActiveUnits.Add(this.gameObject);
        
		
	}
	
	// Update is called once per frame
	void Update () {


		
	}

    private void OnDestroy()
    {
        infos.ActiveUnits.Remove(this.gameObject);
    }
}

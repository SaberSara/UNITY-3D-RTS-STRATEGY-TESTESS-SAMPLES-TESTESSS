using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowUnitsInfos : Interactions {

    public string name;
    public float maxHealth, currentHealth;
    public Sprite profilePic;


    public override void select()
    {
        InfosManagers.current.setPic(profilePic);
        InfosManagers.current.setLines(
            name, currentHealth + " /  " + maxHealth,
            "Owner:" + GetComponent<Players>().infos.name,
            "");
    }


    public override void deSelect()
    {
        InfosManagers.current.clearPic();
        InfosManagers.current.clearLine();
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

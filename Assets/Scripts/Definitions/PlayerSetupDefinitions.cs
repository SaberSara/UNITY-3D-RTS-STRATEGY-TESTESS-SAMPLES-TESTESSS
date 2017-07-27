using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class PlayerSetupDefinitions {
    //Attributes

    //Publics
    public string name;

    public Transform location;

    public Color accentColor;

    private List<GameObject> activeUnits = new List<GameObject>();

    public List<GameObject> ActiveUnits { get { return activeUnits; } }

    public List<GameObject> startingUnits = new List<GameObject>();

    public bool isAI;

    public float creditses;

    

    //Privates


    



}

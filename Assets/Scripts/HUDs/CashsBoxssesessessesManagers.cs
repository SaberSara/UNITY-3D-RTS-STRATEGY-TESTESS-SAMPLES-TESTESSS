using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CashsBoxssesessessesManagers : MonoBehaviour {


    public Text cashField;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //**$


        //show credits
        cashField.text = "DH " + (int)Players.defaults.creditses;
	}
}

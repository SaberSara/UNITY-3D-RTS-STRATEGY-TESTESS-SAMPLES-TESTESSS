using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactivsesss : MonoBehaviour {


    private bool _selected = false;
    public bool selected { get { return _selected; } }

    public bool swap = false;

    public void select()
    {
        _selected = true;
        foreach(var selection in GetComponents<Interactions>())
            {
            selection.select();
        }
        
    }

    public void deSelect()
    {
        _selected = false;
        foreach (var selection in GetComponents<Interactions>())
        {
            selection.deSelect();
        }

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (swap)
        {
            swap = false;
            if (_selected) deSelect();
            else select();
        }
		
	}
}

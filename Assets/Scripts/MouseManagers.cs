using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseManagers : MonoBehaviour {


    private List<Interactivsesss> selection = new List<Interactivsesss>();
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (!Input.GetMouseButtonDown(0))
            return;
        var us = UnityEngine.EventSystems.EventSystem.current;
        if (us != null && us.IsPointerOverGameObject())
            return;
        if(selection.Count>0)
        {
            if(!Input.GetKey(KeyCode.LeftShift) && !Input.GetKey(KeyCode.RightShift))
            {
                foreach(var sel in selection)
                {
                    if (sel != null) sel.deSelect();
                }
                selection.Clear();
            }
        }



        var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;
        if (!Physics.Raycast(ray, out hit))
            return;
        var interact = hit.transform.GetComponent<Interactivsesss>();
        if (interact == null)
            return;

        selection.Add(interact);
        interact.select();
	}
}

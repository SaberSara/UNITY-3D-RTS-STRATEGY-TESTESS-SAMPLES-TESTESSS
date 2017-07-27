using System;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActionssessesesManagers : MonoBehaviour {

    public static ActionssessesesManagers current;

    public Button[] buttons;

    private List<Action> actionCalls = new List<Action>();

    public ActionssessesesManagers()
    {
        current = this;
    }

    public void clearButtons()
    {
        foreach (var b in buttons)
        {
            b.gameObject.SetActive(false);
        }

        actionCalls.Clear();
    }

    



    public void addButton(Sprite pic,Action onClick)
    {
        int index = actionCalls.Count;
        buttons[index].gameObject.SetActive(true);
        buttons[index].GetComponent<Image>().sprite = pic;
        actionCalls.Add(onClick);
    }


    public void OnButtonClick(int index)
    {
        actionCalls[index]();
    }








	// Use this for initialization
	void Start () {
		



        for(int i=0;i<buttons.Length;i++)
        {
            var index = i;
            buttons[index].onClick.AddListener(delegate ()
            {
                OnButtonClick(index);
            });
        }
        clearButtons();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

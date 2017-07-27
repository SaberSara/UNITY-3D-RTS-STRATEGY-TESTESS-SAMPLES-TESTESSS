using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InfosManagers : MonoBehaviour {

    public static InfosManagers current;

    public Image profilePic;
    public Text line1, line2, line3, line4;


    public InfosManagers()
    {
        current = this;
    }

    public void setLines(string line1, string line2, string line3, string line4)
    {
        this.line1.text = line1;
        this.line2.text = line2;
        this.line2.text = line2;
        this.line3.text = line3;
    }

    public void clearLine()
    {
        setLines("", "", "", "");
    }

    public void setPic(Sprite pic)
    {
        profilePic.sprite = pic;
        profilePic.color = Color.white;
    }

    public void clearPic()
    {
        profilePic.color = Color.clear;
    }
	// Use this for initialization
	void Start () {
        //intializeingedzededzed
        clearLine();
        clearPic();



        
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

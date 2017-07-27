using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RTSMaanager : MonoBehaviour {

    //Attributes

    //Publics
    public static RTSMaanager current = null;
    public List<PlayerSetupDefinitions> players = new List<PlayerSetupDefinitions>();

    public TerrainCollider mapCollider;

    public Vector3? screenPointToMapPosition(Vector2 point)
    {
        var ray = Camera.main.ScreenPointToRay(point);
        RaycastHit hit;
        if (!mapCollider.Raycast(ray, out hit, Mathf.Infinity))
            return null;

        return hit.point;
    }
        //Privates


	// Use this for initialization
	void Start () {
        current = this;
		//going trought the player for the unitiyies
        
            //instantiating for each player his all the his units 
        foreach (var p in players)
            foreach (var u in p.startingUnits)
            {
                var go=(GameObject)GameObject.Instantiate(u, p.location.position, p.location.rotation);
                var player = go.AddComponent<Players>();
                player.infos = p;
                if(!p.isAI)
                {
                    if (Players.defaults == null) Players.defaults = p;
                    go.AddComponent<RightClickNavigations>();
                }
            }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}

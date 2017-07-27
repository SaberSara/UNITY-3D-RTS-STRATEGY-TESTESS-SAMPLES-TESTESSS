using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class RightClickNavigations : Interactions {


    public float relaxDistance = 5;
    private NavMeshAgent agent;
    private Vector3 target = Vector3.zero;
    private bool selected = false;
    private bool isActive = false;

    public override void deSelect()
    {
        selected = false;
    }

    public override void select()
    {
        selected = true;
    }

    public void sendToTarget()
    {
        agent.SetDestination(target);
        agent.isStopped = false;
        isActive = true;
    }


    // Use this for initialization
    void Start () {
        agent = GetComponent<NavMeshAgent>();

		
	}
	
	// Update is called once per frame
	void Update () {
        if (selected && Input.GetMouseButtonDown(1))
        {
            var tempTarget = RTSMaanager.current.screenPointToMapPosition(Input.mousePosition);
            if (tempTarget.HasValue)
            {
                target = tempTarget.Value;
                sendToTarget();
            }
        }

        if (isActive && Vector3.Distance(target,transform.position)<relaxDistance)
        {
            agent.isStopped=true;
            isActive = false;
        }
		
	}
}

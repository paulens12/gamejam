using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleStepThroughPortal : StepThroughPortal
{


    protected override void _DoPortalAction(Collider player)
    {
        player.transform.position = targetPortal.transform.position + player.transform.forward * 1;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

}

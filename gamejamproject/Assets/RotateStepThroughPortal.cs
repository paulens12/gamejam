using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStepThroughPortal : StepThroughPortal
{

    protected override void _DoPortalAction(Collider player)
    {
        Vector3 xVec = new Vector3(1, 0, 0);
        transform.parent.RotateAround(player.transform.position, xVec, 90);
        player.transform.position = targetPortal.transform.position + player.transform.forward * 1;

    }

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}

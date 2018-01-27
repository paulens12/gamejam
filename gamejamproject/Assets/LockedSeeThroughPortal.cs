using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedSeeThroughPortal : SeeThroughPortal {

    public string key;

    protected override void _DoPortalAction(Collider playerColider)
    {
        Player player = playerColider.transform.GetComponent<Player>();
        if (player.requestObjectiveInstances("Button1Pressed"))
        {
            base._DoPortalAction(playerColider);
        }
    }
}

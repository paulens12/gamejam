﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockedSeeThroughPortal : SeeThroughPortal {

    public string m_key;
    public int m_numberRequired;
    public bool m_consumeKeys;

    protected override void _DoPortalAction(Collider playerColider)
    {
        Player player = playerColider.transform.GetComponent<Player>();



        if (player.hasObjectiveDone(m_key))
        {
            if (m_consumeKeys)
                player.requestObjectiveInstances(m_key);
            base._DoPortalAction(playerColider);
        }
    }
}

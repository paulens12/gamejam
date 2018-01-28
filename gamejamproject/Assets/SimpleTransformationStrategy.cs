using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTransformationStrategy : TransformationStrategy
{

    public override void DoTransform(Player player, StepThroughPortal targetPortal)
    {
        Vector3 newPosition = targetPortal.transform.position + player.transform.forward * 1;
        targetPortal.OrientToDirection(player.GetComponentInChildren<Camera>().transform.forward);
        player.transform.position = newPosition;
        player.GetComponentInChildren<Rigidbody>().velocity = new Vector3();
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTransformationStrategy : TransformationStrategy
{

    public override void DoTransform(Player player, StepThroughPortal targetPortal)
    {
        Vector3 newPosition = targetPortal.transform.position + player.transform.forward * 1;
        targetPortal.OrientToDirection(targetPortal.transform.position + player.transform.forward * 2);
        player.transform.position = newPosition;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleTransformationStrategy : TransformationStrategy
{

    public override void DoTransform(Player player, StepThroughPortal targetPortal)
    {
        player.transform.position = targetPortal.transform.position + player.transform.forward * 1;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTransformationStrategy : TransformationStrategy
{
    public Quaternion m_rotation;
    private GameObject m_objectToRotate;

    // Use this for initialization
    void Start()
    {
        m_objectToRotate = GameObject.Find("texturedhousemod2");
    }

    public override void DoTransform(Player player, StepThroughPortal targetPortal)
    {
        m_objectToRotate.transform.rotation *= m_rotation;// Rotate(player.transform.position, xVec, rotationAngle);
        player.transform.position = targetPortal.transform.position + player.transform.forward * 1;
    }
}

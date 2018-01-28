using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTransformationStrategy : TransformationStrategy
{
    public Quaternion m_rotation;

    // Use this for initialization
    void Start()
    {
    }

    public override void DoTransform(Player player, StepThroughPortal targetPortal)
    {
        GameObject.Find("texturedhousemod2").transform.Rotate(m_rotation.x, m_rotation.y, m_rotation.z);//.rotation *= m_rotation;// Rotate(player.transform.position, xVec, rotationAngle);
        player.transform.position = targetPortal.transform.position + player.transform.forward * 1;
        player.GetComponentInChildren<Rigidbody>().velocity = new Vector3();
    }
}

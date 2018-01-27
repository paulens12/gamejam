using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateStepThroughPortal : StepThroughPortal
{
    public float rotationAngle;
    public GameObject objectToRotate;

    protected override void _DoPortalAction(Collider player)
    {
        Vector3 xVec = new Vector3(1, 0, 0);
        objectToRotate.transform.RotateAround(player.transform.position, xVec, rotationAngle);
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

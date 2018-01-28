using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class StepThroughPortal : MonoBehaviour {

    public GameObject targetPortal;

    protected abstract void _DoPortalAction(Collider player);

    // Use this for initialization
    void Start () {
    
    }
    
    // Update is called once per frame
    void Update () {
    
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
        _DoPortalAction(other);
        }
    }

    public virtual void OrientToDirection(Vector3 direction)
    {
        transform.LookAt(transform.position + direction);
        transform.Rotate(0, 90, 90);
        //camToOrient.transform.localRotation = localRot;
    }
}

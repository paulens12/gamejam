using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
public class Player : UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController
{
    private Dictionary<string, int> objectivesMap;
    public GameObject PortalCollectionObject;
    public class Objectives
    {
        public const string Button1pressed = "Button1Pressed";
        public const string KeyItem = "KeyItem";
        public const string AxeItem = "AxeItem";
        public const string ArtefactItem = "ArtefactItem";
    }

    public Player()
    {
    objectivesMap = new Dictionary<string, int>(); 
    }

    public void RotateAssociatedPortals() //this should be just an update override
    {
        Vector3 directionToPortal;
        
        foreach (Transform child in PortalCollectionObject.transform)
        {
        
            SeeThroughPortal portal = child.GetComponent<SeeThroughPortal>();
            if (portal != null)
            {
                
                directionToPortal = child.position - transform.position;
                portal.OrientToDirection(directionToPortal);
            }
            
        }
    }

    public bool hasObjectiveDone(string key)
    {
        return objectivesMap.ContainsKey(key) && objectivesMap[key] > 0;
    }

    public int getNumberObjectiveInstances(string key)
    {
        if (hasObjectiveDone(key))
        {
            return objectivesMap[key];
        }
        else
            return 0;
    }

    public bool requestObjectiveInstances(string key, int numberRequested = 1)
    {
        if (hasObjectiveDone(key) && objectivesMap[key] >= numberRequested)
        {
            objectivesMap[key] -= numberRequested;
            return true;
        }
        return false;
    }

    public void addObjectiveInstance (string key)
    {
        if (!hasObjectiveDone(key))
        {
            objectivesMap.Add(key, 0);
        }
        objectivesMap[key] += 1;
    }
}

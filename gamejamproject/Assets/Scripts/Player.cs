using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
[RequireComponent(typeof(CapsuleCollider))]
public class Player : UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController
{
    private Dictionary<string, int> objectivesMap;
    public GameObject PortalCollectionObject;

    public Player()
    {
    objectivesMap = new Dictionary<string, int>(); 
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
        objectivesMap[key] += 1;
    }
}

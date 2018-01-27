using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : UnityStandardAssets.Characters.FirstPerson.RigidbodyFirstPersonController
{
    Dictionary<string, int> objectivesMap;
    
    public bool hasObjectiveDone(string key)
    {
        return objectivesMap.ContainsKey(key) && objectivesMap[key] > 0;
    }

    public bool requestObjectiveInstance(string key)
    {
        if (hasObjectiveDone(key))
        {
            objectivesMap[key] -= 1;
            return true;
        }
        return false;
    }

    public void addObjectiveInstance (string key)
    {
        objectivesMap[key] += 1;
    }
}

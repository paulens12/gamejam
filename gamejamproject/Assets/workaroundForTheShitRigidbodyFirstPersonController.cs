using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class workaroundForTheShitRigidbodyFirstPersonController : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Player thisPlayer = GetComponent<Player>();
        thisPlayer.RotateAssociatedPortals();
    }
}

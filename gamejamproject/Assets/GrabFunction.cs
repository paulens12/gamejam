using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrabFunction : MonoBehaviour {

    public string type;
    public GameObject obj;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTriggerEnter(Collider other) {
        if(other.name == "RigidBodyFPSController")
        {
            print("Grabbed Key");
            other.GetComponent<Player>().addObjectiveInstance(type);
            if(obj != null)
            {
                Destroy(obj);
            }
            Destroy(this.transform.gameObject);
        }
    }




}

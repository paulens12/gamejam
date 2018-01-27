using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IButtonScript
{
    void Activate();
}

public class CrosshairScript : MonoBehaviour {

    public float MaxDistance;

    private bool debounce = false;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetAxis("Fire1") <= 0)
            debounce = false;
        if (debounce)
            return;
        Ray ray = new Ray(transform.position, transform.TransformDirection(Vector3.forward));
        RaycastHit hit;
        if(Physics.Raycast(ray, out hit, MaxDistance))
        {
            var script = hit.transform.GetComponent<IButtonScript>();
            if (script != null)
            {
                Debug.Log("looking at it!");
                if (Input.GetAxis("Fire1") > 0)
                {
                    debounce = true;
                    script.Activate();
                }
            }
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

interface IButtonScript
{
    void Activate();

    void LookingAt();
}

public class CrosshairScript : MonoBehaviour {

    public float MaxGlowDistance;
    public float MaxActivateDistance;

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
        if(Physics.Raycast(ray, out hit, MaxGlowDistance))
        {
            var script = hit.transform.GetComponent<IButtonScript>();
            if (script != null)
            {
                Debug.Log("looking at it!");
                script.LookingAt();
                if (Input.GetAxis("Fire1") > 0 && hit.distance < MaxActivateDistance)
                {
                    debounce = true;
                    script.Activate();
                }
            }
        }
	}
}

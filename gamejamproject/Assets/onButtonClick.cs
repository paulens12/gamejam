using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onButtonClick : MonoBehaviour {
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Click");
            RaycastHit hitInfo = new RaycastHit();
            bool hit = Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hitInfo);
            if (hit)//Reikia kad nemestu null point exception
            {
                if (hitInfo.transform.gameObject.name == "Button1")
                {
                    print("button 1 pressed");
                }
            }
        }
    }
}

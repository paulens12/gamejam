using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI_ShowKeys : MonoBehaviour {


    public GameObject[] Panels; 



	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    IEnumerator UpdateGUI()
    {
        while (true)
        {
            foreach(GameObject obj in Panels)
            {

            }


            yield return new WaitForSeconds(0.5f);
        }
    }
}

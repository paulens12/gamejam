using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateMyPlatform : MonoBehaviour {


    public GameObject startingCube;
    public int numberOfPlatforms;
    public GameObject typeToDuplicate;
    public float cycleSpeed;
    private GameObject[] duplicates;
    private float distance = 0.5f;
    private int i = 0;

    // Use this for initialization
    void Start () {
        duplicates = new GameObject[numberOfPlatforms];
        StartCoroutine(Deploy(numberOfPlatforms));
    }
	
	// Update is called once per frame
	void Update () {
	    	
	}
    IEnumerator Deploy(int number)
    {
        new WaitForSeconds(1.0f);
        while (i < number)
        {
            if(i == 0)
            {
                yield return new WaitForSeconds(1.0f);
            }
            GameObject newCube = Instantiate(typeToDuplicate, new Vector3(startingCube.transform.position.x, startingCube.transform.position.y, startingCube.transform.position.z + 1 + i), Quaternion.identity);
            i++;
            yield return new WaitForSeconds(cycleSpeed);
        }
        CancelInvoke("Deploy");
    }
}

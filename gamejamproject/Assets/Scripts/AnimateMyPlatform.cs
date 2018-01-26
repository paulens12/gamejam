using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateMyPlatform : MonoBehaviour {


    public GameObject startingCube;
    public int numberOfPlatforms;
    public GameObject typeToDuplicate;
    public float cycleSpeed;
    public float gap;
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
            i++;
            GameObject newCube = Instantiate(typeToDuplicate, 
                startingCube.transform.position,
                startingCube.transform.rotation);
            newCube.transform.parent = startingCube.transform.parent;
            newCube.transform.Translate(new Vector3(0, 0, gap * i));

            yield return new WaitForSeconds(cycleSpeed);
        }
        CancelInvoke("Deploy");
    }
}

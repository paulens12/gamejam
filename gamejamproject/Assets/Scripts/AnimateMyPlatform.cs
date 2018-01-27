using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimateMyPlatform : MonoBehaviour {


    public GameObject startingCube;
    public int numberOfPlatforms;
    public GameObject typeToDuplicate;
    public float cycleSpeed;
    public float gap;
    public bool decay;
    public float decayTime;
    public float decaySmooth;
    public float decaySpeed;
    private GameObject[] duplicates;
    private float distance = 0.5f;
    private int i = 0;

    // Use this for initialization
    void Start () {
        duplicates = new GameObject[numberOfPlatforms+1];
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
            duplicates[i] = newCube;
            if (decay) StartCoroutine("Destroy", newCube);
            yield return new WaitForSeconds(cycleSpeed);
        }
        CancelInvoke("Deploy");
    }
    IEnumerator Destroy(GameObject cubeObject)
    {
        GameObject cube = cubeObject.transform.GetChild(0).gameObject;
        for(float i = 1; i > 0; i -= decaySmooth)
        {
            Renderer rend = cube.GetComponent<Renderer>();
            rend.material.color = new Color(rend.material.color.r, rend.material.color.g, rend.material.color.b,i);
            yield return new WaitForSeconds(decaySpeed);
        }
        DestroyImmediate(cubeObject);

        CancelInvoke("Deploy");

    }
}

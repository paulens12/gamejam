using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceCountUI : MonoBehaviour
{
    public GameObject first;
    public GameObject second;
    public Text text;
    // Use this for initialization
    void Start()
    {
        StartCoroutine(UpdateInformation());
    }

    // Update is called once per frame
    void Update()
    {

    }


    IEnumerator UpdateInformation()
    {
        while (true)
        {
            float dist = Vector3.Distance(first.transform.position, second.transform.position);
            text.text = "Distance till object:" + dist;
            yield return new WaitForSeconds(0.1f);
        }
    }
}

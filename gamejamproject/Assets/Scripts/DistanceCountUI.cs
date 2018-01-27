using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceCountUI : MonoBehaviour
{
    public GameObject first;
    public GameObject second;
    public Text text;
    public GameObject progressBar;
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
            GraphicalDistance progress = progressBar.GetComponent<GraphicalDistance>();
            progress.setPercentage(progress.getPercentage(dist));
            yield return new WaitForSeconds(0.05f);
        }
    }
}

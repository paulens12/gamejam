using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GraphicalDistance : MonoBehaviour {

    public float minValue;
    public float maxValue;
    public Image progressBar;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public float getPercentage(float value)
    {
        float minValuePercentage = minValue / maxValue;
        //print(value / (maxValue + minValuePercentage));
        return minValuePercentage + 1 - (value / maxValue);
    }
    public void setPercentage(float percentage)
    {
        progressBar.fillAmount = percentage;
        if (percentage < 0.3f)
            progressBar.material.SetColor("_SpecColor", Color.red);
        else if (percentage < 0.7f)
            progressBar.material.SetColor("_SpecColor",Color.yellow);
        else
            progressBar.material.SetColor("_SpecColor", Color.green);
    }
}

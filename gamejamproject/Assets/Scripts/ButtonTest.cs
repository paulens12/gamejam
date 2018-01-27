using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest : MonoBehaviour, IButtonScript {

	public void Activate()
    {
        Debug.Log("ouch!");
        transform.Rotate(30, 0, 0);
        Invoke("RotateBack", 0.5f);
    }

    private void RotateBack()
    {
        transform.Rotate(-30, 0, 0);
    }
}

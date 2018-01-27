using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTest : MonoBehaviour, IButtonScript {
    public float HaloDelay;
    private float lastLookedAt;
    private bool deactivated = true;
    public Behaviour Button;

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

    public void LookingAt()
    {
        lastLookedAt = Time.time;
        deactivated = false;
        Button.enabled = true;
    }

    public void Update()
    {
        if(!deactivated && Time.time - HaloDelay > lastLookedAt)
        {
            deactivated = true;
            Button.enabled = false;
            Debug.Log("not looking");
        }
    }
}

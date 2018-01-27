using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddKeyButton : MonoBehaviour, IButtonScript {
    public float HaloDelay;
    private float lastLookedAt;
    private bool deactivated = true;
    public Behaviour Glow;
    public string AchievementKey;
    public GameObject Player;

	public void Activate()
    {
        Debug.Log("ouch!");
        Player.GetComponent<Player>().addObjectiveInstance(AchievementKey);
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
        Glow.enabled = true;
    }

    public void Update()
    {
        if(!deactivated && Time.time - HaloDelay > lastLookedAt)
        {
            deactivated = true;
            Glow.enabled = false;
            Debug.Log("not looking");
        }
    }
}

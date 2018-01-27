using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SeeThroughPortal : StepThroughPortal
{

    protected override void _DoPortalAction(Collider player)
    {
        player.transform.position = targetPortal.transform.position + player.transform.forward * 1;
    }

    // Use this for initialization
    void Start()
    {
        Camera newCamera = targetPortal.GetComponentInChildren<Camera>();
        //newCamera.transform.parent = targetPortal.transform;
        GameObject childCameraObject = new GameObject();
        childCameraObject.transform.parent = targetPortal.transform;
        //Camera newCamera = childCameraObject.AddComponent<Camera>();
        RenderTexture myTexture = new RenderTexture(256, 256, 24, RenderTextureFormat.ARGB32);
        newCamera.targetTexture = myTexture;
        Material portalMaterial = new Material(new Material(Shader.Find("Standard")));
        int albedoId = Shader.PropertyToID("Albedo");
        portalMaterial.SetTexture(albedoId, myTexture);
        portalMaterial.mainTexture = myTexture;
        Renderer myrenderer = GetComponent<Renderer>();
        myrenderer.material = portalMaterial;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

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
        GameObject childCameraObject = new GameObject();
        childCameraObject.transform.parent = targetPortal.transform;
        Camera newCamera2 = childCameraObject.AddComponent<Camera>();
        childCameraObject.transform.position = new Vector3(0, 0, 0);
        childCameraObject.transform.localPosition = new Vector3(0, 0, 0);
        childCameraObject.transform.rotation = Quaternion.identity;
        childCameraObject.transform.localRotation = Quaternion.identity;
        RenderTexture myTexture = new RenderTexture(256, 256, 24, RenderTextureFormat.ARGB32);
        newCamera2.targetTexture = myTexture;
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

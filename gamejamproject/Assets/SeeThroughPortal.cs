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
        Camera targetCamera = targetPortal.GetComponent<Camera>();
        RenderTexture myTexture = new RenderTexture(256, 256, 24, RenderTextureFormat.ARGB32);
        Material portalMaterial = new Material(new Material(Shader.Find("Standard")));
        Renderer myrenderer = GetComponent<Renderer>();
        myrenderer.material = portalMaterial;
    }

    // Update is called once per frame
    void Update()
    {

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class GestionObjSocket : XRSocketInteractor
{

    public GameObject objSocket;
    private Vector3 tailleOriginale;
    
     protected override void OnSelectEntering(XRBaseInteractable interactable)
    {
        objSocket = interactable.gameObject;
        tailleOriginale = objSocket.transform.localScale;
        objSocket.transform.localScale = tailleOriginale * 0.5f;
    }

      protected void OnSelectExited(XRBaseInteractable interactable)
    {
        objSocket.transform.localScale = tailleOriginale;
        objSocket = null;
    }

}

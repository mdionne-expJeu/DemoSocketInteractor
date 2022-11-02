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
        print("entrée");
        objSocket = interactable.gameObject;
        tailleOriginale = objSocket.transform.localScale;
        objSocket.transform.localScale = tailleOriginale * 0.5f;
    }

      protected override void OnSelectExited(XRBaseInteractable interactable)
    {
        print("sortie");
        objSocket.transform.localScale = tailleOriginale;
        objSocket = null;
    }

}

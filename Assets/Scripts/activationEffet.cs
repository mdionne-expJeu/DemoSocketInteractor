using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class activationEffet : MonoBehaviour
{
    public Material materielActif;
    public Material materielInactif;

    public GameObject[] objetsActive;

    private bool actif = false;
    
    public void ChangementEtat()
    {
        actif = !actif;
        if(actif)
        {
            Activation(materielActif, true);
        }
        else
        {
            Activation(materielInactif, false);
        }
    }
    void Activation(Material leMateriel, bool etatActivation)
    {

        GetComponent<MeshRenderer>().material = leMateriel;

        foreach (GameObject objet in objetsActive)
        {
            objet.SetActive(etatActivation);
        }
    }
}

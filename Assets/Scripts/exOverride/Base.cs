using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Base : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        QuelEstMonNom();
    }

    // Update is called once per frame
    public virtual void QuelEstMonNom()
    {
        print("Je suis le parent");
    }

   
}

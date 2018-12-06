using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyUi : MonoBehaviour
{

    public SpriteRenderer rend;
    public Sprite KeyOptained;

    void Update()
    {
        //jag vet nu i efterhand att jag kan göra detta mycket enklare med 
        // public GreenKeyScript GKS;
        //och sedan badra skriva GKS.KeyOptained;

        //letar upp GreenKey
        GameObject GreenKey = GameObject.FindWithTag("GreenKey");
        if(GreenKey != null)
        {
            //hittar scriptet GreenKeyScript
            GreenKeyScript greenKeyScript = GreenKey.GetComponent<GreenKeyScript>();
            if(greenKeyScript.KeyObtained == true)
            {
                //ändrar spriten till KeyOptained
                rend.sprite = KeyOptained;
            }
        }
    }
}

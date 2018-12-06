using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlueLockScript : MonoBehaviour
{
    void Update()
    {
        //Den letar upp BlueButton med tag "BlueButton"
        GameObject BlueButton = GameObject.FindGameObjectWithTag("BlueButton");
        if (BlueButton != null)
        {
            //Hittar scriptet "BlueButtonscript
            BlueButtonScript blueButtonScript = BlueButton.GetComponent<BlueButtonScript>();
            if (blueButtonScript != null)
            {
                //ifall Boolen är true
                if (blueButtonScript.BlueSignal == true)
                {
                    //föstörs Låset
                    Destroy(gameObject);
                }
            }
            else
            {
                //annars får jag ett error
                //ps. Kan ha varit lite trött på att fixa scriptet så förlåt för språket
                Debug.LogError("Kan inte hitta skiten");
            }

        }
        else
        {
            Debug.LogError("kAN INTE hitta button");
        }
    }
}

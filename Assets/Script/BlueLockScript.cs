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
                Debug.LogError("Kan inte hitta blueButtonScript");
            }
        }
        else
        {
            Debug.LogError("kAN INTE hitta button");
        }

        //jag hade kunnat skippa 70% av scriptet ifall jag bara hade gjort Public BlueButtonScript blueButtonScript
    }
}

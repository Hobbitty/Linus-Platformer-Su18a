using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenLockScript : MonoBehaviour
{


    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.name == "PLayer")
        {
            //letar upp greenKey och går in och hämtar Scriptet "GreenKeyScript"
            GameObject greenKey = GameObject.FindWithTag("GreenKey");
            GreenKeyScript greenKeyScript = greenKey.GetComponent<GreenKeyScript>();
            if (greenKeyScript.KeyObtained == true)
            {
                //om Boolen är true förstörs låset
                Destroy(gameObject);
            }
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedLockScript : MonoBehaviour
{
    //lärde mig nyss att jag kan bara göra såhär för att komma åt ett annat script
    public RedButtonScript RBS;

    private void Update()
    {
        //Ifall RedSignal(Spelaren har nuddat knappen) == true
        if (RBS.RedSignal == true)
        {
            //fösrstör sig själv
            Destroy(gameObject);
        }

    }
}

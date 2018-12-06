using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnGround : MonoBehaviour {

    public int touches;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ganska enkelt
        //ökar eller minsakr en int 
        touches++;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        touches--;
    }
}

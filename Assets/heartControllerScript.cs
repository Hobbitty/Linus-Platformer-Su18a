using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class heartControllerScript : MonoBehaviour {

    public HPScript HPS;
    public SpriteRenderer heart1;
    public SpriteRenderer heart2;
    public SpriteRenderer heart3;
    public Sprite heartLost;

	void Update ()
    {
        //ifall spelarens hp är under 100 men över 50
        if(HPS.health <= 100 && HPS.health >= 50)
        {
            //sätts heart3 spriten till heartLost
            heart3.sprite = heartLost;
        }
        //ifall spelarens hp är under 50 men över 0
        if(HPS.health <= 50 && HPS.health >= 0)
        {
            //sätts heart2 spriten till heartLost.
            heart2.sprite = heartLost;
        }
	}
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BlueButtonScript : MonoBehaviour
{
    public bool BlueSignal = false;
    public Sprite ButtonPressed;
    public SpriteRenderer rend;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //om Player nuddar Knappen
        if (collision.tag == ("Player"))
        {
            //Ändras boolen till true
            BlueSignal = true;
            //och spriten blir "ButtonPressed"
            rend.sprite = ButtonPressed;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenKeyScript : MonoBehaviour
{

    public bool KeyObtained = false;
    public SpriteRenderer Rend;
    public Sprite None;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ändrar boolen till true
        KeyObtained = true;
        //Sätter spriten till "None"
        Rend.sprite = None;
    }
}

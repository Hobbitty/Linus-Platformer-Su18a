using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(SpriteRenderer))]
public class SpriteOff : MonoBehaviour {

    private SpriteRenderer Rend;


    private void Start()
    {
        Rend = gameObject.GetComponent<SpriteRenderer>();
        Rend.enabled = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringScript : MonoBehaviour
{
    public SpriteRenderer Rend;
    public Sprite Spring2;
    public Sprite Spring1;
    private Rigidbody2D rBody;
    public float Power;

    //ifall något nuddar gameObject
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //och det "Något" är PLayer
        if (collision.gameObject.name == "PLayer")
        {
            GameObject Player = GameObject.FindWithTag("Player");
            rBody = Player.GetComponent<Rigidbody2D>();
            //spelaren får en velocity baserat på en Variabel
            rBody.velocity = new Vector2(rBody.velocity.x, Power);
            //Springen får också en annan Sprite
            Rend.sprite = Spring2   ;
            //aktiverar funktionen efter 2 sekunder
            Invoke("SpringBack", 2);
        }
    }

    void SpringBack()
    {
        //ändrar tillbaka springen till den sprite den var förut
        Rend.sprite = Spring1;
    }
}

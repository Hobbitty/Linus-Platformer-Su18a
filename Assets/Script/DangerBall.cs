using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class DangerBall: MonoBehaviour
{
    public Rigidbody2D rbody;
    public GameObject sawBlade;
    public float vX;
    public float Vy;



    private void Start()
    {
        //När bollen blir spawnad sätts velocityn till samma värde som variablerna.
        rbody.velocity = new Vector2(vX, Vy);
    }

    //ifall bollen nuddar något
    private void OnCollisionEnter2D(Collision2D collision)
    {
        //och det något har taggen Ground.
        if(collision.gameObject.tag == "Ground")
        {
            //Spawnas GameObjectet Sawblade med samma position och rotation som "Dangerballen".
            Instantiate(sawBlade, transform.position, transform.rotation);
            Destroy(gameObject);
        }
    }
    //Jag hade kunnat göra scriptet på ett annat sätt.
    //Jag hade kunnat skippa sawBlade och gjort så att DangerBall växer och börjar rotera på samma sätt som sawBlade.
    //Då hade jag behövt göra en OnCollisionEnter2D med if(tag = "Ground") och därifrån stängt av alla aktiva script/rörelser
    //sedan stänga av gravitationen och sätta en ny velocity.
    //det är fullt möjligt men jag kännde mig bekvämare med att bara Instantiatea ett nyt object. 
}

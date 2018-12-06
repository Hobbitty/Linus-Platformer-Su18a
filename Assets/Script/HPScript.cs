using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HPScript : MonoBehaviour
{

    public int health = 100;
    private SpriteRenderer rend;
    private string enemy = "Enemy";
    private string spikes = "Spikes";

    void Start()
    {
        //Hittar spelarens Spritrenderer och sätter den som rend
        rend = gameObject.GetComponent<SpriteRenderer>();
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        //ifall spelaren nuddar en enemy eller spike så...
        if (collision.gameObject.tag == enemy || collision.gameObject.tag == spikes)
        {
            //Sätts fuktionen igåg
            HurtObject();
        }
    }

    void HurtObject()
    {
        //jag ändrar på Stringarna för att se till så att spelaren inte kan ta mer skada
        enemy = "Cooldown";
        spikes = "Cooldown";
        //sedan invokar jag en funktion som sätter tillbaka stringarna efter 2 sekunder
        Invoke("StringBack", 2);

        //jag invokar en fuktion direkt som sedan skall upprepas varje sekund.
        InvokeRepeating("SpriteDamaged", 0, 1f);
        //och sedan invokar jag en cancelInvoke funktion som skall stänga av alla invokes.
        Invoke("CancelInv", 2);

        //Gör så att spelarens HP minskar
        health = health - 50;
        //ifall spelarens hp är under eller = 0 restartar mappen. 
        if (health <= 0)
        {
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(active.name);
        }
    }
    void SpriteDamaged()
    {
        //invokar en funktion som skall sätta spelarens alpha till 1 efter 0,5 sekunder.
        Invoke("Alpha1", 0.5f);
        //sätter spelarnes alpha till 0,4
        rend.color = (new Color(1, 1, 1, 0.4f));
    }
    void Alpha1()
    {
        //aktiverar funktionen som minskar alphan igen efter 0,5 sekunder
        Invoke("SpriteDamaged", 0.5f);
        //ökar spelarens alpha.
        rend.color = (new Color(1, 1, 1, 0.6f));

        //denna loop loopar i två sekunder innan cancelInv fuktionen startas.
        //Detta betyder att spelaren blir genomskinlig två gånger innan den sedan får max alpha igen.
        //jag hade kunnat göra en animation, men jag vet inte hur jag kan aktivera just den animationen via script. 
        //så jag tog en liten omväg
    }
    void StringBack()
    {
        enemy = "Enemy";
        spikes = "Spikes";
    }
    void CancelInv()
    {
        rend.color = new Color(1, 1, 1, 1);
        CancelInvoke();
    }



}

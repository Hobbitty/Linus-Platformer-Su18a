using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinMechanics : MonoBehaviour
{
    public int Score = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            //skapar en variabel "controller" och sedan går söker efter ett Gameobject i taggen "GameController"
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {
                //Skapar en variabel "tracker" och sedan går och hämnat en component kallad ScoreTracker
                ScoreTracker tracker = controller.GetComponent<ScoreTracker>();
                if (tracker != null)
                {
                    tracker.totalScore += Score;
                }
                else
                {
                    Debug.LogError("ScoreTracker Saknas i GameController");
                }
            }

            //sedan förstör sig själv
            Destroy(gameObject);
        }
    }
}

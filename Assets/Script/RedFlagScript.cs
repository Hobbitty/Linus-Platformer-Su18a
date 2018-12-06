using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RedFlagScript : MonoBehaviour
{
    //om ett gameObject colliderar med "mig"
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //och det gameObjectet har taggen "Player"
        if (collision.tag == "Player")
        {
            //laddar nästa level baserad på buildindexen    
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}

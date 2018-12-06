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
        //
        if (collision.gameObject.tag == enemy || collision.gameObject.tag == spikes)
        {
            HurtObject();
        }
    }

    void HurtObject()
    {
        enemy = "Cooldown";
        spikes = "Cooldown";
        Invoke("StringBack", 2);

        InvokeRepeating("SpriteDamaged", 0, 1f);
        Invoke("CancelInv", 2);

        health = health - 50;
        if (health <= 0)
        {
            Scene active = SceneManager.GetActiveScene();
            SceneManager.LoadScene(active.name);
        }
    }
    void SpriteDamaged()
    {
        Invoke("Alpha1", 0.5f);
        rend.color = (new Color(1, 1, 1, 0.4f));
    }
    void Alpha1()
    {
        Invoke("SpriteDamaged", 0.5f);
        rend.color = (new Color(1, 1, 1, 0.6f));
    }
    void CancelInv()
    {
        rend.color = new Color(1, 1, 1, 1);
        CancelInvoke();
    }


}

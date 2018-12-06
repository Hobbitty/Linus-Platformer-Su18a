using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedButtonScript : MonoBehaviour
{
    public Transform Camera;
    public Transform Player;

    public Rigidbody2D Box;

    public bool RedSignal = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("Player"))
        {
            //gör att boxen kan falla till marken
            Box.simulated = true;
            //ändrar positionen för kameran
            Camera.position = new Vector3(-7.5f, 0.5f, -1f);
            RedSignal = true;
            //startar funktionen efter 1,5 sekunder
            Invoke("CameraGoBack", 1.5f);
        }
    }
    void CameraGoBack()
    {
        //Gör så att kameran är en Child av player
        Camera.IsChildOf(Player);
        //sätter sedan kamerans position till samma som spelaren har
        Camera.position = new Vector3(Player.position.x, Player.position.y, -1);
    }

    //Jag hade kunnat sätta camerans position till 0,0,-1 eftersom den är en child av player.
    //Jag hade också kunnat sätta vektorer där jag vill att kameran skall sätta sig, men eftersom den röda knappen är mer specifik
    //(den triggrar något i mappen, i detta fall en låda) 
    //så är det svårt att göra den till en prefab som skulle kunna fungera i en annan map.

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHorizontalMovement : MonoBehaviour
{
    public float moveSpeed = 2;
    public bool goLeft = true;
    public Rigidbody2D rbody;
    public Transform rat;

    private void Start()
    {
        Move();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        Move();
    }



    void Move()
    {
        //ändrar så att boolen är motsatt till vad den var när scriptet startade
        goLeft =! goLeft;
        if (goLeft == true)
        {
            //sätter Velocityn till -movespeed så att råttan ska gå till vänster
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
            //Sätter Scalen till 1,1,1
            rat.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            //ger råttan en velocity på movespeed så att råttan går till höger
            rbody.velocity = new Vector2(moveSpeed, rbody.velocity.y);
            //ändrar scalen så att råttan tittar till höger
            rat.localScale = new Vector3(-1, 1, 1);
            
        }
    }
}
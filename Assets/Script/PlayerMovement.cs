using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour {

    [Range(0, 10f)]
    public float moveSpeed;
    public float jumpHeight;
    public OnGround onGround;
    
    private Rigidbody2D rbody;
    
	void Start ()
    {
        //hittar RigidBody2D
        rbody = GetComponent<Rigidbody2D>();		
	}
	
	
	void Update ()
    {
        movement();
    }


    void movement()
    {
        //sätter Horizontal velocity till moveSpeed
        rbody.velocity = new Vector2(Input.GetAxis("Horizontal") * moveSpeed, rbody.velocity.y);
        
        //ifall Mellanslag blir nedtryckt och touches är större än 0  eller ifall W blir nedtryckt och touches  är större än 0
        if(Input.GetKeyDown(KeyCode.W) && onGround.touches > 0)
        {
            //får spelaren en Y velocity på samma värde som variabeln jumoHeight
            rbody.velocity = new Vector2(rbody.velocity.x, jumpHeight);
        }
    }
}

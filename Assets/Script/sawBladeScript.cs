using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sawBladeScript : MonoBehaviour
{
    public Rigidbody2D rbody;
    public float vX;
    public float vY;
    public float rotate;

    void FixedUpdate()
    {
        rotate = rotate + 0.05f;
        rbody.AddForce(new Vector2(vX, vY));
        transform.Rotate(0, 0, rotate);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == ("SpikeBallBorder"))
        {
            Destroy(gameObject);
        }
    }
}

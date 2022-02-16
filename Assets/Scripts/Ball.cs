using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{

    public Rigidbody2D rbody;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        BallMovement();
    }

    void BallMovement()
    {
        if(GameManager.startGame == true && GameManager.started ==false)
        {
            rbody.AddForce(transform.up * 575f);
            rbody.AddForce(transform.right * -300f);
            GameManager.started = true;
        }

        if(rbody.velocity.x <1 && rbody.velocity.x >= 0)
        {
            rbody.AddForce(transform.right * -40);
        }

        if (rbody.velocity.x > -1 && rbody.velocity.x <0)     
        {
            rbody.AddForce(transform.right * 40);
        }

        if (rbody.velocity.y < 1 && rbody.velocity.y >= 0)
        {
            rbody.AddForce(transform.up * -40);
        }

        if (rbody.velocity.y > 1 && rbody.velocity.y < 0)
        {
            rbody.AddForce(transform.up * 40);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Brick")
        {
            Destroy(collision.gameObject);
        }

        if(collision.gameObject.tag == "Lose")
        {
            Destroy(this.gameObject);
        }

        
    }
}

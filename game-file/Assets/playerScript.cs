using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public Rigidbody2D player;
    public float direction = 0f;
    public float walkSpeed = 5f;
    public float jumpStrength = 8f;

    public Transform groundCheck;
    public float groundCheckRadius;
    public LayerMask groundLayer;
    private bool isTouchingGround;


    // Start is called before the first frame update
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        // calls on the groundCheck object position (which is at the player's feet)
        // creates a circle at groundCheck with a radius of groundCheckRadius, and checks to see if that circle
        // is overlapping with any object on groundLayer (so ground objects)
        // if it is overlapping, then isTouchingGround is true and the player can jump :D
        isTouchingGround = Physics2D.OverlapCircle(groundCheck.position, groundCheckRadius, groundLayer);

        // Input pulls from the Input Manager in project settings, which has set keys for moving on the horizontal axis
        direction = Input.GetAxis("Horizontal");


        if(direction > 0f)
        {
            player.velocity = new Vector2(direction * walkSpeed, player.velocity.y);
        }
        else if (direction < 0f)
        {
            player.velocity = new Vector2(direction * walkSpeed, player.velocity.y);
        }
        else
        {
            // keeps the player from sliding on a tilted surface, for example
            player.velocity = new Vector2(0, player.velocity.y);
        }

        if (Input.GetButtonDown("Jump") && isTouchingGround)
        {
            player.velocity = new Vector2(player.velocity.x, jumpStrength);
        }

        //if (Input.GetKeyDown(KeyCode.Z))
        //{
        //    player.velocity = Vector2.up * jumpStrength;
        //}
        //if (Input.GetKeyDown(KeyCode.LeftArrow))
        //{
        //    player.velocity = Vector2.left * walkSpeed;
        //}
        //if (Input.GetKeyDown(KeyCode.RightArrow))
        //{
        //    player.velocity = Vector2.right * walkSpeed;
        //}

    }
}

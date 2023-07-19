using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript : MonoBehaviour
{
    public Rigidbody2D playerRigidbody;
    public float jumpStrength;
    public float walkSpeed;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            playerRigidbody.velocity = Vector2.up * jumpStrength;
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            playerRigidbody.velocity = Vector2.left * walkSpeed;
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            playerRigidbody.velocity = Vector2.right * walkSpeed;
        }

    }
}

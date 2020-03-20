using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour
{
    public float speed;
    public float jumpV;

    [HideInInspector]
    public Rigidbody2D player;

    private void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        Movement();

        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jumping();
        }
    }

    void Movement()
    {
        float moveInput = Input.GetAxisRaw("Horizontal");
        moveInput = (moveInput * speed) * Time.deltaTime;

        //The Movement
        player.velocity = new Vector2(moveInput, player.velocity.y);
    }

    void Jumping()
    {
        player.velocity = new Vector2(player.velocity.x, jumpV * Time.deltaTime);
    }
}


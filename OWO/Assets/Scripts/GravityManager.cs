using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityManager : MonoBehaviour
{
    public CharacterController player;
    public float gravityMutliplier;

    private void Update()
    {
        GravityController();
    }

    void GravityController()
    {
        if (player.player.velocity.y < 0f) 
        {
            player.player.velocity = new Vector2(player.player.velocity.x, (Physics2D.gravity.y * gravityMutliplier));
        }else if (player.player.velocity.y > 0f)
        {
            player.player.velocity = new Vector2(player.player.velocity.x, (Physics2D.gravity.y * gravityMutliplier));
        }
    }
}

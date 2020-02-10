using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jump : MonoBehaviour
{
    public playerController player;
    public bool jumping;
    // Start is called before the first frame update
    void Start()
    {
        player = FindObjectOfType<playerController>();
    }

    // Update is called once per frame
    void Update()
    {
        if (jumping)
        {
            player.jump();
        }
    }

    public void makePlayerJump()
    {
        jumping = true;
    }
    public void StopJumping()
    {
        jumping = false;
        player.jumping = false;
    }
}
